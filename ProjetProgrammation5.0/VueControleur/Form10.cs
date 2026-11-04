using ProjetProgrammation5._0.Model;
using System;
using System.Windows.Forms;

namespace ProjetProgrammation5._0
{

    public partial class Form10 : Form
    {
        Utilisateur utilisateur2 = new Utilisateur();

        public Form10()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e) // oui 
        {
            // Masquer le formulaire actuel (Form6)
            this.Hide();

            // Masquer le formulaire Form1 s'il est ouvert
            Form form5 = Application.OpenForms["Form5"];
            if (form5 != null)
            {
                form5.Hide();
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
            Form form5 = Application.OpenForms["Form5"];
            if (form5 != null)
            {
                form5.Show();
            }
        }


        private void PointScore_Click(object sender, EventArgs e)
        {

        }

    }
}
