namespace KontGeld
{
    partial class TelaLogin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLogin));
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtLogin = new System.Windows.Forms.TextBox();
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.btnEntrar = new System.Windows.Forms.Button();
			this.lblCad = new System.Windows.Forms.Label();
			this.btnSair = new System.Windows.Forms.Button();
			this.lblNome = new System.Windows.Forms.Label();
			this.lblEmail = new System.Windows.Forms.Label();
			this.lblConf1 = new System.Windows.Forms.Label();
			this.lblSenha1 = new System.Windows.Forms.Label();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtConf1 = new System.Windows.Forms.TextBox();
			this.txtSenha1 = new System.Windows.Forms.TextBox();
			this.btnCad = new System.Windows.Forms.Button();
			this.btnCan1 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblBox = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblBox)).BeginInit();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(218, 214);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Login:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(211, 261);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Senha:";
			// 
			// txtLogin
			// 
			this.txtLogin.BackColor = System.Drawing.Color.White;
			this.txtLogin.Location = new System.Drawing.Point(276, 216);
			this.txtLogin.Name = "txtLogin";
			this.txtLogin.Size = new System.Drawing.Size(131, 20);
			this.txtLogin.TabIndex = 1;
			// 
			// txtSenha
			// 
			this.txtSenha.HideSelection = false;
			this.txtSenha.Location = new System.Drawing.Point(276, 261);
			this.txtSenha.MaxLength = 6;
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.Size = new System.Drawing.Size(131, 20);
			this.txtSenha.TabIndex = 2;
			this.txtSenha.UseSystemPasswordChar = true;
			this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha_KeyPress);
			// 
			// btnEntrar
			// 
			this.btnEntrar.BackColor = System.Drawing.SystemColors.Control;
			this.btnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEntrar.ForeColor = System.Drawing.Color.Black;
			this.btnEntrar.Location = new System.Drawing.Point(230, 317);
			this.btnEntrar.Name = "btnEntrar";
			this.btnEntrar.Size = new System.Drawing.Size(75, 23);
			this.btnEntrar.TabIndex = 3;
			this.btnEntrar.Text = "Entrar";
			this.btnEntrar.UseVisualStyleBackColor = false;
			this.btnEntrar.Click += new System.EventHandler(this.button1_Click);
			// 
			// lblCad
			// 
			this.lblCad.AutoSize = true;
			this.lblCad.BackColor = System.Drawing.Color.Transparent;
			this.lblCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCad.Location = new System.Drawing.Point(529, 517);
			this.lblCad.Name = "lblCad";
			this.lblCad.Size = new System.Drawing.Size(63, 16);
			this.lblCad.TabIndex = 5;
			this.lblCad.Text = "Cadastro";
			this.lblCad.Click += new System.EventHandler(this.label7_Click);
			// 
			// btnSair
			// 
			this.btnSair.BackColor = System.Drawing.SystemColors.Control;
			this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSair.ForeColor = System.Drawing.Color.Black;
			this.btnSair.Location = new System.Drawing.Point(335, 317);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(75, 23);
			this.btnSair.TabIndex = 4;
			this.btnSair.Text = "Sair";
			this.btnSair.UseVisualStyleBackColor = false;
			this.btnSair.Click += new System.EventHandler(this.button2_Click);
			// 
			// lblNome
			// 
			this.lblNome.AutoSize = true;
			this.lblNome.BackColor = System.Drawing.Color.Transparent;
			this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNome.Location = new System.Drawing.Point(107, 401);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(48, 16);
			this.lblNome.TabIndex = 6;
			this.lblNome.Text = "Nome:";
			this.lblNome.Visible = false;
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.BackColor = System.Drawing.Color.Transparent;
			this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEmail.Location = new System.Drawing.Point(110, 440);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(44, 16);
			this.lblEmail.TabIndex = 19;
			this.lblEmail.Text = "Login:";
			this.lblEmail.Visible = false;
			// 
			// lblConf1
			// 
			this.lblConf1.AutoSize = true;
			this.lblConf1.BackColor = System.Drawing.Color.Transparent;
			this.lblConf1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblConf1.Location = new System.Drawing.Point(302, 441);
			this.lblConf1.Name = "lblConf1";
			this.lblConf1.Size = new System.Drawing.Size(108, 16);
			this.lblConf1.TabIndex = 19;
			this.lblConf1.Text = "Confirmar senha:";
			this.lblConf1.Visible = false;
			// 
			// lblSenha1
			// 
			this.lblSenha1.AutoSize = true;
			this.lblSenha1.BackColor = System.Drawing.Color.Transparent;
			this.lblSenha1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSenha1.Location = new System.Drawing.Point(360, 401);
			this.lblSenha1.Name = "lblSenha1";
			this.lblSenha1.Size = new System.Drawing.Size(50, 16);
			this.lblSenha1.TabIndex = 6;
			this.lblSenha1.Text = "Senha:";
			this.lblSenha1.Visible = false;
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(162, 400);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(133, 20);
			this.txtNome.TabIndex = 6;
			this.txtNome.Visible = false;
			// 
			// txtEmail
			// 
			this.txtEmail.HideSelection = false;
			this.txtEmail.Location = new System.Drawing.Point(162, 438);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(133, 20);
			this.txtEmail.TabIndex = 7;
			this.txtEmail.Visible = false;
			// 
			// txtConf1
			// 
			this.txtConf1.HideSelection = false;
			this.txtConf1.Location = new System.Drawing.Point(417, 437);
			this.txtConf1.MaxLength = 6;
			this.txtConf1.Name = "txtConf1";
			this.txtConf1.Size = new System.Drawing.Size(102, 20);
			this.txtConf1.TabIndex = 9;
			this.txtConf1.UseSystemPasswordChar = true;
			this.txtConf1.Visible = false;
			// 
			// txtSenha1
			// 
			this.txtSenha1.HideSelection = false;
			this.txtSenha1.Location = new System.Drawing.Point(419, 399);
			this.txtSenha1.MaxLength = 6;
			this.txtSenha1.Name = "txtSenha1";
			this.txtSenha1.Size = new System.Drawing.Size(101, 20);
			this.txtSenha1.TabIndex = 8;
			this.txtSenha1.UseSystemPasswordChar = true;
			this.txtSenha1.Visible = false;
			// 
			// btnCad
			// 
			this.btnCad.BackColor = System.Drawing.SystemColors.Control;
			this.btnCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCad.ForeColor = System.Drawing.Color.Black;
			this.btnCad.Location = new System.Drawing.Point(343, 475);
			this.btnCad.Name = "btnCad";
			this.btnCad.Size = new System.Drawing.Size(85, 23);
			this.btnCad.TabIndex = 10;
			this.btnCad.Text = "Cadastrar";
			this.btnCad.UseVisualStyleBackColor = false;
			this.btnCad.Visible = false;
			this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
			// 
			// btnCan1
			// 
			this.btnCan1.BackColor = System.Drawing.SystemColors.Control;
			this.btnCan1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCan1.ForeColor = System.Drawing.Color.Black;
			this.btnCan1.Location = new System.Drawing.Point(434, 475);
			this.btnCan1.Name = "btnCan1";
			this.btnCan1.Size = new System.Drawing.Size(85, 23);
			this.btnCan1.TabIndex = 11;
			this.btnCan1.Text = "Cancelar";
			this.btnCan1.UseVisualStyleBackColor = false;
			this.btnCan1.Visible = false;
			this.btnCan1.Click += new System.EventHandler(this.btnCan1_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox1.Location = new System.Drawing.Point(122, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(372, 220);
			this.pictureBox1.TabIndex = 20;
			this.pictureBox1.TabStop = false;
			// 
			// lblBox
			// 
			this.lblBox.BackColor = System.Drawing.Color.Transparent;
			this.lblBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lblBox.BackgroundImage")));
			this.lblBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.lblBox.Location = new System.Drawing.Point(94, 380);
			this.lblBox.Name = "lblBox";
			this.lblBox.Size = new System.Drawing.Size(447, 133);
			this.lblBox.TabIndex = 21;
			this.lblBox.TabStop = false;
			this.lblBox.Visible = false;
			// 
			// TelaLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(626, 543);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.lblCad);
			this.Controls.Add(this.btnEntrar);
			this.Controls.Add(this.txtSenha);
			this.Controls.Add(this.txtLogin);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnCan1);
			this.Controls.Add(this.txtSenha1);
			this.Controls.Add(this.txtConf1);
			this.Controls.Add(this.lblConf1);
			this.Controls.Add(this.lblEmail);
			this.Controls.Add(this.lblSenha1);
			this.Controls.Add(this.lblNome);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.btnCad);
			this.Controls.Add(this.lblBox);
			this.ForeColor = System.Drawing.Color.White;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "TelaLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Dados financeiros";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label lblCad;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblConf1;
        private System.Windows.Forms.Label lblSenha1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtConf1;
        private System.Windows.Forms.TextBox txtSenha1;
        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.Button btnCan1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox lblBox;
	}
}

