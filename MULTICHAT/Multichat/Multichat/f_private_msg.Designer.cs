namespace Multichat
{
    partial class f_private_msg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_private_msg));
            p_user = new Label();
            p_txtMessage = new TextBox();
            p_send = new Button();
            flecha = new Button();
            panel_emojis = new FlowLayoutPanel();
            feliz = new Button();
            triste = new Button();
            risa = new Button();
            enamorado = new Button();
            laroca = new Button();
            p_broadcast = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            panel_emojis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // p_user
            // 
            p_user.AutoSize = true;
            p_user.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            p_user.ForeColor = Color.White;
            p_user.Location = new Point(76, 9);
            p_user.Name = "p_user";
            p_user.Size = new Size(108, 38);
            p_user.TabIndex = 0;
            p_user.Text = "usuario";
            // 
            // p_txtMessage
            // 
            p_txtMessage.BackColor = Color.FromArgb(45, 45, 45);
            p_txtMessage.BorderStyle = BorderStyle.None;
            p_txtMessage.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            p_txtMessage.ForeColor = Color.White;
            p_txtMessage.Location = new Point(59, 427);
            p_txtMessage.Margin = new Padding(3, 4, 3, 4);
            p_txtMessage.Name = "p_txtMessage";
            p_txtMessage.Size = new Size(300, 30);
            p_txtMessage.TabIndex = 2;
            // 
            // p_send
            // 
            p_send.BackColor = Color.FromArgb(45, 45, 45);
            p_send.FlatStyle = FlatStyle.System;
            p_send.Location = new Point(366, 424);
            p_send.Margin = new Padding(3, 4, 3, 4);
            p_send.Name = "p_send";
            p_send.Size = new Size(83, 38);
            p_send.TabIndex = 3;
            p_send.Text = "send";
            p_send.UseVisualStyleBackColor = false;
            p_send.Click += p_send_Click;
            // 
            // flecha
            // 
            flecha.BackColor = Color.FromArgb(45, 45, 45);
            flecha.BackgroundImage = (Image)resources.GetObject("flecha.BackgroundImage");
            flecha.BackgroundImageLayout = ImageLayout.Stretch;
            flecha.FlatStyle = FlatStyle.Popup;
            flecha.ForeColor = Color.Transparent;
            flecha.Location = new Point(22, 427);
            flecha.Margin = new Padding(3, 4, 3, 4);
            flecha.Name = "flecha";
            flecha.Size = new Size(31, 30);
            flecha.TabIndex = 18;
            flecha.UseVisualStyleBackColor = false;
            flecha.Click += flecha_Click_1;
            // 
            // panel_emojis
            // 
            panel_emojis.Controls.Add(feliz);
            panel_emojis.Controls.Add(triste);
            panel_emojis.Controls.Add(risa);
            panel_emojis.Controls.Add(enamorado);
            panel_emojis.Controls.Add(laroca);
            panel_emojis.Location = new Point(19, 362);
            panel_emojis.Margin = new Padding(3, 4, 3, 4);
            panel_emojis.Name = "panel_emojis";
            panel_emojis.Size = new Size(285, 47);
            panel_emojis.TabIndex = 17;
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
            // p_broadcast
            // 
            p_broadcast.BackgroundImage = (Image)resources.GetObject("p_broadcast.BackgroundImage");
            p_broadcast.BackgroundImageLayout = ImageLayout.Stretch;
            p_broadcast.Location = new Point(-2, 50);
            p_broadcast.Name = "p_broadcast";
            p_broadcast.Size = new Size(480, 428);
            p_broadcast.TabIndex = 19;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(58, 38);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // f_private_msg
            // 
            AutoScaleDimensions = new SizeF(9F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(474, 475);
            Controls.Add(pictureBox1);
            Controls.Add(flecha);
            Controls.Add(panel_emojis);
            Controls.Add(p_send);
            Controls.Add(p_txtMessage);
            Controls.Add(p_user);
            Controls.Add(p_broadcast);
            Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "f_private_msg";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Message";
            panel_emojis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label p_user;
        private TextBox p_txtMessage;
        private Button p_send;
        private Button flecha;
        private FlowLayoutPanel panel_emojis;
        private Button feliz;
        private Button triste;
        private Button risa;
        private Button enamorado;
        private Button laroca;
        private FlowLayoutPanel p_broadcast;
        private PictureBox pictureBox1;
    }
}