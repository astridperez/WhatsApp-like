using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Multichat
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void b_inicio_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtName.Text;
            Inicio form = new Inicio(nombreUsuario);
            form.Show();
            this.Hide();
        }

        private void imagen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de imagen|*.jpg;*.png";
                openFileDialog.Title = "Seleccionar imagen";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string nombreUsuario = txtName.Text;
                    string pathDestino = @"C:\Users\asofi\OneDrive\Documentos\CUARTO SEMESTRE\SISTEMAS DISTRIBUIDOS\MULTICHAT\Multichat\imagenes\" + nombreUsuario;

                    // Crear el directorio si no existe
                    if (!Directory.Exists(pathDestino))
                        Directory.CreateDirectory(pathDestino);

                    // Obtener el nombre del archivo seleccionado
                    string nombreArchivo = Path.GetFileName(openFileDialog.FileName);

                    // Construir la ruta de destino completa
                    string rutaDestino = Path.Combine(pathDestino, nombreArchivo);

                    try
                    {
                        // Copiar la imagen al destino
                        File.Copy(openFileDialog.FileName, rutaDestino);
                        MessageBox.Show("Imagen subida exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Realizar las acciones adicionales
                        Inicio form = new Inicio(nombreUsuario);
                        form.Show();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al subir la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}