using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_Oynatıcı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            wmpVideo.uiMode = "none";
        }
        string videooynatici,videoadi;

        private void BtnVideoac_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog() { Multiselect = false, Filter = "MP4 OYNATICI|*.mp4|ALL FILE|" };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                videooynatici = openFileDialog.FileName;
                videoadi = openFileDialog.SafeFileName;
                wmpVideo.URL = videooynatici;
                lblBaslik.Text = videoadi;
            }
        }

        private void btnOynat_Click(object sender, EventArgs e)
        {
            wmpVideo.Ctlcontrols.play();
        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            wmpVideo.Ctlcontrols.stop();
        }

        private void btnDuraklat_Click(object sender, EventArgs e)
        {
            wmpVideo.Ctlcontrols.pause();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            wmpVideo.Ctlcontrols.fastForward();
        }


        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            wmpVideo.settings.volume= trackBar1.Value;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
