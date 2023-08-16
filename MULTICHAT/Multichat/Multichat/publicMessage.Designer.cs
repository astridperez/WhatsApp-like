namespace Multichat
{
    partial class publicMessage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(publicMessage));
            flecha = new Button();
            panel_emojis = new FlowLayoutPanel();
            feliz = new Button();
            triste = new Button();
            risa = new Button();
            enamorado = new Button();
            laroca = new Button();
            g_send = new Button();
            p_txtMessage = new TextBox();
            l_group = new Label();
            g_broadcast = new FlowLayoutPanel();
            l_integrantes = new Label();
            panel_emojis.SuspendLayout();
            SuspendLayout();
            // 
            // flecha
            // 
            flecha.BackColor = Color.FromArgb(45, 45, 45);
            flecha.BackgroundImage = (Image)resources.GetObject("flecha.BackgroundImage");
            flecha.BackgroundImageLayout = ImageLayout.Stretch;
            flecha.FlatStyle = FlatStyle.Popup;
            flecha.ForeColor = Color.White;
            flecha.Location = new Point(25, 427);
            flecha.Margin = new Padding(3, 4, 3, 4);
            flecha.Name = "flecha";
            flecha.Size = new Size(31, 30);
            flecha.TabIndex = 24;
            flecha.UseVisualStyleBackColor = false;
            flecha.Click += flecha_Click;
            // 
            // panel_emojis
            // 
            panel_emojis.Controls.Add(feliz);
            panel_emojis.Controls.Add(triste);
            panel_emojis.Controls.Add(risa);
            panel_emojis.Controls.Add(enamorado);
            panel_emojis.Controls.Add(laroca);
            panel_emojis.Location = new Point(22, 362);
            panel_emojis.Margin = new Padding(3, 4, 3, 4);
            panel_emojis.Name = "panel_emojis";
            panel_emojis.Size = new Size(287, 47);
            panel_emojis.TabIndex = 23;
            panel_emojis.Visible = false;
            // 
            // feliz
            // 
            feliz.BackColor = Color.FromArgb(255, 192, 255);
            feliz.ForeColor = Color.Black;
            feliz.Location = new Point(3, 4);
            feliz.Margin = new Padding(3, 4, 3, 4);
            feliz.Name = "feliz";
            feliz.Size = new Size(50, 38);
            feliz.TabIndex = 4;
            feliz.Text = "😃";
            feliz.UseVisualStyleBackColor = false;
            feliz.MouseClick += emoji;
            // 
            // triste
            // 
            triste.BackColor = Color.LightSteelBlue;
            triste.ForeColor = Color.Black;
            triste.Location = new Point(59, 4);
            triste.Margin = new Padding(3, 4, 3, 4);
            triste.Name = "triste";
            triste.Size = new Size(50, 38);
            triste.TabIndex = 5;
            triste.Text = "😔";
            triste.UseVisualStyleBackColor = false;
            triste.MouseClick += emoji;
            // 
            // risa
            // 
            risa.BackColor = Color.FromArgb(255, 255, 192);
            risa.ForeColor = Color.Black;
            risa.Location = new Point(115, 4);
            risa.Margin = new Padding(3, 4, 3, 4);
            risa.Name = "risa";
            risa.Size = new Size(50, 38);
            risa.TabIndex = 6;
            risa.Text = "😂";
            risa.UseVisualStyleBackColor = false;
            risa.MouseClick += emoji;
            // 
            // enamorado
            // 
            enamorado.BackColor = Color.FromArgb(255, 192, 192);
            enamorado.ForeColor = Color.Black;
            enamorado.Location = new Point(171, 4);
            enamorado.Margin = new Padding(3, 4, 3, 4);
            enamorado.Name = "enamorado";
            enamorado.Size = new Size(50, 38);
            enamorado.TabIndex = 7;
            enamorado.Text = "😍";
            enamorado.UseVisualStyleBackColor = false;
            enamorado.MouseClick += emoji;
            // 
            // laroca
            // 
            laroca.BackColor = Color.FromArgb(192, 255, 192);
            laroca.ForeColor = Color.Black;
            laroca.Location = new Point(227, 4);
            laroca.Margin = new Padding(3, 4, 3, 4);
            laroca.Name = "laroca";
            laroca.Size = new Size(50, 38);
            laroca.TabIndex = 8;
            laroca.Text = "\U0001f928";
            laroca.UseVisualStyleBackColor = false;
            laroca.MouseClick += emoji;
            // 
            // g_send
            // 
            g_send.BackColor = Color.FromArgb(45, 45, 45);
            g_send.FlatStyle = FlatStyle.System;
            g_send.Location = new Point(369, 424);
            g_send.Margin = new Padding(3, 4, 3, 4);
            g_send.Name = "g_send";
            g_send.Size = new Size(85, 38);
            g_send.TabIndex = 22;
            g_send.Text = "send";
            g_send.UseVisualStyleBackColor = false;
            g_send.Click += g_send_Click;
            // 
            // p_txtMessage
            // 
            p_txtMessage.BackColor = Color.FromArgb(45, 45, 45);
            p_txtMessage.BorderStyle = BorderStyle.None;
            p_txtMessage.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            p_txtMessage.ForeColor = Color.White;
            p_txtMessage.Location = new Point(62, 427);
            p_txtMessage.Margin = new Padding(3, 4, 3, 4);
            p_txtMessage.Name = "p_txtMessage";
            p_txtMessage.Size = new Size(302, 30);
            p_txtMessage.TabIndex = 21;
            // 
            // l_group
            // 
            l_group.AutoSize = true;
            l_group.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            l_group.ForeColor = Color.White;
            l_group.Location = new Point(49, 0);
            l_group.Name = "l_group";
            l_group.Size = new Size(108, 38);
            l_group.TabIndex = 20;
            l_group.Text = "usuario";
            // 
            // g_broadcast
            // 
            g_broadcast.BackgroundImage = (Image)resources.GetObject("g_broadcast.BackgroundImage");
            g_broadcast.BackgroundImageLayout = ImageLayout.Stretch;
            g_broadcast.FlowDirection = FlowDirection.TopDown;
            g_broadcast.Location = new Point(1, 64);
            g_broadcast.Name = "g_broadcast";
            g_broadcast.Size = new Size(482, 414);
            g_broadcast.TabIndex = 25;
            // 
            // l_integrantes
            // 
            l_integrantes.AutoSize = true;
            l_integrantes.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            l_integrantes.ForeColor = Color.White;
            l_integrantes.Location = new Point(65, 38);
            l_integrantes.Name = "l_integrantes";
            l_integrantes.Size = new Size(73, 23);
            l_integrantes.TabIndex = 26;
            l_integrantes.Text = "usuarios";
            // 
            // publicMessage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(471, 474);
            Controls.Add(l_integrantes);
            Controls.Add(flecha);
            Controls.Add(panel_emojis);
            Controls.Add(g_send);
            Controls.Add(p_txtMessage);
            Controls.Add(l_group);
            Controls.Add(g_broadcast);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "publicMessage";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Group";
            panel_emojis.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button flecha;
        private FlowLayoutPanel panel_emojis;
        private Button feliz;
        private Button triste;
        private Button risa;
        private Button enamorado;
        private Button laroca;
        private Button g_send;
        private TextBox p_txtMessage;
        private Label l_group;
        private FlowLayoutPanel g_broadcast;
        private Label l_integrantes;
    }
}