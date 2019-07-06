using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace MetodoAssincrono
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBaixar_Click(object sender, EventArgs e)
        {
            // forma sincrona

            //var webClient = new WebClient();

            //barraProgresso.Visible = true;
            //var data = webClient.DownloadData(new Uri(txtUrl.Text.Trim()));
            //barraProgresso.Visible = false;

            //pbImagem.Visible = true;

            //using (var memStream = new MemoryStream(data))
            //{
            //    memStream.Seek(0, SeekOrigin.Begin);
            //    pbImagem.Image = new Bitmap(memStream);
            //}


            // forma assincrona

            var webClient = new WebClient();

            barraProgresso.Visible = true;

            // vai entrar aqui quando estiver completado
            // porque é assincrono
            // exdecuta quando uma operação assincrona é concluida
            webClient.DownloadDataCompleted += (o, args) =>
            {
                barraProgresso.Visible = false;

                pbImagem.Visible = true;

                using (var memStream = new MemoryStream(args.Result))
                {
                    memStream.Seek(0, SeekOrigin.Begin);
                    pbImagem.Image = new Bitmap(memStream);
                }
            };

            webClient.DownloadDataAsync(new Uri(txtUrl.Text.Trim()));
            
        }
    }
}
