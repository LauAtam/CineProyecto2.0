using System;
using System.Windows.Forms;

namespace CineFront.Presentacion
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrase�a = txtContrase�a.Text;

            if (usuario == "admin" && contrase�a == "admin")
            {
                new FrmPrincipal().ShowDialog();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas. Int�ntalo de nuevo.");
            }
        }
    }
}