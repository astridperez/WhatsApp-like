namespace Multichat
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtName = new TextBox();
            label1 = new Label();
            imagen = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(45, 45, 45);
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Poppins", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.ForeColor = Color.White;
            txtName.Location = new Point(32, 72);
            txtName.Name = "txtName";
            txtName.Size = new Size(174, 41);
            txtName.TabIndex = 1;
            txtName.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(54, 9);
            label1.Name = "label1";
            label1.Size = new Size(197, 60);
            label1.TabIndex = 2;
            label1.Text = "Nickname";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // imagen
            // 
            imagen.BackgroundImage = (Image)resources.GetObject("imagen.BackgroundImage");
            imagen.BackgroundImageLayout = ImageLayout.Zoom;
            imagen.FlatStyle = FlatStyle.Flat;
            imagen.Font = new Font("Poppins", 15F, FontStyle.Regular, GraphicsUnit.Point);
            imagen.ForeColor = Color.FromArgb(30, 30, 30);
            imagen.Location = new Point(212, 72);
            imagen.Name = "imagen";
            imagen.Size = new Size(51, 41);
            imagen.TabIndex = 23;
            imagen.TextAlign = ContentAlignment.TopCenter;
            imagen.UseVisualStyleBackColor = true;
            imagen.Click += imagen_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(289, 148);
            Controls.Add(imagen);
            Controls.Add(label1);
            Controls.Add(txtName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button b_inicio;
        private TextBox txtName;
        private Label label1;
        private Label l_no;
        private Button imagen;
    }
}