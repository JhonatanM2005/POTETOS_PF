namespace POTETOS
{
    partial class frm_login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.b_login = new System.Windows.Forms.Button();
            this.lbl_help = new System.Windows.Forms.Label();
            this.lbl_exit = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_messageone = new System.Windows.Forms.Label();
            this.lbl_messagetwo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(136)))), ((int)(((byte)(37)))));
            this.panel1.Location = new System.Drawing.Point(36, 228);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 1);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(136)))), ((int)(((byte)(37)))));
            this.panel2.Location = new System.Drawing.Point(36, 294);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 1);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cheese Burger", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(136)))), ((int)(((byte)(37)))));
            this.label1.Location = new System.Drawing.Point(85, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "¡BIENVENIDO!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // b_login
            // 
            this.b_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(186)))), ((int)(((byte)(82)))));
            this.b_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.b_login.FlatAppearance.BorderSize = 0;
            this.b_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_login.Font = new System.Drawing.Font("Cheese Burger", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(1)))), ((int)(((byte)(51)))));
            this.b_login.Location = new System.Drawing.Point(96, 340);
            this.b_login.Name = "b_login";
            this.b_login.Size = new System.Drawing.Size(104, 32);
            this.b_login.TabIndex = 6;
            this.b_login.Text = "INGRESAR";
            this.b_login.UseVisualStyleBackColor = false;
            this.b_login.Click += new System.EventHandler(this.b_login_Click);
            // 
            // lbl_help
            // 
            this.lbl_help.AutoSize = true;
            this.lbl_help.Font = new System.Drawing.Font("Cheese Burger", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_help.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(136)))), ((int)(((byte)(37)))));
            this.lbl_help.Location = new System.Drawing.Point(170, 309);
            this.lbl_help.Name = "lbl_help";
            this.lbl_help.Size = new System.Drawing.Size(102, 18);
            this.lbl_help.TabIndex = 7;
            this.lbl_help.Text = "¿Necesitas ayuda?";
            this.lbl_help.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_exit
            // 
            this.lbl_exit.AutoSize = true;
            this.lbl_exit.Font = new System.Drawing.Font("Cheese Burger", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(136)))), ((int)(((byte)(37)))));
            this.lbl_exit.Location = new System.Drawing.Point(129, 382);
            this.lbl_exit.Name = "lbl_exit";
            this.lbl_exit.Size = new System.Drawing.Size(37, 22);
            this.lbl_exit.TabIndex = 8;
            this.lbl_exit.Text = "Salir";
            this.lbl_exit.Click += new System.EventHandler(this.label3_Click);
            // 
            // tb_username
            // 
            this.tb_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(1)))), ((int)(((byte)(51)))));
            this.tb_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_username.Font = new System.Drawing.Font("Cheese Burger", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.ForeColor = System.Drawing.Color.White;
            this.tb_username.Location = new System.Drawing.Point(63, 206);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(209, 16);
            this.tb_username.TabIndex = 9;
            // 
            // tb_password
            // 
            this.tb_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(1)))), ((int)(((byte)(51)))));
            this.tb_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_password.Font = new System.Drawing.Font("Cheese Burger", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.ForeColor = System.Drawing.Color.White;
            this.tb_password.Location = new System.Drawing.Point(63, 272);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(209, 16);
            this.tb_password.TabIndex = 10;
            this.tb_password.UseSystemPasswordChar = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::POTETOS.Properties.Resources.lock__1_;
            this.pictureBox3.Location = new System.Drawing.Point(36, 268);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(21, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::POTETOS.Properties.Resources.user__1_;
            this.pictureBox2.Location = new System.Drawing.Point(36, 203);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 19);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::POTETOS.Properties.Resources.POTETOS_Mesa_de_trabajo_1;
            this.pictureBox1.Location = new System.Drawing.Point(55, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_messageone
            // 
            this.lbl_messageone.AutoSize = true;
            this.lbl_messageone.Font = new System.Drawing.Font("Cheese Burger", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_messageone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(186)))), ((int)(((byte)(82)))));
            this.lbl_messageone.Location = new System.Drawing.Point(73, 169);
            this.lbl_messageone.Name = "lbl_messageone";
            this.lbl_messageone.Size = new System.Drawing.Size(0, 15);
            this.lbl_messageone.TabIndex = 11;
            this.lbl_messageone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_messagetwo
            // 
            this.lbl_messagetwo.AutoSize = true;
            this.lbl_messagetwo.Font = new System.Drawing.Font("Cheese Burger", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_messagetwo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(186)))), ((int)(((byte)(82)))));
            this.lbl_messagetwo.Location = new System.Drawing.Point(106, 184);
            this.lbl_messagetwo.Name = "lbl_messagetwo";
            this.lbl_messagetwo.Size = new System.Drawing.Size(0, 15);
            this.lbl_messagetwo.TabIndex = 12;
            this.lbl_messagetwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_messagetwo.Click += new System.EventHandler(this.lbl_messagetwo_Click);
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(1)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(304, 418);
            this.Controls.Add(this.lbl_messagetwo);
            this.Controls.Add(this.lbl_messageone);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.lbl_exit);
            this.Controls.Add(this.lbl_help);
            this.Controls.Add(this.b_login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Cheese Burger", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_login;
        private System.Windows.Forms.Label lbl_help;
        private System.Windows.Forms.Label lbl_exit;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label lbl_messageone;
        private System.Windows.Forms.Label lbl_messagetwo;
    }
}

