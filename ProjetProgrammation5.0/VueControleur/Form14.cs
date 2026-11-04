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
    public partial class Form14 : Form
    {
        public Form1 form1Instance;
        public Form4 form4Instance;
        public Form5 form5Instance;

        public Form14(int initialScore)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            label1.Text = "Score: " + initialScore.ToString();
        }

        private void Form14_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void UpdateScore(int score)
        {
            label1.Text = "Score: " + score.ToString();
        }
        private void PointScore_Click(object sender, EventArgs e)
        {
            this.Text = "Score: " + form1Instance.Score;
            this.Text = "Score: " + form4Instance.Score;
            this.Text = "Score: " + form5Instance.Score;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

}