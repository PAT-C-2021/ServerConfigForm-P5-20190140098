using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceMat_P1_20190140098;

namespace ServerConfigForm_P5_20190140098
{
   
   
    public partial class Form1 : Form
    {
        private ServiceHost Host;
        public Form1() 
        {
            InitializeComponent();
        }

        private void buttonON_Click(object sender, EventArgs e)
        {
            Host = new ServiceHost(typeof(Matematika));

            labelonoroff .Text = "Server ON";
            labelKet.Text = "Klik OFF untuk Mematikan Server";
            Host.Open();
            buttonON.Enabled = false;
            buttonOFF.Enabled = true;
        }

        private void buttonOFF_Click(object sender, EventArgs e)
        {
            buttonOFF.Text = "Server OFF";
            labelKet.Text = "Klik ON untuk Menjalankan Server";
            Host.Close();
            buttonOFF.Enabled = true;
            buttonOFF.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
