using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multichat
{
    public partial class publicMessage : Form
    {
        private string ngrupo;
        private string receptors;
        private Cliente client;
        private string yo;
        public publicMessage(string ngrupo, string receptors, Cliente client, string yo)
        {
            InitializeComponent();
            this.ngrupo = ngrupo;
            this.receptors = receptors;
            this.client = client;
            this.yo = yo;
            l_group.Text = ngrupo;
            l_integrantes.Text = receptors;
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
                g_broadcast.Controls.Add(textBox);
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

            g_broadcast.Controls.Add(textBox);
        }

        private void emoji(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            string emoji = button.Text;
            p_txtMessage.Text += emoji;
        }

        private void g_send_Click(object sender, EventArgs e)
        {
            string message = p_txtMessage.Text;
            string enviar_a = l_integrantes.Text;
            client.SendGroupMessage(ngrupo, enviar_a, message);
            p_txtMessage.Text = "";
            ShowSentMessage(message);
        }

        private void flecha_Click(object sender, EventArgs e)
        {
            panel_emojis.Visible = !panel_emojis.Visible;
        }
    }
}
