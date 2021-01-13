namespace KontGeld
{
	partial class InfoUsu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoUsu));
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.dataEmprego = new System.Windows.Forms.DataGridView();
            this.iDEmpregoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empregoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.financeiroDataSet = new KontGeld.FinanceiroDataSet();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cancelar = new System.Windows.Forms.Button();
            this.ok = new System.Windows.Forms.Button();
            this.txtcs = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.txtns = new System.Windows.Forms.TextBox();
            this.txtatual = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.sm = new System.Windows.Forms.TextBox();
            this.emp = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.empregoTableAdapter = new KontGeld.FinanceiroDataSetTableAdapters.EmpregoTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.alterar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataEmprego)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empregoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeiroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(507, 276);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(36, 22);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 35;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            this.pictureBox6.MouseHover += new System.EventHandler(this.PictureBox6_MouseHover);
            // 
            // dataEmprego
            // 
            this.dataEmprego.AllowUserToAddRows = false;
            this.dataEmprego.AllowUserToDeleteRows = false;
            this.dataEmprego.AutoGenerateColumns = false;
            this.dataEmprego.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataEmprego.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEmprego.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDEmpregoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.salarioDataGridViewTextBoxColumn});
            this.dataEmprego.DataSource = this.empregoBindingSource;
            this.dataEmprego.Location = new System.Drawing.Point(217, 157);
            this.dataEmprego.Name = "dataEmprego";
            this.dataEmprego.ReadOnly = true;
            this.dataEmprego.RowHeadersVisible = false;
            this.dataEmprego.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataEmprego.Size = new System.Drawing.Size(380, 107);
            this.dataEmprego.TabIndex = 33;
            this.dataEmprego.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataEmprego_CellClick);
            // 
            // iDEmpregoDataGridViewTextBoxColumn
            // 
            this.iDEmpregoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDEmpregoDataGridViewTextBoxColumn.DataPropertyName = "ID_Emprego";
            this.iDEmpregoDataGridViewTextBoxColumn.HeaderText = "Cód.";
            this.iDEmpregoDataGridViewTextBoxColumn.Name = "iDEmpregoDataGridViewTextBoxColumn";
            this.iDEmpregoDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDEmpregoDataGridViewTextBoxColumn.Width = 54;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salarioDataGridViewTextBoxColumn
            // 
            this.salarioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.salarioDataGridViewTextBoxColumn.DataPropertyName = "Salario";
            this.salarioDataGridViewTextBoxColumn.HeaderText = "Salário";
            this.salarioDataGridViewTextBoxColumn.Name = "salarioDataGridViewTextBoxColumn";
            this.salarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.salarioDataGridViewTextBoxColumn.Width = 64;
            // 
            // empregoBindingSource
            // 
            this.empregoBindingSource.DataMember = "Emprego";
            this.empregoBindingSource.DataSource = this.financeiroDataSet;
            // 
            // financeiroDataSet
            // 
            this.financeiroDataSet.DataSetName = "FinanceiroDataSet";
            this.financeiroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(561, 75);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(36, 22);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 29;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click_1);
            this.pictureBox4.MouseHover += new System.EventHandler(this.PictureBox4_MouseHover);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.cancelar);
            this.groupBox3.Controls.Add(this.ok);
            this.groupBox3.Controls.Add(this.txtcs);
            this.groupBox3.Controls.Add(this.label39);
            this.groupBox3.Controls.Add(this.txtns);
            this.groupBox3.Controls.Add(this.txtatual);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(173, 358);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(515, 202);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Troca de senha";
            // 
            // cancelar
            // 
            this.cancelar.BackColor = System.Drawing.Color.Transparent;
            this.cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelar.Enabled = false;
            this.cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar.ForeColor = System.Drawing.Color.Black;
            this.cancelar.Image = ((System.Drawing.Image)(resources.GetObject("cancelar.Image")));
            this.cancelar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.cancelar.Location = new System.Drawing.Point(164, 157);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(159, 29);
            this.cancelar.TabIndex = 25;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = false;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // ok
            // 
            this.ok.BackColor = System.Drawing.Color.Transparent;
            this.ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ok.Enabled = false;
            this.ok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok.ForeColor = System.Drawing.Color.Black;
            this.ok.Image = ((System.Drawing.Image)(resources.GetObject("ok.Image")));
            this.ok.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ok.Location = new System.Drawing.Point(329, 157);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(159, 29);
            this.ok.TabIndex = 3;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = false;
            this.ok.Click += new System.EventHandler(this.button9_Click);
            // 
            // txtcs
            // 
            this.txtcs.Enabled = false;
            this.txtcs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcs.Location = new System.Drawing.Point(133, 120);
            this.txtcs.Name = "txtcs";
            this.txtcs.Size = new System.Drawing.Size(231, 21);
            this.txtcs.TabIndex = 2;
            this.txtcs.UseSystemPasswordChar = true;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(22, 123);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(108, 16);
            this.label39.TabIndex = 24;
            this.label39.Text = "Confirmar senha:";
            // 
            // txtns
            // 
            this.txtns.Enabled = false;
            this.txtns.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtns.Location = new System.Drawing.Point(133, 78);
            this.txtns.Name = "txtns";
            this.txtns.Size = new System.Drawing.Size(231, 21);
            this.txtns.TabIndex = 1;
            this.txtns.UseSystemPasswordChar = true;
            // 
            // txtatual
            // 
            this.txtatual.Enabled = false;
            this.txtatual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtatual.Location = new System.Drawing.Point(133, 37);
            this.txtatual.Name = "txtatual";
            this.txtatual.Size = new System.Drawing.Size(231, 21);
            this.txtatual.TabIndex = 0;
            this.txtatual.UseSystemPasswordChar = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(46, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Nova senha:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(48, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 16);
            this.label10.TabIndex = 14;
            this.label10.Text = "Senha atual:";
            // 
            // sm
            // 
            this.sm.Location = new System.Drawing.Point(318, 76);
            this.sm.Name = "sm";
            this.sm.Size = new System.Drawing.Size(231, 20);
            this.sm.TabIndex = 1;
            // 
            // emp
            // 
            this.emp.Location = new System.Drawing.Point(318, 36);
            this.emp.Name = "emp";
            this.emp.Size = new System.Drawing.Size(231, 20);
            this.emp.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(214, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 16);
            this.label11.TabIndex = 28;
            this.label11.Text = "Salário Mensal:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(248, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 16);
            this.label12.TabIndex = 27;
            this.label12.Text = "Emprego:";
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox15.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox15.Image")));
            this.pictureBox15.Location = new System.Drawing.Point(550, 276);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(36, 22);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox15.TabIndex = 57;
            this.pictureBox15.TabStop = false;
            this.pictureBox15.VisibleChanged += new System.EventHandler(this.pictureBox15_VisibleChanged);
            this.pictureBox15.Click += new System.EventHandler(this.pictureBox15_Click_1);
            // 
            // empregoTableAdapter
            // 
            this.empregoTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(562, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 58;
            this.label1.Text = "Alterar senha";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.BackColor = System.Drawing.Color.Transparent;
            this.lblid.Location = new System.Drawing.Point(235, 285);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(67, 13);
            this.lblid.TabIndex = 59;
            this.lblid.Text = "__________";
            this.lblid.Visible = false;
            // 
            // button1
            // 
            this.button1.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button1.Location = new System.Drawing.Point(429, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 29);
            this.button1.TabIndex = 70;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            // 
            // alterar
            // 
            this.alterar.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.alterar.BackColor = System.Drawing.Color.Transparent;
            this.alterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.alterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alterar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alterar.ForeColor = System.Drawing.Color.Black;
            this.alterar.Image = ((System.Drawing.Image)(resources.GetObject("alterar.Image")));
            this.alterar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.alterar.Location = new System.Drawing.Point(227, 122);
            this.alterar.Name = "alterar";
            this.alterar.Size = new System.Drawing.Size(159, 29);
            this.alterar.TabIndex = 69;
            this.alterar.Text = "Alterar emprego";
            this.alterar.UseVisualStyleBackColor = false;
            this.alterar.Visible = false;
            this.alterar.Click += new System.EventHandler(this.alterar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(217, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 18);
            this.label3.TabIndex = 71;
            this.label3.Text = " ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(180, 563);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 18);
            this.label4.TabIndex = 72;
            this.label4.Text = " ";
            // 
            // InfoUsu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(852, 602);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.alterar);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox15);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.dataEmprego);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.sm);
            this.Controls.Add(this.emp);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(470, 150);
            this.Name = "InfoUsu";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Deactivate += new System.EventHandler(this.InfoUsu_Deactivate);
            this.Load += new System.EventHandler(this.InfoUsu_Load);
            this.VisibleChanged += new System.EventHandler(this.InfoUsu_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataEmprego)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empregoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeiroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.DataGridView dataEmprego;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button ok;
		private System.Windows.Forms.TextBox txtcs;
		private System.Windows.Forms.Label label39;
		private System.Windows.Forms.TextBox txtns;
		private System.Windows.Forms.TextBox txtatual;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox sm;
		private System.Windows.Forms.TextBox emp;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox15;
		private FinanceiroDataSet financeiroDataSet;
		private System.Windows.Forms.BindingSource empregoBindingSource;
		private FinanceiroDataSetTableAdapters.EmpregoTableAdapter empregoTableAdapter;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button cancelar;
		private System.Windows.Forms.DataGridViewTextBoxColumn iDEmpregoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn salarioDataGridViewTextBoxColumn;
		private System.Windows.Forms.Label lblid;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button alterar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}