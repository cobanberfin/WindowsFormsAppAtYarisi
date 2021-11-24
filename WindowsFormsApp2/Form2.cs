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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            progressBar1.Value = 0;
            label1.Text = "program yüklenıyor";
            timer1.Start();
        }
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac += 10;
            if(sayac <= 100)
            {
                progressBar1.Value = sayac;
            }
            else
            {
                label1.Text = "program yüklendi";
                timer1.Stop();
                sayac = 0;
            }
        }
    }
}
