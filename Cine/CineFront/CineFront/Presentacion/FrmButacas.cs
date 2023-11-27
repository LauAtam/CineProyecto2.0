using CineBack.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineFront.Presentacion
{
    public partial class FrmButacas : Form
    {
        string[,] butacas = new string[10, 10];
        string estado = "Disponible";
        Butaca b = new Butaca();
        public FrmButacas()
        {
            InitializeComponent();

            for (int i = 0; i < butacas.GetLength(0); i++)
            {
                for (int j = 0; j < butacas.GetLength(1); j++)
                {
                    butacas[i, j] = "Disponible";
                }
            }
        }
        public Butaca PasarButaca()
        {
            return b;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (butacas[1, 1] == "Disponible")
            {
                bool butacaOcupada = false;
                for (int i = 0; i < butacas.GetLength(0); i++)
                {
                    for (int j = 0; j < butacas.GetLength(1); j++)
                    {
                        if (butacas[i, j] == "Ocupada")
                        {
                            butacaOcupada = true;
                            break;
                        }
                    }
                }
                if (!butacaOcupada)
                {
                    butacas[1, 1] = "Ocupada";
                    estado = "Ocupada";
                    pictureBox1.Image = Properties.Resources.Imagen4Butacas;
                    b = new Butaca(1, 1, estado);
                }
                else
                {
                    MessageBox.Show("Ya seleccionó una butaca!!!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                butacas[1, 1] = "Disponible";
                pictureBox1.Image = Properties.Resources.Imagen3Butacas;
                estado = "Disponible";
            }
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            if (butacas[1, 2] == "Disponible")
            {
                bool butacaOcupada = false;
                for (int i = 0; i < butacas.GetLength(0); i++)
                {
                    for (int j = 0; j < butacas.GetLength(1); j++)
                    {
                        if (butacas[i, j] == "Ocupada")
                        {
                            butacaOcupada = true;
                            break;
                        }
                    }
                }
                if (!butacaOcupada)
                {
                    butacas[1, 2] = "Ocupada";
                    estado = "Ocupada";
                    pictureBox22.Image = Properties.Resources.Imagen4Butacas;
                    b = new Butaca(1, 2, estado);
                }
                else
                {
                    MessageBox.Show("Ya seleccionó una butaca!!!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                butacas[1, 2] = "Disponible";
                pictureBox22.Image = Properties.Resources.Imagen3Butacas;
                estado = "Disponible";
            }
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            if (butacas[1, 3] == "Disponible")
            {
                bool butacaOcupada = false;
                for (int i = 0; i < butacas.GetLength(0); i++)
                {
                    for (int j = 0; j < butacas.GetLength(1); j++)
                    {
                        if (butacas[i, j] == "Ocupada")
                        {
                            butacaOcupada = true;
                            break;
                        }
                    }
                }
                if (!butacaOcupada)
                {
                    butacas[1, 3] = "Ocupada";
                    estado = "Ocupada";
                    pictureBox21.Image = Properties.Resources.Imagen4Butacas;
                    b = new Butaca(1, 3, estado);
                }
                else
                {
                    MessageBox.Show("Ya seleccionó una butaca!!!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                butacas[1, 3] = "Disponible";
                pictureBox21.Image = Properties.Resources.Imagen3Butacas;
                estado = "Disponible";
            }
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            if (butacas[1, 4] == "Disponible")
            {
                bool butacaOcupada = false;
                for (int i = 0; i < butacas.GetLength(0); i++)
                {
                    for (int j = 0; j < butacas.GetLength(1); j++)
                    {
                        if (butacas[i, j] == "Ocupada")
                        {
                            butacaOcupada = true;
                            break;
                        }
                    }
                }
                if (!butacaOcupada)
                {
                    butacas[1, 4] = "Ocupada";
                    estado = "Ocupada";
                    pictureBox25.Image = Properties.Resources.Imagen4Butacas;
                    b = new Butaca(1, 4, estado);
                }
                else
                {
                    MessageBox.Show("Ya seleccionó una butaca!!!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                butacas[1, 4] = "Disponible";
                pictureBox25.Image = Properties.Resources.Imagen3Butacas;
                estado = "Disponible";
            }
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            if (butacas[1, 5] == "Disponible")
            {
                bool butacaOcupada = false;
                for (int i = 0; i < butacas.GetLength(0); i++)
                {
                    for (int j = 0; j < butacas.GetLength(1); j++)
                    {
                        if (butacas[i, j] == "Ocupada")
                        {
                            butacaOcupada = true;
                            break;
                        }
                    }
                }
                if (!butacaOcupada)
                {
                    butacas[1, 5] = "Ocupada";
                    estado = "Ocupada";
                    pictureBox26.Image = Properties.Resources.Imagen4Butacas;
                    b = new Butaca(1, 5, estado);
                }
                else
                {
                    MessageBox.Show("Ya seleccionó una butaca!!!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                butacas[1, 5] = "Disponible";
                pictureBox26.Image = Properties.Resources.Imagen3Butacas;
                estado = "Disponible";
            }
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            if (butacas[1, 6] == "Disponible")
            {
                bool butacaOcupada = false;
                for (int i = 0; i < butacas.GetLength(0); i++)
                {
                    for (int j = 0; j < butacas.GetLength(1); j++)
                    {
                        if (butacas[i, j] == "Ocupada")
                        {
                            butacaOcupada = true;
                            break;
                        }
                    }
                }
                if (!butacaOcupada)
                {
                    butacas[1, 6] = "Ocupada";
                    estado = "Ocupada";
                    pictureBox23.Image = Properties.Resources.Imagen4Butacas;
                    b = new Butaca(1, 6, estado);
                }
                else
                {
                    MessageBox.Show("Ya seleccionó una butaca!!!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                butacas[1, 6] = "Disponible";
                pictureBox23.Image = Properties.Resources.Imagen3Butacas;
                estado = "Disponible";
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (butacas[2, 1] == "Disponible")
            {
                bool butacaOcupada = false;
                for (int i = 0; i < butacas.GetLength(0); i++)
                {
                    for (int j = 0; j < butacas.GetLength(1); j++)
                    {
                        if (butacas[i, j] == "Ocupada")
                        {
                            butacaOcupada = true;
                            break;
                        }
                    }
                }
                if (!butacaOcupada)
                {
                    butacas[2, 1] = "Ocupada";
                    estado = "Ocupada";
                    pictureBox5.Image = Properties.Resources.Imagen4Butacas;
                    b = new Butaca(2, 1, estado);
                }
                else
                {
                    MessageBox.Show("Ya seleccionó una butaca!!!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                butacas[2, 1] = "Disponible";
                pictureBox5.Image = Properties.Resources.Imagen3Butacas;
                estado = "Disponible";
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (butacas[2, 2] == "Disponible")
            {
                bool butacaOcupada = false;
                for (int i = 0; i < butacas.GetLength(0); i++)
                {
                    for (int j = 0; j < butacas.GetLength(1); j++)
                    {
                        if (butacas[i, j] == "Ocupada")
                        {
                            butacaOcupada = true;
                            break;
                        }
                    }
                }
                if (!butacaOcupada)
                {
                    butacas[2, 2] = "Ocupada";
                    estado = "Ocupada";
                    pictureBox2.Image = Properties.Resources.Imagen4Butacas;
                    b = new Butaca(2, 2, estado);
                }
                else
                {
                    MessageBox.Show("Ya seleccionó una butaca!!!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                butacas[2, 2] = "Disponible";
                pictureBox2.Image = Properties.Resources.Imagen3Butacas;
                estado = "Disponible";
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (butacas[2, 3] == "Disponible")
            {
                bool butacaOcupada = false;
                for (int i = 0; i < butacas.GetLength(0); i++)
                {
                    for (int j = 0; j < butacas.GetLength(1); j++)
                    {
                        if (butacas[i, j] == "Ocupada")
                        {
                            butacaOcupada = true;
                            break;
                        }
                    }
                }
                if (!butacaOcupada)
                {
                    butacas[2, 3] = "Ocupada";
                    estado = "Ocupada";
                    pictureBox8.Image = Properties.Resources.Imagen4Butacas;
                    b = new Butaca(2, 3, estado);
                }
                else
                {
                    MessageBox.Show("Ya seleccionó una butaca!!!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                butacas[2, 3] = "Disponible";
                pictureBox8.Image = Properties.Resources.Imagen3Butacas;
                estado = "Disponible";
            }
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            if (butacas[2, 4] == "Disponible")
            {
                bool butacaOcupada = false;
                for (int i = 0; i < butacas.GetLength(0); i++)
                {
                    for (int j = 0; j < butacas.GetLength(1); j++)
                    {
                        if (butacas[i, j] == "Ocupada")
                        {
                            butacaOcupada = true;
                            break;
                        }
                    }
                }
                if (!butacaOcupada)
                {
                    butacas[2, 4] = "Ocupada";
                    estado = "Ocupada";
                    pictureBox29.Image = Properties.Resources.Imagen4Butacas;
                    b = new Butaca(2, 4, estado);
                }
                else
                {
                    MessageBox.Show("Ya seleccionó una butaca!!!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                butacas[2, 4] = "Disponible";
                pictureBox29.Image = Properties.Resources.Imagen3Butacas;
                estado = "Disponible";
            }
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            if (butacas[2, 5] == "Disponible")
            {
                bool butacaOcupada = false;
                for (int i = 0; i < butacas.GetLength(0); i++)
                {
                    for (int j = 0; j < butacas.GetLength(1); j++)
                    {
                        if (butacas[i, j] == "Ocupada")
                        {
                            butacaOcupada = true;
                            break;
                        }
                    }
                }
                if (!butacaOcupada)
                {
                    butacas[2, 5] = "Ocupada";
                    estado = "Ocupada";
                    pictureBox27.Image = Properties.Resources.Imagen4Butacas;
                    b = new Butaca(2, 5, estado);
                }
                else
                {
                    MessageBox.Show("Ya seleccionó una butaca!!!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                butacas[2, 5] = "Disponible";
                pictureBox27.Image = Properties.Resources.Imagen3Butacas;
                estado = "Disponible";
            }
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            if (butacas[2, 6] == "Disponible")
            {
                bool butacaOcupada = false;
                for (int i = 0; i < butacas.GetLength(0); i++)
                {
                    for (int j = 0; j < butacas.GetLength(1); j++)
                    {
                        if (butacas[i, j] == "Ocupada")
                        {
                            butacaOcupada = true;
                            break;
                        }
                    }
                }
                if (!butacaOcupada)
                {
                    butacas[2, 6] = "Ocupada";
                    estado = "Ocupada";
                    pictureBox28.Image = Properties.Resources.Imagen4Butacas;
                    b = new Butaca(2, 6, estado);
                }
                else
                {
                    MessageBox.Show("Ya seleccionó una butaca!!!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                butacas[2, 6] = "Disponible";
                pictureBox28.Image = Properties.Resources.Imagen3Butacas;
                estado = "Disponible";
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (butacas[3, 1] == "Disponible")
            {
                bool butacaOcupada = false;
                for (int i = 0; i < butacas.GetLength(0); i++)
                {
                    for (int j = 0; j < butacas.GetLength(1); j++)
                    {
                        if (butacas[i, j] == "Ocupada")
                        {
                            butacaOcupada = true;
                            break;
                        }
                    }
                }
                if (!butacaOcupada)
                {
                    butacas[3, 1] = "Ocupada";
                    estado = "Ocupada";
                    pictureBox12.Image = Properties.Resources.Imagen4Butacas;
                    b = new Butaca(3, 1, estado);
                }
                else
                {
                    MessageBox.Show("Ya seleccionó una butaca!!!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                butacas[3, 1] = "Disponible";
                pictureBox12.Image = Properties.Resources.Imagen3Butacas;
                estado = "Disponible";
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (butacas[3, 2] == "Disponible")
            {
                bool butacaOcupada = false;
                for (int i = 0; i < butacas.GetLength(0); i++)
                {
                    for (int j = 0; j < butacas.GetLength(1); j++)
                    {
                        if (butacas[i, j] == "Ocupada")
                        {
                            butacaOcupada = true;
                            break;
                        }
                    }
                }
                if (!butacaOcupada)
                {
                    butacas[3, 2] = "Ocupada";
                    estado = "Ocupada";
                    pictureBox4.Image = Properties.Resources.Imagen4Butacas;
                    b = new Butaca(3, 2, estado);
                }
                else
                {
                    MessageBox.Show("Ya seleccionó una butaca!!!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                butacas[3, 2] = "Disponible";
                pictureBox4.Image = Properties.Resources.Imagen3Butacas;
                estado = "Disponible";
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (butacas[3, 3] == "Disponible")
            {
                bool butacaOcupada = false;
                for (int i = 0; i < butacas.GetLength(0); i++)
                {
                    for (int j = 0; j < butacas.GetLength(1); j++)
                    {
                        if (butacas[i, j] == "Ocupada")
                        {
                            butacaOcupada = true;
                            break;
                        }
                    }
                }
                if (!butacaOcupada)
                {
                    butacas[3, 3] = "Ocupada";
                    estado = "Ocupada";
                    pictureBox3.Image = Properties.Resources.Imagen4Butacas;
                    b = new Butaca(3, 3, estado);
                }
                else
                {
                    MessageBox.Show("Ya seleccionó una butaca!!!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                butacas[3, 3] = "Disponible";
                pictureBox3.Image = Properties.Resources.Imagen3Butacas;
                estado = "Disponible";
            }
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            if (butacas[3, 4] == "Disponible")
            {
                bool butacaOcupada = false;
                for (int i = 0; i < butacas.GetLength(0); i++)
                {
                    for (int j = 0; j < butacas.GetLength(1); j++)
                    {
                        if (butacas[i, j] == "Ocupada")
                        {
                            butacaOcupada = true;
                            break;
                        }
                    }
                }
                if (!butacaOcupada)
                {
                    butacas[3, 4] = "Ocupada";
                    estado = "Ocupada";
                    pictureBox24.Image = Properties.Resources.Imagen4Butacas;
                    b = new Butaca(3, 4, estado);
                }
                else
                {
                    MessageBox.Show("Ya seleccionó una butaca!!!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                butacas[3, 4] = "Disponible";
                pictureBox24.Image = Properties.Resources.Imagen3Butacas;
                estado = "Disponible";
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (butacas[3, 5] == "Disponible")
            {
                bool butacaOcupada = false;
                for (int i = 0; i < butacas.GetLength(0); i++)
                {
                    for (int j = 0; j < butacas.GetLength(1); j++)
                    {
                        if (butacas[i, j] == "Ocupada")
                        {
                            butacaOcupada = true;
                            break;
                        }
                    }
                }
                if (!butacaOcupada)
                {
                    butacas[3, 5] = "Ocupada";
                    estado = "Ocupada";
                    pictureBox6.Image = Properties.Resources.Imagen4Butacas;
                    b = new Butaca(3, 5, estado);
                }
                else
                {
                    MessageBox.Show("Ya seleccionó una butaca!!!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                butacas[3, 5] = "Disponible";
                pictureBox6.Image = Properties.Resources.Imagen3Butacas;
                estado = "Disponible";
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (butacas[3, 6] == "Disponible")
            {
                bool butacaOcupada = false;
                for (int i = 0; i < butacas.GetLength(0); i++)
                {
                    for (int j = 0; j < butacas.GetLength(1); j++)
                    {
                        if (butacas[i, j] == "Ocupada")
                        {
                            butacaOcupada = true;
                            break;
                        }
                    }
                }
                if (!butacaOcupada)
                {
                    butacas[3, 6] = "Ocupada";
                    estado = "Ocupada";
                    pictureBox7.Image = Properties.Resources.Imagen4Butacas;
                    b = new Butaca(3, 6, estado);
                }
                else
                {
                    MessageBox.Show("Ya seleccionó una butaca!!!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                butacas[3, 6] = "Disponible";
                pictureBox7.Image = Properties.Resources.Imagen3Butacas;
                estado = "Disponible";
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            PasarButaca();
            this.Dispose();
        }
    }
}
