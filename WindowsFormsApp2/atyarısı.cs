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
    public partial class atyarısı : Form
    {
        public atyarısı()
        {
            InitializeComponent();
        }
        int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if((sayac %2 )== 0)
            {
                timer1.Start();
            }




            timer1.Start();
            pictureBox1.Left = 75;
            pictureBox2.Left = 75;
            pictureBox3.Left = 75;



        }
        Random rnd = new Random();

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += rnd.Next(1, 30);
            pictureBox2.Left += rnd.Next(1, 30);
            pictureBox3.Left += rnd.Next(1, 30);


            if((pictureBox1.Left +100) >= btnFinish.Left)
            {
                timer1.Stop();
                MessageBox.Show("1.At kazandı");
            }
            else if((pictureBox2.Left +100) >= btnFinish.Left)
            {
                timer1.Stop();
                MessageBox.Show("2.At kazandı");
            }
            else if ((pictureBox3.Left+100) >= btnFinish.Left)
            {
                timer1.Stop();
                MessageBox.Show("3.At kazandı");
            }






        }




    }
}
