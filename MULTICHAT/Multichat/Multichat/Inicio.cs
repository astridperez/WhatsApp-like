using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using Image = System.Drawing.Image; // Alias para System.Drawing.Image


namespace Multichat
{

    public partial class Inicio : Form
    {
        private Dictionary<string, f_private_msg> privateMessageForms = new Dictionary<string, f_private_msg>();
        private Dictionary<string, publicMessage> groupMessageForms = new Dictionary<string, publicMessage>();
        private string nombreArchivo;
        private Cliente client;
        public Inicio(string nombreUsuario)
        {
            InitializeComponent();
            l_usuario.Text = nombreUsuario;
            client = new Cliente();


            // Obtén el nombre del archivo de imagen para el usuario actual
            nombreArchivo = ObtenerNombreArchivoImagen(l_usuario.Text);

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
            client.StartClient(nombreUsuario, this);
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

        private string ObtenerNombreArchivoImagen(string nombreUsuario)
        {
            string usuario = l_usuario.Text;
            string pathUsuario = Path.Combine(@"C:\Users\asofi\OneDrive\Documentos\CUARTO SEMESTRE\SISTEMAS DISTRIBUIDOS\MULTICHAT\Multichat\imagenes", usuario);

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

        private void b_send_Click(object sender, EventArgs e)
        {
            string message = txtMessage.Text;
            string userName = l_usuario.Text;

            client.SendMessages(userName, message);
            txtMessage.Text = "";
        }
        public void AppendTo(string text)
        {
            if (!text.StartsWith("user_lists"))
            {
                string yo = l_usuario.Text;

                // Mensaje enviado por ti
                if (text.StartsWith(yo))
                {
                    string[] messageParts = text.Split(':');
                    string message = messageParts[1];

                    TextBox textBox = new TextBox();
                    textBox.Multiline = true;
                    textBox.BackColor = Color.CadetBlue;
                    textBox.BorderStyle = BorderStyle.None;
                    textBox.Width = 300;
                    textBox.ReadOnly = true;
                    textBox.Text = "yo: " + message;

                    broadcast.Controls.Add(textBox);
                }

                else if (text.StartsWith("private_message"))
                {
                    PrivateMessage(text);
                }

                else if (text.StartsWith("nuevo_grupo"))
                {
                    string groupName = text.Split(":")[1];
                    string participantString = text.Split(":")[3];

                    string buttonText = "btn_" + groupName;


                    if (!panel_usuarios.Controls.ContainsKey(buttonText))
                    {
                        Button button = new Button();
                        button.Text = groupName;
                        button.Name = groupName;
                        button.Size = new Size(280, 40);
                        button.BackColor = Color.FromArgb(48, 48, 48);
                        button.FlatStyle = FlatStyle.Popup;
                        button.ForeColor = Color.White;
                        panel_usuarios.Controls.Add(button);

                        button.Click += (btnSender, btnEvent) =>
                        {
                            string recipient = button.Text;
                            if (!groupMessageForms.ContainsKey(recipient))
                            {
                                publicMessage groupForm = new publicMessage(groupName, participantString, client, yo);
                                groupMessageForms.Add(recipient, groupForm);
                            }

                            groupMessageForms[recipient].Show();
                        };
                    }
                }

                else if (text.StartsWith("group_message"))
                {
                    GroupMessage(text);
                }

                // Usuario desconectado
                else if (text.StartsWith("disconnected"))
                {
                    string[] messageParts = text.Split(':');
                    string user = messageParts[1];
                    string formattedMessage = " - se ha desconectado " + user + " -" + "\r\n";

                    TextBox textBox = new TextBox();
                    textBox.Text = formattedMessage;
                    textBox.Width = 454;
                    textBox.BackColor = Color.FromArgb(45, 45, 45);
                    textBox.ForeColor = Color.White;
                    textBox.BorderStyle = BorderStyle.None;

                    broadcast.Controls.Add(textBox);
                }

                // Otros mensajes
                else
                {
                    TextBox textBox = new TextBox();
                    textBox.Text = text;
                    textBox.BackColor = Color.SeaGreen;
                    textBox.Multiline = true;
                    textBox.BorderStyle = BorderStyle.None;
                    textBox.Width = 300;

                    broadcast.Controls.Add(textBox);
                }
            }
        }

        public void AgregarBotonUsuario(string usuarios)
        {
            string[] nombres = usuarios.Split(':')[1].Split(',');
            panel_usuarios.Controls.Clear();
            string yo = l_usuario.Text;

            foreach (string nombre in nombres)
            {
                string buttonText = "btn_" + nombre;

                if (nombre.Equals(l_usuario.Text))
                {
                    continue;
                }

                if (!panel_usuarios.Controls.ContainsKey(buttonText))
                {
                    Button button = new Button();
                    button.Text = nombre;
                    button.Name = nombre;
                    button.Size = new Size(280, 40);
                    button.BackColor = Color.FromArgb(48, 48, 48);
                    button.FlatStyle = FlatStyle.Popup;
                    button.ForeColor = Color.White;
                    panel_usuarios.Controls.Add(button);

                    button.Click += (sender, e) =>
                    {
                        if (!privateMessageForms.ContainsKey(nombre))
                        {
                            f_private_msg privateMsgForm = new f_private_msg(nombre, client, yo);
                            privateMessageForms.Add(nombre, privateMsgForm);
                        }

                        privateMessageForms[nombre].Show();
                    };
                }
            }
        }
        public void PrivateMessage(string text)
        {
            string envia = text.Split(':')[1];
            string recipient = text.Split(':')[2];
            string message = text.Split(':')[3];
            string yo = l_usuario.Text;

            if (recipient == yo)
            {
                // El mensaje es para mí
                if (privateMessageForms.ContainsKey(envia))
                {
                    privateMessageForms[envia].ShowReceivedMessage(envia, message);
                }
                else
                {
                    f_private_msg privateMsgForm = new f_private_msg(envia, client, yo);
                    privateMsgForm.ShowReceivedMessage(envia, message);
                    privateMessageForms.Add(envia, privateMsgForm);
                }
            }
            else
            {
                // El mensaje es de mí hacia otro usuario
                if (privateMessageForms.ContainsKey(recipient))
                {
                }
                else
                {
                    f_private_msg privateMsgForm = new f_private_msg(recipient, client, yo);
                    privateMessageForms.Add(recipient, privateMsgForm);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = l_usuario.Text;
            client.Disconnect(usuario);
            this.Hide();
        }

        private void Emojis(object sender, MouseEventArgs e)
        {

            Button button = (Button)sender;
            string emoji = button.Text;
            txtMessage.Text += emoji;
        }

        private void flecha_Click(object sender, EventArgs e)
        {
            panel_emojis.Visible = !panel_emojis.Visible;
        }

        private void l_bc_Click(object sender, EventArgs e)
        {

        }

        private void crear_grupo_Click(object sender, EventArgs e)
        {
            string yo = l_usuario.Text;
            string userList = GetConnectedUserList(); // Obtiene la lista de usuarios conectados

            Crear_grupo form = new Crear_grupo(userList, client);
            form.btn_create.Click += (s, ev) =>
            {
                string groupName = form.txt_groupname.Text;
                List<string> participants = new List<string>();

                foreach (string user in form.group_users.CheckedItems)
                {
                    participants.Add(user);
                }

                string participantString = string.Join(",", participants) + "," + yo;

                Dictionary<string, string> groupInfo = new Dictionary<string, string>();
                groupInfo.Add(groupName, participantString);

                Button newButton = new Button();
                newButton.Text = groupName;
                newButton.Name = "btn_" + groupName;
                newButton.Size = new Size(280, 40);
                newButton.BackColor = Color.FromArgb(48, 48, 48);
                newButton.FlatStyle = FlatStyle.Popup;
                newButton.ForeColor = Color.White;
                panel_usuarios.Controls.Add(newButton);

                newButton.Click += (btnSender, btnEvent) =>
                {
                    string recipient = newButton.Text;
                    if (!groupMessageForms.ContainsKey(recipient))
                    {
                        publicMessage groupForm = new publicMessage(groupName, participantString, client, yo);
                        groupMessageForms.Add(recipient, groupForm);
                    }

                    groupMessageForms[recipient].Show();
                };

                form.Close();
            };

            form.Show();
        }

        private string GetConnectedUserList()
        {
            string userList = "";

            foreach (Button button in panel_usuarios.Controls.OfType<Button>())
            {
                userList += button.Text + ",";
            }

            if (!string.IsNullOrEmpty(userList))
            {
                userList = userList.TrimEnd(',');
            }

            return userList;
        }

        public void GroupMessage(string text)
        {
            string grupo = text.Split(':')[1];
            string envia = text.Split(':')[2];
            string receptores = text.Split(':')[3];
            string message = text.Split(':')[4];
            string yo = l_usuario.Text;

            string[] receptorArray = receptores.Split(',');

            foreach (string receptor in receptorArray)
            {
                if (receptor.Trim() == yo)
                {
                    // El mensaje es para mí
                    if (groupMessageForms.ContainsKey(envia))
                    {
                        groupMessageForms[envia].ShowReceivedMessage(receptor, message);
                    }

                    else
                    {
                        publicMessage groupForm = new publicMessage(grupo, receptores, client, yo);
                        groupForm.ShowReceivedMessage(envia, message);
                        groupMessageForms.Add(receptor, groupForm);
                    }
                }
                else
                {
                    // El mensaje es de mí hacia otro usuario
                    if (groupMessageForms.ContainsKey(receptor))
                    {

                    }

                    else
                    {
                        publicMessage groupForm = new publicMessage(grupo, receptores, client, yo);
                        groupMessageForms.Add(receptor, groupForm);
                    }
                }
            }
        }

    }
}
