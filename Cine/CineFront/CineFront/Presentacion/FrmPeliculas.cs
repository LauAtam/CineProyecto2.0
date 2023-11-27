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
    public partial class FrmPeliculas : Form
    {
        public FrmPeliculas()
        {
            InitializeComponent();
            CrearListaPeliculas();
        }
        private void CrearListaPeliculas()
        {
            // Crea una lista de objetos PanelPelicula
            List<PanelPelicula> listaPeliculas = new List<PanelPelicula>();

            // Agrega elementos a la lista (puedes hacerlo dinámicamente según tu lógica)
            //listaPeliculas.Add(new PanelPelicula { Imagen = Image.FromFile(Properties.Resources.PortadaLosIncreibles.ToString()), Sinopsis = "Sinopsis 1", Genero = "Género 1", Duracion = "Duración 1" });
            //listaPeliculas.Add(new PanelPelicula { Imagen = Image.FromFile(Properties.Resources.PortadaNemo.ToString()), Sinopsis = "Sinopsis 2", Genero = "Género 2", Duracion = "Duración 2" });
            // ...

            // Agrega los paneles al formulario
            foreach (var panelPelicula in listaPeliculas)
            {
                Controls.Add(panelPelicula);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
