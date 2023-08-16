namespace Multichat
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            l_usuario = new Label();
            txtMessage = new TextBox();
            b_send = new Button();
            panel_usuarios = new FlowLayoutPanel();
            l_bc = new Label();
            panel1 = new Panel();
            crear_grupo = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            flecha = new Button();
            panel_emojis = new FlowLayoutPanel();
            feliz = new Button();
            triste = new Button();
            risa = new Button();
            enamorado = new Button();
            laroca = new Button();
            broadcast = new FlowLayoutPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel_emojis.SuspendLayout();
            SuspendLayout();
            // 
            // l_usuario
            // 
            l_usuario.AutoSize = true;
            l_usuario.Font = new Font("Poppins", 15F, FontStyle.Regular, GraphicsUnit.Point);
            l_usuario.ForeColor = Color.White;
            l_usuario.Location = new Point(56, 6);
            l_usuario.Name = "l_usuario";
            l_usuario.Size = new Size(113, 44);
            l_usuario.TabIndex = 0;
            l_usuario.Text = "Usuario";
            // 
            // txtMessage
            // 
            txtMessage.BackColor = Color.FromArgb(44, 44, 44);
            txtMessage.BorderStyle = BorderStyle.None;
            txtMessage.Font = new Font("Poppins", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtMessage.ForeColor = Color.White;
            txtMessage.Location = new Point(332, 529);
            txtMessage.Margin = new Padding(3, 5, 3, 5);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(314, 27);
            txtMessage.TabIndex = 1;
            // 
            // b_send
            // 
            b_send.BackColor = Color.FromArgb(44, 44, 44);
            b_send.FlatStyle = FlatStyle.System;
            b_send.ForeColor = Color.White;
            b_send.Location = new Point(654, 526);
            b_send.Margin = new Padding(1);
            b_send.Name = "b_send";
            b_send.Size = new Size(65, 35);
            b_send.TabIndex = 2;
            b_send.Text = "send";
            b_send.TextAlign = ContentAlignment.TopCenter;
            b_send.UseVisualStyleBackColor = false;
            b_send.Click += b_send_Click;
            // 
            // panel_usuarios
            // 
            panel_usuarios.BackColor = Color.Transparent;
            panel_usuarios.FlowDirection = FlowDirection.TopDown;
            panel_usuarios.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel_usuarios.Location = new Point(-9, 97);
            panel_usuarios.Margin = new Padding(3, 4, 3, 4);
            panel_usuarios.Name = "panel_usuarios";
            panel_usuarios.Size = new Size(295, 428);
            panel_usuarios.TabIndex = 4;
            // 
            // l_bc
            // 
            l_bc.AutoSize = true;
            l_bc.BackColor = Color.Transparent;
            l_bc.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            l_bc.ForeColor = Color.White;
            l_bc.Location = new Point(292, 9);
            l_bc.Name = "l_bc";
            l_bc.Size = new Size(107, 31);
            l_bc.TabIndex = 6;
            l_bc.Text = "Broadcast";
            l_bc.Click += l_bc_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 40, 40);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(crear_grupo);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel_usuarios);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(l_usuario);
            panel1.Location = new Point(0, -3);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(286, 590);
            panel1.TabIndex = 7;
            // 
            // crear_grupo
            // 
            crear_grupo.BackgroundImage = (Image)resources.GetObject("crear_grupo.BackgroundImage");
            crear_grupo.BackgroundImageLayout = ImageLayout.Zoom;
            crear_grupo.FlatStyle = FlatStyle.Flat;
            crear_grupo.Font = new Font("Poppins", 15F, FontStyle.Regular, GraphicsUnit.Point);
            crear_grupo.ForeColor = Color.FromArgb(40, 40, 40);
            crear_grupo.Location = new Point(240, 54);
            crear_grupo.Name = "crear_grupo";
            crear_grupo.Size = new Size(41, 36);
            crear_grupo.TabIndex = 22;
            crear_grupo.TextAlign = ContentAlignment.TopCenter;
            crear_grupo.UseVisualStyleBackColor = true;
            crear_grupo.Click += crear_grupo_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 47);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Poppins", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 54);
            label1.Name = "label1";
            label1.Size = new Size(82, 39);
            label1.TabIndex = 22;
            label1.Text = "Chats";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(40, 40, 40);
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(14, 532);
            button1.Name = "button1";
            button1.Size = new Size(259, 32);
            button1.TabIndex = 8;
            button1.Text = "log out    ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // flecha
            // 
            flecha.BackColor = Color.FromArgb(45, 45, 45);
            flecha.BackgroundImage = (Image)resources.GetObject("flecha.BackgroundImage");
            flecha.BackgroundImageLayout = ImageLayout.Stretch;
            flecha.FlatStyle = FlatStyle.Flat;
            flecha.ForeColor = Color.FromArgb(45, 45, 45);
            flecha.Location = new Point(297, 529);
            flecha.Margin = new Padding(3, 4, 3, 4);
            flecha.Name = "flecha";
            flecha.Size = new Size(29, 29);
            flecha.TabIndex = 20;
            flecha.UseVisualStyleBackColor = false;
            flecha.Click += flecha_Click;
            // 
            // panel_emojis
            // 
            panel_emojis.BackColor = Color.FromArgb(40, 40, 40);
            panel_emojis.Controls.Add(feliz);
            panel_emojis.Controls.Add(triste);
            panel_emojis.Controls.Add(risa);
            panel_emojis.Controls.Add(enamorado);
            panel_emojis.Controls.Add(laroca);
            panel_emojis.Location = new Point(294, 469);
            panel_emojis.Margin = new Padding(3, 4, 3, 4);
            panel_emojis.Name = "panel_emojis";
            panel_emojis.Size = new Size(285, 47);
            panel_emojis.TabIndex = 19;
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
            feliz.MouseClick += Emojis;
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
            triste.MouseClick += Emojis;
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
            risa.MouseClick += Emojis;
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
            enamorado.MouseClick += Emojis;
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
            laroca.MouseClick += Emojis;
            // 
            // broadcast
            // 
            broadcast.BackColor = Color.FromArgb(44, 44, 44);
            broadcast.BackgroundImage = (Image)resources.GetObject("broadcast.BackgroundImage");
            broadcast.BackgroundImageLayout = ImageLayout.Stretch;
            broadcast.FlowDirection = FlowDirection.TopDown;
            broadcast.Location = new Point(288, 43);
            broadcast.Name = "broadcast";
            broadcast.Size = new Size(446, 531);
            broadcast.TabIndex = 21;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(9F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(735, 573);
            Controls.Add(flecha);
            Controls.Add(panel_emojis);
            Controls.Add(panel1);
            Controls.Add(l_bc);
            Controls.Add(b_send);
            Controls.Add(txtMessage);
            Controls.Add(broadcast);
            Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Inicio";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ip";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel_emojis.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label l_usuario;
        private TextBox txtMessage;
        private Button b_send;
        private FlowLayoutPanel panel_usuarios;
        private Label l_bc;
        private Panel panel1;
        private Button button1;
        private Button flecha;
        private FlowLayoutPanel panel_emojis;
        private Button feliz;
        private Button triste;
        private Button risa;
        private Button enamorado;
        private Button laroca;
        private FlowLayoutPanel broadcast;
        private Button crear_grupo;
        private Label label1;
        private PictureBox pictureBox1;
    }
}