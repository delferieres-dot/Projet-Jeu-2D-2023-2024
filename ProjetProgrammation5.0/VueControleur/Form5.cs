using ProjetProgrammation5._0.Model;
using System;
using System.Media;
using System.Windows.Forms;

namespace ProjetProgrammation5._0
{
    public partial class Form5 : Form
    {
        private Form12 form12;
        private Form13 form13;
        private Form14 form14;
        private Form15 form15;

        Utilisateur utilisateur1 = new Utilisateur();
        private Form10 form10;

        private Form10 form10Instance;
        private Form11 form11;

        private Form11 form11Instance;
        private SoundPlayer coinSound;
        public int Score => utilisateur1.score;

        public Form5()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            form10 = new Form10();
            form10Instance = new Form10();
            form11 = new Form11();
            form11Instance = new Form11();

            coinSound = new SoundPlayer(@"C:\Users\User\Downloads\potpickup.wav");

            form12 = new Form12(utilisateur1.score);
            form13 = new Form13(utilisateur1.score);
            form14 = new Form14(utilisateur1.score);
            form15 = new Form15(utilisateur1.score);
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }


        private void MainTimerEvent(object sender, EventArgs e)
        {

            PointScore.Text = "Score: " + utilisateur1.score;
            player.Top += utilisateur1.jumpSpeed;

            if (utilisateur1.goLeft == true && player.Left > 0)
            {
                player.Left -= utilisateur1.playerSpeed;
            }

            if (utilisateur1.goRight == true && player.Left + (player.Width + 60) < this.ClientSize.Width)
            {
                player.Left += utilisateur1.playerSpeed;
            }

            if (utilisateur1.goLeft == true && background.Left < 0)
            {
                background.Left += utilisateur1.backgroundSpeed;
                MoveGameElements("forward");
            }

            if (utilisateur1.goRight == true && background.Left > -300)
            {
                background.Left -= utilisateur1.backgroundSpeed;
                MoveGameElements("back");
            }

            if (utilisateur1.jumping == true)
            {
                utilisateur1.jumpSpeed = -10;
                utilisateur1.force -= 1;

            }
            else
            {
                utilisateur1.jumpSpeed = 15;
            }

            if (utilisateur1.jumping == true && utilisateur1.force < 0)
            {
                utilisateur1.jumping = false;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "platform")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && utilisateur1.jumping == false)
                    {
                        utilisateur1.force = 8;
                        player.Top = x.Top - player.Height;
                        utilisateur1.jumpSpeed = 0;

                    }
                    x.BringToFront();
                }

                if (x is PictureBox && (string)x.Tag == "coin")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                    {
                        x.Visible = false;
                        utilisateur1.score += 1;

                        coinSound.Play();
                    }

                }
                if (x is PictureBox && (string)x.Tag == "Traps3")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                    {
                        Die();
                    }

                }
            }

            if (player.Bounds.IntersectsWith(key.Bounds))
            {
                key.Visible = false;
                utilisateur1.hasKey = true;


            }
            if (player.Bounds.IntersectsWith(door.Bounds) && utilisateur1.hasKey == true)
            {
                door.Image = Properties.Resources.door_open;
                GameTimer.Stop();

                if (player.Bounds.IntersectsWith(door.Bounds) && utilisateur1.hasKey == true)
                {
                    door.Image = Properties.Resources.door_open;
                    GameTimer.Stop();

                    if (utilisateur1.score < 35 || utilisateur1.score == 35)
                    {
                        Form12 form12 = new Form12(utilisateur1.score);
                        form12.FormClosed += (s, args) =>
                        {
                            MessageBox.Show("Bravo! Tu as ouvert la porte." + Environment.NewLine + "Appuyé pour rejouer!");

                            RestartGame();

                        }; form12.Show();

                    }
                    if (utilisateur1.score > 35 && utilisateur1.score < 45 || utilisateur1.score == 45)
                    {
                        Form13 form13 = new Form13(utilisateur1.score);
                        form13.FormClosed += (s, args) =>
                        {
                            MessageBox.Show("Bravo! Tu as ouvert la porte." + Environment.NewLine + "Appuyé pour rejouer!");
                            RestartGame();
                        };
                        form13.Show();
                    }
                    if (utilisateur1.score > 45 && utilisateur1.score < 53)
                    {
                        Form14 form14 = new Form14(utilisateur1.score);
                        form14.FormClosed += (s, args) =>
                        {
                            MessageBox.Show("Bravo! Tu as ouvert la porte." + Environment.NewLine + "Appuyé pour rejouer!");
                            RestartGame();
                        };
                        form14.Show();
                    }
                    if (utilisateur1.score == 53)
                    {
                        Form15 form15 = new Form15(utilisateur1.score);
                        form15.FormClosed += (s, args) =>
                        {
                            MessageBox.Show("Bravo! Tu as ouvert la porte." + Environment.NewLine + "Appuyé pour rejouer!");
                            RestartGame();
                        };
                        form15.Show();
                    }

                }
            }
            if (player.Top + player.Height > this.ClientSize.Height)
            {
                Die();

            }
        }
        private void Die()
        {
            GameTimer.Stop();
            MessageBox.Show("Dommage, tu es mort... Aucune princesse ne vroudra sortir avec un cadavre." + Environment.NewLine + "Appuyé pour rejoué!");
            RestartGame();
        }
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                utilisateur1.goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                utilisateur1.goRight = true;
            }

            if (e.KeyCode == Keys.Space && !utilisateur1.jumping && !utilisateur1.spacePressed)
            {
                utilisateur1.jumping = true;
                utilisateur1.spacePressed = true;
            }

            if (e.KeyCode == Keys.O)
            {
                if (e.KeyCode == Keys.O)
                {
                    if (!form11Instance.Visible)
                    {
                        form11Instance.Show();
                    }

                    this.Hide();
                }
            }
            if (e.KeyCode == Keys.P)
            {
                if (e.KeyCode == Keys.P)
                {
                    if (!form10Instance.Visible)
                    {
                        form10Instance.Show();
                    }

                    this.Hide();
                }
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                utilisateur1.goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                utilisateur1.goRight = false;
            }

            if (e.KeyCode == Keys.Space)
            {
                utilisateur1.spacePressed = false;
            }

        }


        private void background_Click(object sender, EventArgs e)
        {

        }

        private void CloseGame(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void RestartGame()
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }


        private void MoveGameElements(string direction)
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "platform" || x is PictureBox && (string)x.Tag == "coin" || x is PictureBox && (string)x.Tag == "key" || x is PictureBox && (string)x.Tag == "door")
                {
                    if (direction == "back")
                    {
                        x.Left -= utilisateur1.backgroundSpeed;
                    }
                    if (direction == "forward")
                    {
                        x.Left += utilisateur1.backgroundSpeed;
                    }

                }
            }

        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {

        }
    }
}