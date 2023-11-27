using System;
using System.Windows.Forms;

public class PanelPelicula : Panel
{
    private PictureBox pictureBox;
    private TextBox txtSinopsis;
    private TextBox txtGenero;
    private TextBox txtDuracion;

    public PanelPelicula()
    {
        // Inicializa los controles
        pictureBox = new PictureBox();
        txtSinopsis = new TextBox();
        txtGenero = new TextBox();
        txtDuracion = new TextBox();

        // Configura el PictureBox
        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox.Dock = DockStyle.Left;
        pictureBox.Width = 100; // Puedes ajustar el ancho según tu preferencia

        // Configura los TextBox
        txtSinopsis.Multiline = true;
        txtGenero.Multiline = false;
        txtDuracion.Multiline = false;

        // Añade los controles al Panel
        Controls.Add(pictureBox);
        Controls.Add(txtSinopsis);
        Controls.Add(txtGenero);
        Controls.Add(txtDuracion);

        // Configura el tamaño del Panel (puedes ajustar según tus necesidades)
        Width = 400;
        Height = 120;
    }

    // Propiedades para acceder a la información desde fuera de la clase
    public Image Imagen
    {
        get { return pictureBox.Image; }
        set { pictureBox.Image = value; }
    }

    public string Sinopsis
    {
        get { return txtSinopsis.Text; }
        set { txtSinopsis.Text = value; }
    }

    public string Genero
    {
        get { return txtGenero.Text; }
        set { txtGenero.Text = value; }
    }

    public string Duracion
    {
        get { return txtDuracion.Text; }
        set { txtDuracion.Text = value; }
    }
}
