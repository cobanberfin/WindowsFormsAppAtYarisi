using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "0";
            
        }
        int sayac;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //çalıştıgnda yapcak işlemler
            sayac++;
            label1.Text = sayac.ToString();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();    
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            label1.Text = "0";

        }

        
    }
}
