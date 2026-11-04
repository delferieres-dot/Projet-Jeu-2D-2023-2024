using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetProgrammation5._0
{
    public partial class Form2 : Form
    {
        private SoundPlayer son;

        public Form2()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            // Initialiser le lecteur audio avec votre fichier audio
            son = new SoundPlayer(@"C:\Users\User\Downloads\Ove Melaa - Heaven Sings.wav"); // Remplacez par le chemin de votre fichier audio
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Jouer le son quand le formulaire est chargé
            son.PlayLooping();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
        // Assurez-vous de libérer les ressources du lecteur audio
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            son.Dispose();
        }
    }
}
