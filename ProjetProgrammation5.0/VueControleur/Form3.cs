using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetProgrammation5._0
{
    public partial class Form3 : Form
    {
        private Form1 form1Instance;
        private Form4 form4Instance;


        public Form3()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            form1Instance = new Form1();
            form4Instance = new Form4();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        { 
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            if (!form1Instance.Visible)
            {
                form1Instance.Show();
            }

            // Fermez ce formulaire (Form3)
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (!form4Instance.Visible)
            {
                form4Instance.Show();
            }

            // Fermez ce formulaire (Form3)
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
      


    }
}
