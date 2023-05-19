using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UC12_JOGO_DA_VELHA
{
    public partial class Form1 : Form
    {
        int vez = 0;
        string ponto = ".";
        string ponto2 = ".";
        string ponto3 = ".";
        string ponto4 = ".";
        string ponto5 = ".";
        string ponto6 = ".";
        string ponto7 = ".";
        string ponto8 = ".";
        string ponto9 = ".";

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (vez == 0)
            {
                MessageBox.Show("Jogador 1");
                pictureBox1.Image = Properties.Resources.x1;
                ponto = "x";

                if (ponto == "x" && ponto4 == "x" && ponto7 == "x" || ponto == "x" && ponto5 == "x" && ponto9 == "x" || ponto == "x" && ponto2 == "x" && ponto3 == "x")
                {
                    MessageBox.Show("Jogador 1 você venceu");
                }
                else
                {
                    vez = 1;
                }
            }

            else
            {
                MessageBox.Show("Jogador 2");
                pictureBox1.Image = Properties.Resources.o1;
                ponto = "o";

                if (ponto == "o" && ponto4 == "o" && ponto7 == "o" || ponto == "o" && ponto5 == "o" && ponto9 == "o" || ponto == "o" && ponto2 == "o" && ponto3 == "o")
                {
                    MessageBox.Show("Jogador 2 você venceu");
                }
                else
                {
                    vez = 0;
                }
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (vez == 0)
            {
                MessageBox.Show("Jogador 1");
                pictureBox2.Image = Properties.Resources.x1;
                ponto2 = "x";

                if (ponto2 == "x" && ponto5 == "x" && ponto8 == "x" || ponto2 == "x" && ponto3 == "x" && ponto == "x")
                {
                    MessageBox.Show("Jogador 1 você venceu");
                }
                else
                {
                    vez = 1;
                }
            }

            else
            {
                MessageBox.Show("Jogador 2");
                pictureBox2.Image = Properties.Resources.o1;
                ponto2 = "o";

                if (ponto2 == "o" && ponto5 == "o" && ponto8 == "o" || ponto2 == "o" && ponto3 == "o" && ponto == "o")
                {
                    MessageBox.Show("Jogador 2 você venceu");
                }
                else
                {
                    vez = 0;
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (vez == 0)
            {
                MessageBox.Show("Jogador 1");
                pictureBox3.Image = Properties.Resources.x1;
                ponto3 = "x";

                if (ponto3 == "x" && ponto5 == "x" && ponto7 == "x" || ponto3 == "x" && ponto2 == "x" && ponto == "x" || ponto3 == "x" && ponto6 == "x" && ponto9 == "x")
                {
                    MessageBox.Show("Jogador 1 você venceu");
                }
                else
                {
                    vez = 1;
                }
            }

            else
            {
                if (ponto3 == "o")
                MessageBox.Show("Jogador 2");
                pictureBox3.Image = Properties.Resources.o1;
                ponto3 = "o";

                if (ponto3 == "o" && ponto5 == "o" && ponto7 == "o" || ponto3 == "o" && ponto2 == "o" && ponto == "o" || ponto3 == "o" && ponto6 == "o" && ponto9 == "o")
                {
                    MessageBox.Show("Jogador 2 você venceu");
                }
                else
                {
                    vez = 0;
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (vez == 0)
            {
                MessageBox.Show("Jogador 1");
                pictureBox4.Image = Properties.Resources.x1;
                ponto4 = "x";

                if (ponto == "x" && ponto4 == "x" && ponto7 == "x" || ponto6 == "x" && ponto5 == "x" && ponto4 == "x")
                {
                    MessageBox.Show("Jogador 1 você venceu");
                }
                else
                {
                    vez = 1;
                }
            }

            else
            {
                MessageBox.Show("Jogador 2");
                pictureBox4.Image = Properties.Resources.o1;
                ponto4 = "o";

                if (ponto == "o" && ponto4 == "o" && ponto7 == "o" || ponto6 == "o" && ponto5 == "o" && ponto4 == "o")
                {
                    MessageBox.Show("Jogador 2 você venceu");
                }
                else
                {
                    vez = 0;
                }
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (vez == 0)
            {
                MessageBox.Show("Jogador 1");
                pictureBox5.Image = Properties.Resources.x1;
                ponto5 = "x";

                if (ponto == "x" && ponto5 == "x" && ponto9 == "x" || ponto2 == "x" && ponto5 == "x" && ponto8 == "x" || ponto3 == "x" && ponto5 == "x" && ponto7 == "x" || ponto6 == "x" && ponto5 == "x" && ponto4 == "x")
                {
                    MessageBox.Show("Jogador 1 você venceu");
                }
                else
                {
                    vez = 1;
                }
            }

            else
            {
                MessageBox.Show("Jogador 2");
                pictureBox5.Image = Properties.Resources.o1;
                ponto5 = "o";

                if (ponto == "o" && ponto5 == "o" && ponto9 == "o" || ponto2 == "o" && ponto5 == "o" && ponto8 == "o" || ponto3 == "o" && ponto5 == "o" && ponto7 == "o" || ponto6 == "o" && ponto5 == "o" && ponto4 == "o")
                {
                    MessageBox.Show("Jogador 2 você venceu");
                }
                else
                {
                    vez = 0;
                }
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (vez == 0)
            {
                MessageBox.Show("Jogador 1");
                pictureBox6.Image = Properties.Resources.x1;
                ponto6 = "x";

                if (ponto3 == "x" && ponto6 == "x" && ponto9 == "x" || ponto6 == "x" && ponto5 == "x" && ponto4 == "x")
                {
                    MessageBox.Show("Jogador 1 você venceu");
                }
                else
                {
                    vez = 1;
                }
            }

            else
            {
                MessageBox.Show("Jogador 2");
                pictureBox6.Image = Properties.Resources.o1;
                ponto6 = "o";

                if (ponto3 == "o" && ponto6 == "o" && ponto9 == "o" || ponto6 == "o" && ponto5 == "o" && ponto4 == "o")
                {
                    MessageBox.Show("Jogador 2 você venceu");
                }
                else
                {
                    vez = 0;
                }
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (vez == 0)
            {
                MessageBox.Show("Jogador 1");
                pictureBox7.Image = Properties.Resources.x1;
                ponto7 = "x";

                if (ponto == "x" && ponto4 == "x" && ponto7 == "x" || ponto9 == "x" && ponto8 == "x" && ponto7 == "x")
                {
                    MessageBox.Show("Jogador 1 você venceu");
                }
                else
                {
                    vez = 1;
                }
            }

            else
            {
                MessageBox.Show("Jogador 2");
                pictureBox7.Image = Properties.Resources.o1;
                ponto7 = "o";

                if (ponto == "o" && ponto4 == "o" && ponto7 == "o" || ponto9 == "o" && ponto8 == "o" && ponto7 == "o")
                {
                    MessageBox.Show("Jogador 2 você venceu");
                }
                else
                {
                    vez = 0;
                }
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (vez == 0)
            {
                MessageBox.Show("Jogador 1");
                pictureBox8.Image = Properties.Resources.x1;
                ponto8 = "x";

                if (ponto7 == "x" && ponto8 == "x" && ponto9 == "x" || ponto2 == "x" && ponto5 == "x" && ponto8 == "x")
                {
                    MessageBox.Show("Jogador 1 você venceu");
                }
                else
                {
                    vez = 1;
                }
            }

            else
            {
                MessageBox.Show("Jogador 2");
                pictureBox8.Image = Properties.Resources.o1;
                ponto8 = "o";

                if (ponto7 == "o" && ponto8 == "o" && ponto9 == "o" || ponto2 == "o" && ponto5 == "o" && ponto8 == "o")
                {
                    MessageBox.Show("Jogador 2 você venceu");
                }
                else
                {
                    vez = 0;
                }
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (vez == 0)
            {
                MessageBox.Show("Jogador 1");
                pictureBox9.Image = Properties.Resources.x1;
                ponto9 = "x";

                if (ponto7 == "x" && ponto8 == "x" && ponto9 == "x" || ponto3 == "x" && ponto6 == "x" && ponto9 == "x")
                {
                    MessageBox.Show("Jogador 1 você venceu");
                }
                else
                {
                    vez = 1;

                }
            }

            else
            {
                MessageBox.Show("Jogador 2");
                pictureBox9.Image = Properties.Resources.o1;
                ponto9 = "o";

                if (ponto7 == "o" && ponto8 == "o" && ponto9 == "o" || ponto3 == "o" && ponto6 == "o" && ponto9 == "o")
                {
                    MessageBox.Show("Jogador 2 você venceu");
                }
                else
                {
                    vez = 0;
                }
            }
        }
    }
}
