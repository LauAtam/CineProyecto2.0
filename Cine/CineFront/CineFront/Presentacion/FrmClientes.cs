using CineBack.Entidades;
using CineBack.Servicios.Implementacion;
using CineFront.ClienteHttp;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineFront.Presentacion
{
    public partial class FrmClientes : Form
    {
        DataGridViewButtonColumn colQuitar = new DataGridViewButtonColumn();
        DataGridViewButtonColumn colModificar = new DataGridViewButtonColumn();
        public FrmClientes()
        {
            InitializeComponent();
        }
        private void FrmClientes_Load(object sender, EventArgs e)
        {
            MostrarClientes();
            colQuitar.HeaderText = "Quitar";
            colQuitar.Text = "Quitar";
            colModificar.HeaderText = "Modificar";
            colModificar.Text = "Modificar";
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private async void MostrarClientes()
        {
            dgvClientes.Rows.Clear();
            dgvClientes.Columns.Clear();
            string url = "https://localhost:7211/api/Cliente/TraerClientes";
            var data = await ClienteSingleton.getInstance().GetAsync(url);
            BindingList<Cliente> clientes = new BindingList<Cliente>(JsonConvert.DeserializeObject<List<Cliente>>(data));
            dgvClientes.DataSource = clientes;
            dgvClientes.Columns["idCliente"].Visible = false;
            dgvClientes.Columns["nombreCompleto"].Visible = false;
            dgvClientes.Columns.Add(colQuitar);
            dgvClientes.Columns.Add(colModificar);
        }
        private bool validar()
        {
            bool resultado = true;
            var texto = new Regex("^[a-zA-ZáéíóúÁÉÍÓÚüÜñÑ]+$");
            DateTime nacimientoCliente = dtpClienteNacimiento.Value;
            DateTime fechaActual = DateTime.Now;
            TimeSpan edad = fechaActual - nacimientoCliente;
            if (string.IsNullOrEmpty(txtClienteNombre.Text) || !texto.IsMatch(txtClienteNombre.Text))
            {
                MessageBox.Show("Debe ingresar un NOMBRE válido", "Control"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Exclamation);
                resultado = false;
            }
            if (string.IsNullOrEmpty(txtClienteApellido.Text) || !texto.IsMatch(txtClienteApellido.Text))
            {
                MessageBox.Show("Debe ingresar un APELLIDO válido", "Control"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Exclamation);
                resultado = false;
            }
            if (Math.Floor(edad.TotalDays / 365) < 18)
            {
                MessageBox.Show("El cliente debe ser mayor de edad", "Control"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Exclamation);
                resultado = false;
            }
            return resultado;
        }

        private async void btnInsertar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                string url = "https://localhost:7211/api/Cliente/InsertarClientes";
                string data = "";
                Cliente c = new Cliente();
                c.nombre = txtClienteNombre.Text;
                c.apellido = txtClienteApellido.Text;
                c.telefono = mTxtClienteTel.Text;
                c.fechaNac = dtpClienteNacimiento.Value;
                data = JsonConvert.SerializeObject(c);
                string result = await ClienteSingleton.getInstance().PostAsync(url, data);
                if (result == string.Empty)
                {
                    MessageBox.Show("Se realizaron los cambios", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("No se pudieron realizar los cambios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            MostrarClientes();
        }
        private async void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == colQuitar.Index)
            {
                int id = Convert.ToInt32(dgvClientes.CurrentRow.Cells["idCliente"].Value); //PASAR ID
                dgvClientes.Rows.Remove(dgvClientes.CurrentRow);

                string url = "https://localhost:7211/api/Cliente/DeleteClient?id=" + Convert.ToString(id);
                string data = JsonConvert.SerializeObject(id);
                string result = await ClienteSingleton.getInstance().DeleteAsync(url, data);
                if (result == string.Empty)
                {
                    MessageBox.Show("Se realizaron los cambios", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("No se pudieron realizar los cambios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            if (e.ColumnIndex == colModificar.Index)
            {
                if (validar())
                {
                    Cliente cliente = new Cliente();
                    cliente.idCliente = Convert.ToInt32(dgvClientes.CurrentRow.Cells["idCliente"].Value);
                    cliente.nombre = txtClienteNombre.Text;
                    cliente.apellido = txtClienteApellido.Text;
                    cliente.telefono = mTxtClienteTel.Text;
                    cliente.fechaNac = dtpClienteNacimiento.Value;
                    dgvClientes.Refresh();

                    string url = "https://localhost:7211/api/Cliente/ActualizarClientes";
                    string data = JsonConvert.SerializeObject(cliente);
                    string result = await ClienteSingleton.getInstance().PutAsync(url, data);
                    if (result == string.Empty)
                    {
                        MessageBox.Show("Se realizaron los cambios", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("No se pudieron realizar los cambios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            MostrarClientes();
        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
