namespace Multichat
{
    partial class Crear_grupo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Crear_grupo));
            group_users = new CheckedListBox();
            label1 = new Label();
            txt_groupname = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btn_create = new Button();
            SuspendLayout();
            // 
            // group_users
            // 
            group_users.BackColor = Color.FromArgb(40, 40, 40);
            group_users.BorderStyle = BorderStyle.None;
            group_users.ForeColor = Color.White;
            group_users.FormattingEnabled = true;
            group_users.Location = new Point(14, 146);
            group_users.Margin = new Padding(3, 4, 3, 4);
            group_users.Name = "group_users";
            group_users.Size = new Size(277, 125);
            group_users.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(14, 58);
            label1.Name = "label1";
            label1.Size = new Size(133, 30);
            label1.TabIndex = 1;
            label1.Text = "Group's name";
            // 
            // txt_groupname
            // 
            txt_groupname.BackColor = Color.FromArgb(40, 40, 40);
            txt_groupname.BorderStyle = BorderStyle.None;
            txt_groupname.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_groupname.ForeColor = Color.White;
            txt_groupname.Location = new Point(14, 87);
            txt_groupname.Name = "txt_groupname";
            txt_groupname.Size = new Size(277, 25);
            txt_groupname.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(89, 9);
            label2.Name = "label2";
            label2.Size = new Size(138, 39);
            label2.TabIndex = 3;
            label2.Text = "New Group";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(14, 116);
            label3.Name = "label3";
            label3.Size = new Size(59, 30);
            label3.TabIndex = 4;
            label3.Text = "Users";
            // 
            // btn_create
            // 
            btn_create.FlatStyle = FlatStyle.System;
            btn_create.ForeColor = Color.White;
            btn_create.Location = new Point(102, 278);
            btn_create.Name = "btn_create";
            btn_create.Size = new Size(94, 29);
            btn_create.TabIndex = 5;
            btn_create.Text = "create";
            btn_create.UseVisualStyleBackColor = true;
            btn_create.Click += btn_create_Click;
            // 
            // Crear_grupo
            // 
            AutoScaleDimensions = new SizeF(9F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(303, 321);
            Controls.Add(btn_create);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_groupname);
            Controls.Add(label1);
            Controls.Add(group_users);
            Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Crear_grupo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New Group ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public CheckedListBox group_users;
        public Label label1;
        public TextBox txt_groupname;
        public Label label2;
        public Label label3;
        public Button btn_create;
    }
}