using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
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
            var webClient = new WebClient();

            barraProgresso.Visible = true;
            var data = webClient.DownloadData(new Uri(txtUrl.Text.Trim()));
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
