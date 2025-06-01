namespace POTETOS.Properties
{
    partial class frm_admin
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_admin));
            this.dgv_users = new System.Windows.Forms.DataGridView();
            this.tb_ident = new System.Windows.Forms.TextBox();
            this.tb_fullname = new System.Windows.Forms.TextBox();
            this.cb_userType = new System.Windows.Forms.ComboBox();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.lbl_ident = new System.Windows.Forms.Label();
            this.lbl_fullname = new System.Windows.Forms.Label();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_userType = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.b_save = new System.Windows.Forms.Button();
            this.b_delete = new System.Windows.Forms.Button();
            this.b_search = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.pb_profile = new System.Windows.Forms.PictureBox();
            this.lbl_exit = new System.Windows.Forms.Label();
            this.lbl_message = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_profile)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_users
            // 
            this.dgv_users.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_users.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_users.Location = new System.Drawing.Point(49, 280);
            this.dgv_users.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_users.Name = "dgv_users";
            this.dgv_users.ReadOnly = true;
            this.dgv_users.Size = new System.Drawing.Size(547, 208);
            this.dgv_users.TabIndex = 0;
            // 
            // tb_ident
            // 
            this.tb_ident.Location = new System.Drawing.Point(48, 138);
            this.tb_ident.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_ident.Name = "tb_ident";
            this.tb_ident.Size = new System.Drawing.Size(118, 22);
            this.tb_ident.TabIndex = 1;
            // 
            // tb_fullname
            // 
            this.tb_fullname.Location = new System.Drawing.Point(202, 138);
            this.tb_fullname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_fullname.Name = "tb_fullname";
            this.tb_fullname.Size = new System.Drawing.Size(252, 22);
            this.tb_fullname.TabIndex = 2;
            // 
            // cb_userType
            // 
            this.cb_userType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_userType.FormattingEnabled = true;
            this.cb_userType.Items.AddRange(new object[] {
            "Administrador",
            "Chef",
            "Mesero",
            "Cajero",
            "Repartidor"});
            this.cb_userType.Location = new System.Drawing.Point(261, 200);
            this.cb_userType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_userType.Name = "cb_userType";
            this.cb_userType.Size = new System.Drawing.Size(121, 24);
            this.cb_userType.TabIndex = 3;
            // 
            // tb_phone
            // 
            this.tb_phone.Location = new System.Drawing.Point(483, 138);
            this.tb_phone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(108, 22);
            this.tb_phone.TabIndex = 4;
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(114, 200);
            this.tb_username.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(100, 22);
            this.tb_username.TabIndex = 5;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(423, 203);
            this.tb_password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(100, 22);
            this.tb_password.TabIndex = 6;
            // 
            // lbl_ident
            // 
            this.lbl_ident.AutoSize = true;
            this.lbl_ident.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ident.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(136)))), ((int)(((byte)(37)))));
            this.lbl_ident.Location = new System.Drawing.Point(45, 116);
            this.lbl_ident.Name = "lbl_ident";
            this.lbl_ident.Size = new System.Drawing.Size(88, 16);
            this.lbl_ident.TabIndex = 7;
            this.lbl_ident.Text = "Identificación:";
            // 
            // lbl_fullname
            // 
            this.lbl_fullname.AutoSize = true;
            this.lbl_fullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fullname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(136)))), ((int)(((byte)(37)))));
            this.lbl_fullname.Location = new System.Drawing.Point(199, 116);
            this.lbl_fullname.Name = "lbl_fullname";
            this.lbl_fullname.Size = new System.Drawing.Size(118, 16);
            this.lbl_fullname.TabIndex = 8;
            this.lbl_fullname.Text = "Nombre completo:";
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(136)))), ((int)(((byte)(37)))));
            this.lbl_phone.Location = new System.Drawing.Point(480, 116);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(64, 16);
            this.lbl_phone.TabIndex = 9;
            this.lbl_phone.Text = "Teléfono:";
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(136)))), ((int)(((byte)(37)))));
            this.lbl_user.Location = new System.Drawing.Point(111, 178);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(57, 16);
            this.lbl_user.TabIndex = 10;
            this.lbl_user.Text = "Usuario:";
            // 
            // lbl_userType
            // 
            this.lbl_userType.AutoSize = true;
            this.lbl_userType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(136)))), ((int)(((byte)(37)))));
            this.lbl_userType.Location = new System.Drawing.Point(258, 181);
            this.lbl_userType.Name = "lbl_userType";
            this.lbl_userType.Size = new System.Drawing.Size(104, 16);
            this.lbl_userType.TabIndex = 11;
            this.lbl_userType.Text = "Tipo de usuario:";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(136)))), ((int)(((byte)(37)))));
            this.lbl_password.Location = new System.Drawing.Point(420, 181);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(79, 16);
            this.lbl_password.TabIndex = 12;
            this.lbl_password.Text = "Contraseña:";
            // 
            // b_save
            // 
            this.b_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(186)))), ((int)(((byte)(82)))));
            this.b_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(1)))), ((int)(((byte)(51)))));
            this.b_save.Location = new System.Drawing.Point(149, 511);
            this.b_save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.b_save.Name = "b_save";
            this.b_save.Size = new System.Drawing.Size(75, 32);
            this.b_save.TabIndex = 13;
            this.b_save.Text = "Guardar";
            this.b_save.UseVisualStyleBackColor = false;
            this.b_save.Click += new System.EventHandler(this.b_save_Click);
            // 
            // b_delete
            // 
            this.b_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(186)))), ((int)(((byte)(82)))));
            this.b_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(1)))), ((int)(((byte)(51)))));
            this.b_delete.Location = new System.Drawing.Point(415, 511);
            this.b_delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.b_delete.Name = "b_delete";
            this.b_delete.Size = new System.Drawing.Size(75, 32);
            this.b_delete.TabIndex = 14;
            this.b_delete.Text = "Borrar";
            this.b_delete.UseVisualStyleBackColor = false;
            this.b_delete.Click += new System.EventHandler(this.b_delete_Click);
            // 
            // b_search
            // 
            this.b_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(186)))), ((int)(((byte)(82)))));
            this.b_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(1)))), ((int)(((byte)(51)))));
            this.b_search.Location = new System.Drawing.Point(282, 511);
            this.b_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.b_search.Name = "b_search";
            this.b_search.Size = new System.Drawing.Size(75, 32);
            this.b_search.TabIndex = 15;
            this.b_search.Text = "Buscar";
            this.b_search.UseVisualStyleBackColor = false;
            this.b_search.Click += new System.EventHandler(this.b_search_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(186)))), ((int)(((byte)(82)))));
            this.lbl_title.Location = new System.Drawing.Point(178, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(388, 37);
            this.lbl_title.TabIndex = 16;
            this.lbl_title.Text = "GESTIÓN DE USUARIOS";
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(136)))), ((int)(((byte)(37)))));
            this.lbl_welcome.Location = new System.Drawing.Point(57, 49);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(70, 26);
            this.lbl_welcome.TabIndex = 17;
            this.lbl_welcome.Text = "Bienvenido\r\nAdministrador";
            // 
            // pb_profile
            // 
            this.pb_profile.Image = global::POTETOS.Properties.Resources.user__1_;
            this.pb_profile.Location = new System.Drawing.Point(24, 47);
            this.pb_profile.Name = "pb_profile";
            this.pb_profile.Size = new System.Drawing.Size(31, 31);
            this.pb_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_profile.TabIndex = 18;
            this.pb_profile.TabStop = false;
            // 
            // lbl_exit
            // 
            this.lbl_exit.AutoSize = true;
            this.lbl_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(136)))), ((int)(((byte)(37)))));
            this.lbl_exit.Location = new System.Drawing.Point(536, 54);
            this.lbl_exit.Name = "lbl_exit";
            this.lbl_exit.Size = new System.Drawing.Size(89, 16);
            this.lbl_exit.TabIndex = 19;
            this.lbl_exit.Text = "Cerrar Sesión";
            this.lbl_exit.Click += new System.EventHandler(this.lbl_exit_Click);
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_message.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(186)))), ((int)(((byte)(82)))));
            this.lbl_message.Location = new System.Drawing.Point(148, 244);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(0, 20);
            this.lbl_message.TabIndex = 20;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 36;
            this.bunifuElipse1.TargetControl = this;
            // 
            // frm_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(1)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(641, 561);
            this.Controls.Add(this.lbl_message);
            this.Controls.Add(this.lbl_exit);
            this.Controls.Add(this.pb_profile);
            this.Controls.Add(this.lbl_welcome);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.b_search);
            this.Controls.Add(this.b_delete);
            this.Controls.Add(this.b_save);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_userType);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.lbl_phone);
            this.Controls.Add(this.lbl_fullname);
            this.Controls.Add(this.lbl_ident);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.tb_phone);
            this.Controls.Add(this.cb_userType);
            this.Controls.Add(this.tb_fullname);
            this.Controls.Add(this.tb_ident);
            this.Controls.Add(this.dgv_users);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(136)))), ((int)(((byte)(37)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_admin";
            this.Load += new System.EventHandler(this.frm_admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_profile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_users;
        private System.Windows.Forms.TextBox tb_ident;
        private System.Windows.Forms.TextBox tb_fullname;
        private System.Windows.Forms.ComboBox cb_userType;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label lbl_ident;
        private System.Windows.Forms.Label lbl_fullname;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label lbl_userType;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Button b_save;
        private System.Windows.Forms.Button b_delete;
        private System.Windows.Forms.Button b_search;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.PictureBox pb_profile;
        private System.Windows.Forms.Label lbl_exit;
        private System.Windows.Forms.Label lbl_message;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}