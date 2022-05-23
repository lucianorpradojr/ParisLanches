namespace Paris_Lanches
{
    partial class frm_login
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
            this.imglogin = new System.Windows.Forms.PictureBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.btn_cadusuario = new MetroFramework.Controls.MetroTile();
            this.btn_login = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.imglogin)).BeginInit();
            this.SuspendLayout();
            // 
            // imglogin
            // 
            this.imglogin.Image = global::Paris_Lanches.Properties.Resources.loginimg1;
            this.imglogin.Location = new System.Drawing.Point(12, 91);
            this.imglogin.Name = "imglogin";
            this.imglogin.Size = new System.Drawing.Size(353, 292);
            this.imglogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imglogin.TabIndex = 0;
            this.imglogin.TabStop = false;
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(566, 153);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.PlaceholderText = "joaozinho";
            this.txt_usuario.Size = new System.Drawing.Size(182, 23);
            this.txt_usuario.TabIndex = 1;
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_usuario.Location = new System.Drawing.Point(399, 151);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(161, 25);
            this.lbl_usuario.TabIndex = 3;
            this.lbl_usuario.Text = "Nome de usuário:";
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_senha.Location = new System.Drawing.Point(453, 195);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(68, 25);
            this.lbl_senha.TabIndex = 4;
            this.lbl_senha.Text = "Senha:";
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(566, 197);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.PlaceholderText = "*********";
            this.txt_senha.Size = new System.Drawing.Size(182, 23);
            this.txt_senha.TabIndex = 5;
            // 
            // btn_cadusuario
            // 
            this.btn_cadusuario.ActiveControl = null;
            this.btn_cadusuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cadusuario.Location = new System.Drawing.Point(639, 312);
            this.btn_cadusuario.Name = "btn_cadusuario";
            this.btn_cadusuario.Size = new System.Drawing.Size(109, 56);
            this.btn_cadusuario.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_cadusuario.TabIndex = 7;
            this.btn_cadusuario.Text = "Cadastrar";
            this.btn_cadusuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cadusuario.UseSelectable = true;
            this.btn_cadusuario.Click += new System.EventHandler(this.btn_cadusuario_Click);
            // 
            // btn_login
            // 
            this.btn_login.ActiveControl = null;
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.Location = new System.Drawing.Point(472, 312);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(109, 56);
            this.btn_login.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_login.TabIndex = 8;
            this.btn_login.Text = "Logar";
            this.btn_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_login.UseSelectable = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.btn_cadusuario);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.imglogin);
            this.MaximizeBox = false;
            this.Name = "frm_login";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Paris Lanches";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imglogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox imglogin;
        private TextBox txt_usuario;
        private Label lbl_usuario;
        private Label lbl_senha;
        private TextBox txt_senha;
        private MetroFramework.Controls.MetroTile btn_login;
        private MetroFramework.Controls.MetroTile btn_cadusuario;
    }
}