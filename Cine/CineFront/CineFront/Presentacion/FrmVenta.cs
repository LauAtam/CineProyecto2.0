using CineBack.Datos;
using CineBack.Entidades;
using CineBack.Servicios.Implementacion;
using CineBack.Servicios.Interfaz;
using CineFront.ClienteHttp;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CineFront.Presentacion
{
    public partial class FrmVenta : Form
    {
        List<FormaPago> FormaPagoList;
        List<Pelicula> peliculaList;
        List<Cliente> Clienteslst;
        Venta nuevaVenta;
        HelperDao helper;
        DetalleVenta det;
        Servicio servicio;
        int filaButaca;
        int colButaca;
        string estadoButaca;
        public FrmVenta()
        {
            InitializeComponent();
            nuevaVenta = new Venta();
            helper = HelperDao.ObtenerHelper();
            det = new DetalleVenta();
            servicio = new Servicio();
            estadoButaca = "";
        }

        private void FrmVentaNuevo_Load(object sender, EventArgs e)
        {
            dtpFecha.Value = DateTime.Now;
            #region Metodos con servicio
            //ProximaVenta();
            //CargarFormasDePago();
            //CargarClientes();
            //CargarPeliculas();
            #endregion
            #region Metodos con API
            ProximaVentaAsync();
            CargarFormasPagoAsync();
            CargarClientesAsync();
            //El metodo CargarPeliCulasAsync tira un error, la API no carga las películas
            CargarPeliculasAsync();
            #endregion
            txtDescuento.Text = "0";
            txtPrecio.Enabled = false;
        }

        #region Metodos usando API
        private async void ProximaVentaAsync()
        {
            string url = "https://localhost:7211/api/Venta/ProximoVenta";
            var data = await ClienteSingleton.getInstance().GetAsync(url);
            int next = JsonConvert.DeserializeObject<int>(data);
            if (next > 0)
                lblventa.Text = "Venta Nro: " + next.ToString();
            else
                MessageBox.Show("Error de datos. No se puede obtener Nº de venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private async void CargarFormasPagoAsync()
        {
            string url = "https://localhost:7211/api/Venta/ConsulFormaPago";
            var data = await ClienteSingleton.getInstance().GetAsync(url);
            FormaPagoList = JsonConvert.DeserializeObject<List<FormaPago>>(data);
            cboFormaPago.DataSource = FormaPagoList;
            cboFormaPago.ValueMember = "id_forma_pago";
            cboFormaPago.DisplayMember = "forma";

        }
        private async void CargarClientesAsync()
        {
            string url = "https://localhost:7211/api/Cliente/TraerClientes";
            var data = await ClienteSingleton.getInstance().GetAsync(url);
            Clienteslst = JsonConvert.DeserializeObject<List<Cliente>>(data);
            cboCliente.DataSource = Clienteslst;
            cboCliente.ValueMember = "idCliente";
            cboCliente.DisplayMember = "nombre";

            foreach (Cliente c in Clienteslst)
            {
                c.nombreCompleto = $"{c.nombre} {c.apellido}";
            }

            cboCliente.DataSource = Clienteslst;
            cboCliente.ValueMember = "IdCliente";
            cboCliente.DisplayMember = "NombreCompleto";
        }
        private async void CargarPeliculasAsync()
        {
            string url = "https://localhost:7211/TraerPeliculas";
            var data = await ClienteSingleton.getInstance().GetAsync(url);
            peliculaList = JsonConvert.DeserializeObject<List<Pelicula>>(data);
            cboPelicula.DataSource = peliculaList;
            cboPelicula.ValueMember = "idPelicula";
            cboPelicula.DisplayMember = "titulo";

        }
        #endregion
        #region Metodos usando Servicio
        //private void CargarClientes()
        //{
        //    DataTable dt = helper.Consultar("SP_CONSULTAR_CLIENTES");

        //    // Nueva columna del DataTable con nombre y apellido juntos
        //    dt.Columns.Add("NombreCompleto", typeof(string), "Nombre + ' ' + Apellido");

        //    cboCliente.DataSource = dt;
        //    cboCliente.ValueMember = "ID";
        //    cboCliente.DisplayMember = "NombreCompleto";
        //}

        //private void CargarFormasDePago()
        //{
        //    DataTable dt = helper.Consultar("SP_CONSULTAR_FORMASPAGO");
        //    cboFormaPago.DataSource = dt;
        //    cboFormaPago.ValueMember = dt.Columns[0].ColumnName;
        //    cboFormaPago.DisplayMember = dt.Columns[1].ColumnName;
        //}
        //private void CargarPeliculas()
        //{
        //    DataTable dt = helper.Consultar("SP_MOSTRAR_PELICULAS");
        //    cboPelicula.DataSource = dt;
        //    cboPelicula.ValueMember = dt.Columns[0].ColumnName;
        //    cboPelicula.DisplayMember = dt.Columns[1].ColumnName;
        //}

        //private void ProximaVenta()
        //{
        //    int next = servicio.Proximo_Id();
        //    if (next > 0)
        //        lblventa.Text = "Venta Nro: " + next.ToString();
        //    else
        //        MessageBox.Show("Error de datos. No se puede obtener Nº de presupuesto!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //}
        #endregion
        #region Funcionalidades del Form
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnElegirButacas_Click(object sender, EventArgs e)
        {
            FrmButacas frmButacas = new FrmButacas();
            frmButacas.ShowDialog();
            filaButaca = frmButacas.PasarButaca().fila;
            colButaca = frmButacas.PasarButaca().columna;
            estadoButaca = frmButacas.PasarButaca().estado;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (filaButaca <= 0 && colButaca <= 0)
            {
                MessageBox.Show("Seleccione una butaca!!!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Existe(filaButaca, colButaca))
            {
                MessageBox.Show("La butaca ya fue seleccionada!!!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!int.TryParse(txtDescuento.Text, out _) || Convert.ToInt32(txtDescuento.Text) > 100)
            {
                MessageBox.Show("Debe ingresar un descuento válido...", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Cliente c = new Cliente();
            c.nombre = cboCliente.Text;
            Butaca b = new Butaca();
            b.fila = filaButaca;
            b.columna = colButaca;
            int descuento = Convert.ToInt32(txtDescuento.Text);
            double precio = det.CalcularPrecio(descuento);

            dgvDetalles.Rows.Add(new object[] { c.nombre, b.fila, b.columna, descuento, precio, "Quitar" });

            double total = 0;

            for (int i = 0; i < dgvDetalles.RowCount; i++)
            {
                double valor = Convert.ToDouble(dgvDetalles.Rows[i].Cells[4].Value);
                total += valor;

                txtPrecio.Text = total.ToString();
            }

            DetalleVenta detalle = new DetalleVenta(precio, descuento, b.fila, b.columna);

            nuevaVenta.AgregarDetalle(detalle);

        }
        private bool Existe(int filaButaca, int columnaButaca)
        {
            foreach (DataGridViewRow r in dgvDetalles.Rows)
            {
                if (Convert.ToInt32(r.Cells["ColFilaButaca"].Value) == filaButaca)
                {
                    if (Convert.ToInt32(r.Cells["ColColumnaButaca"].Value) == columnaButaca)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            nuevaVenta.fecha = dtpFecha.Value;
            nuevaVenta.idPelicula = ((Pelicula)cboPelicula.SelectedItem).idPelicula;
            nuevaVenta.idFormaPago = ((FormaPago)cboFormaPago.SelectedItem).id_forma_pago;
            nuevaVenta.idCliente = ((Cliente)cboCliente.SelectedItem).idCliente;

            string url = "https://localhost:7211/api/Venta/InsertarVenta";
            string data = JsonConvert.SerializeObject(nuevaVenta);
            ProximaVentaAsync();
            dgvDetalles.Rows.Clear();
            string result = await ClienteSingleton.getInstance().PostAsync(url, data);
            if (result == string.Empty)
            {
                MessageBox.Show("Se realizaron los cambios", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudieron realizar los cambios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion

        private void dgvDetalles_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                double precio = Convert.ToDouble(txtPrecio.Text);
                double precioDetEliminado = Convert.ToDouble(dgvDetalles.CurrentRow.Cells[4].Value);
                txtPrecio.Text = Convert.ToString(precio - precioDetEliminado);
                if (e.ColumnIndex == e.ColumnIndex)
                {
                    nuevaVenta.QuitarDetalle(dgvDetalles.CurrentRow.Index);
                    dgvDetalles.Rows.Remove(dgvDetalles.CurrentRow);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
                Console.WriteLine("Error:" + ex.StackTrace);
            }
        }
    }
}
