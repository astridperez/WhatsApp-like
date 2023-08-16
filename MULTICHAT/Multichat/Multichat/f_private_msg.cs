using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Multichat
{
    public partial class f_private_msg : Form
    {
        private string recipient;
        private Cliente client;
        private string yo;

        public f_private_msg(string recipient, Cliente client, string yo)
        {
            InitializeComponent();
            this.recipient = recipient;
            this.client = client;
            this.yo = yo;
            p_user.Text = recipient;

            // Mostrar imagen
            MostrarImagen(recipient);
        }

        public void ShowReceivedMessage(string sender, string message)
        {
            if (sender != yo)
            {
                TextBox textBox = new TextBox();
                textBox.Text = $"{sender}: {message}";
                textBox.BorderStyle = BorderStyle.None;
                textBox.BackColor = Color.SeaGreen;
                textBox.Multiline = true;
                textBox.ReadOnly = true;
                textBox.Width = 300;

                p_broadcast.Controls.Add(textBox);
            }
        }

        public void ShowSentMessage(string message)
        {
            TextBox textBox = new TextBox();
            textBox.Text = $"Yo: {message}";
            textBox.BorderStyle = BorderStyle.None;
            textBox.BackColor = Color.CadetBlue;
            textBox.Multiline = true;
            textBox.ReadOnly = true;
            textBox.Width = 300;

            p_broadcast.Controls.Add(textBox);
        }

        private void p_send_Click(object sender, EventArgs e)
        {
            string message = p_txtMessage.Text;
            client.SendPrivateMessage(recipient, message);
            p_txtMessage.Text = "";
            ShowSentMessage(message);
        }

        private void emoji(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            string emoji = button.Text;
            p_txtMessage.Text += emoji;
        }

        private void flecha_Click_1(object sender, EventArgs e)
        {
            panel_emojis.Visible = !panel_emojis.Visible;
        }

        private void MostrarImagen(string nrecipient)
        {
            // Obtén el nombre del archivo de imagen para el usuario actual
            string nombreArchivo = ObtenerNombreArchivoImagen(recipient);

            // Verifica si se encontró el archivo de imagen
            if (!string.IsNullOrEmpty(nombreArchivo))
            {
                try
                {
                    // Carga la imagen original
                    Image imagenOriginal = Image.FromFile(nombreArchivo);

                    // Ajusta el tamaño de la imagen para que coincida con el tamaño de la PictureBox
                    Image imagenAjustada = ResizeImage(imagenOriginal, pictureBox1.Width, pictureBox1.Height);

                    // Asigna la imagen ajustada al PictureBox
                    pictureBox1.Image = imagenAjustada;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private Image ResizeImage(Image imagen, int width, int height)
        {
            // Crea un nuevo objeto Bitmap con el tamaño deseado
            Bitmap imagenAjustada = new Bitmap(width, height);

            // Crea un nuevo objeto Graphics a partir del Bitmap
            using (Graphics graphics = Graphics.FromImage(imagenAjustada))
            {
                // Ajusta la calidad de interpolación para obtener un buen resultado
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

                // Dibuja la imagen original en el nuevo Bitmap con el tamaño ajustado
                graphics.DrawImage(imagen, 0, 0, width, height);
            }

            // Devuelve la imagen ajustada
            return imagenAjustada;
        }

        private string ObtenerNombreArchivoImagen(string recipient)
        {
            string pathUsuario = Path.Combine(@"C:\Users\asofi\OneDrive\Documentos\CUARTO SEMESTRE\SISTEMAS DISTRIBUIDOS\MULTICHAT\Multichat\imagenes", recipient);

            if (Directory.Exists(pathUsuario))
            {
                string[] archivosImagen = Directory.GetFiles(pathUsuario, "*.jpg");

                if (archivosImagen.Length > 0)
                {
                    // Devuelve el nombre del primer archivo de imagen encontrado
                    return archivosImagen[0];
                }
            }

            return null;
        }
    }
}
