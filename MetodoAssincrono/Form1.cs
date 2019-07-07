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

        private async void btnBaixar_Click(object sender, EventArgs e)
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
            var data = await webClient.DownloadDataTaskAsync(new Uri(txtUrl.Text.Trim()));

            barraProgresso.Visible = false;
            pbImagem.Visible = true;

            using (var memStream = new MemoryStream(data))
            {
                memStream.Seek(0, SeekOrigin.Begin);
                pbImagem.Image = new Bitmap(memStream);
            }
        }
    }
}
