using ProjetProgrammation5._0.Model;
using System;
using System.Windows.Forms;

namespace ProjetProgrammation5._0
{

    public partial class Form6 : Form
    {
        Utilisateur utilisateur2 = new Utilisateur();

        public Form6()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e) // oui 
        {
            // Masquer le formulaire actuel (Form6)
            this.Hide();

            // Masquer le formulaire Form1 s'il est ouvert
            Form form1 = Application.OpenForms["Form1"];
            if (form1 != null)
            {
                form1.Hide();
            }

            // Ouvrir le nouveau formulaire (Form3)
            Form3 form3 = new Form3();
            form3.Show();
        }


        private void button2_Click(object sender, EventArgs e) // non 
        {
            // Masquer le formulaire actuel (Form6)
            this.Hide();

            // Afficher à nouveau le formulaire précédent (Form1) s'il est toujours ouvert
            Form form1 = Application.OpenForms["Form1"];
            if (form1 != null)
            {
                form1.Show();
            }
        }


        private void PointScore_Click(object sender, EventArgs e)
        {

        }

    }
}
