using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineFront.Presentacion
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        public void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        #region Funcionalidades del fromulario
        //Método resize para reajustar tamaño de la ventana en tiempo de ejecucion
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.panelContenedor.Region = region;
            this.Invalidate();
        }
        //COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }
        //Boton para cerrar ventana
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //posiciones iniciales de la ventana
        int x, y;
        //dimensiones iniciales de la ventana
        int w, h;
        //Boton para maximizar ventana
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            x = this.Location.X;
            y = this.Location.Y;
            w = this.Size.Width;
            h = this.Size.Height;
            btnMaximizar.Visible = false;
            btnReducir.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }
        //Boton para reducir ventana
        private void btnReducir_Click(object sender, EventArgs e)
        {
            btnReducir.Visible = false;
            btnMaximizar.Visible = true;
            this.Size = new Size(w, h);
            this.Location = new Point(x, y);
        }
        //Boton para minimizar ventana
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

        private void btnVenderEntrada_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmVenta>();
        }
        private void btnMasVistas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmMasVistas>();

        }

        private void btnPelículas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmPeliculas>();
        }

        private void btnVenderEntrada2_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmVenta>();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmClientes>();
        }

        //Metodo para abrir formulario dentro del panel contenedor de formularios
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelFormularios.Controls.OfType<MiForm>().FirstOrDefault(); //busca el formulario en la coleccion
            //si el formulario no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelFormularios.Controls.Add(formulario);
                panelFormularios.Tag = formulario;
                formulario.Show();
            }
            formulario.BringToFront();
        }
    }
}