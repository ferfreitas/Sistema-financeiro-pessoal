namespace KontGeld
{
	partial class Transações
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transações));
            this.add = new System.Windows.Forms.Button();
            this.txtn_parcelas = new System.Windows.Forms.TextBox();
            this.label56 = new System.Windows.Forms.Label();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.cbForma = new System.Windows.Forms.ComboBox();
            this.consultar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Forma_pagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.contasBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.financeiroDataSet1 = new KontGeld.FinanceiroDataSet();
            this.contasBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.contasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.financeiroDataSet = new KontGeld.FinanceiroDataSet();
            this.contasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtconta = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.lblid = new System.Windows.Forms.Label();
            this.contasTableAdapter = new KontGeld.FinanceiroDataSetTableAdapters.ContasTableAdapter();
            this.alterar = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeiroDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeiroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.add.BackColor = System.Drawing.Color.Transparent;
            this.add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.Color.Black;
            this.add.Image = ((System.Drawing.Image)(resources.GetObject("add.Image")));
            this.add.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.add.Location = new System.Drawing.Point(412, 242);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(159, 29);
            this.add.TabIndex = 5;
            this.add.Text = "Adicionar transação";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtn_parcelas
            // 
            this.txtn_parcelas.Location = new System.Drawing.Point(610, 108);
            this.txtn_parcelas.Name = "txtn_parcelas";
            this.txtn_parcelas.Size = new System.Drawing.Size(100, 20);
            this.txtn_parcelas.TabIndex = 3;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.BackColor = System.Drawing.Color.Transparent;
            this.label56.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.Location = new System.Drawing.Point(496, 110);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(108, 18);
            this.label56.TabIndex = 56;
            this.label56.Text = "Nº de parcelas:";
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox15.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox15.Image")));
            this.pictureBox15.Location = new System.Drawing.Point(714, 533);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(36, 22);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox15.TabIndex = 55;
            this.pictureBox15.TabStop = false;
            this.pictureBox15.Click += new System.EventHandler(this.pictureBox15_Click);
            this.pictureBox15.MouseHover += new System.EventHandler(this.pictureBox15_MouseHover);
            // 
            // pictureBox18
            // 
            this.pictureBox18.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox18.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox18.Image")));
            this.pictureBox18.Location = new System.Drawing.Point(672, 533);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(36, 22);
            this.pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox18.TabIndex = 54;
            this.pictureBox18.TabStop = false;
            this.pictureBox18.Click += new System.EventHandler(this.pictureBox18_Click);
            this.pictureBox18.MouseHover += new System.EventHandler(this.pictureBox18_MouseHover);
            // 
            // cbForma
            // 
            this.cbForma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbForma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbForma.FormattingEnabled = true;
            this.cbForma.Items.AddRange(new object[] {
            "Conta Corrente",
            "Cartão de Crédito",
            "Carteira",
            "Poupança"});
            this.cbForma.Location = new System.Drawing.Point(309, 159);
            this.cbForma.Name = "cbForma";
            this.cbForma.Size = new System.Drawing.Size(167, 21);
            this.cbForma.TabIndex = 4;
            // 
            // consultar
            // 
            this.consultar.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.consultar.BackColor = System.Drawing.Color.Transparent;
            this.consultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.consultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.consultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultar.ForeColor = System.Drawing.Color.Black;
            this.consultar.Image = ((System.Drawing.Image)(resources.GetObject("consultar.Image")));
            this.consultar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.consultar.Location = new System.Drawing.Point(577, 242);
            this.consultar.Name = "consultar";
            this.consultar.Size = new System.Drawing.Size(159, 29);
            this.consultar.TabIndex = 6;
            this.consultar.Text = "Consultar transação";
            this.consultar.UseVisualStyleBackColor = false;
            this.consultar.Click += new System.EventHandler(this.consultar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Forma_pagamento,
            this.Tipo,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewCheckBoxColumn1});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.DataSource = this.contasBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(154, 298);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(596, 215);
            this.dataGridView1.TabIndex = 50;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Contas";
            this.dataGridViewTextBoxColumn1.HeaderText = "Cód.";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Width = 54;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Valor";
            this.dataGridViewTextBoxColumn3.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn3.Width = 56;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Parcelas";
            this.dataGridViewTextBoxColumn4.HeaderText = "Parcelas";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn4.Width = 73;
            // 
            // Forma_pagamento
            // 
            this.Forma_pagamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Forma_pagamento.DataPropertyName = "Forma_pagamentp";
            this.Forma_pagamento.HeaderText = "Forma de pagamento";
            this.Forma_pagamento.Name = "Forma_pagamento";
            this.Forma_pagamento.ReadOnly = true;
            this.Forma_pagamento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Forma_pagamento.Width = 121;
            // 
            // Tipo
            // 
            this.Tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Tipo.DataPropertyName = "ID_Tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Tipo.Width = 53;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Vencimento";
            this.dataGridViewTextBoxColumn6.HeaderText = "Vencimento";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn6.Width = 88;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Situacao";
            this.dataGridViewCheckBoxColumn1.FalseValue = "0";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Situacao";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCheckBoxColumn1.TrueValue = "1";
            this.dataGridViewCheckBoxColumn1.Width = 55;
            // 
            // contasBindingSource3
            // 
            this.contasBindingSource3.DataMember = "Contas";
            this.contasBindingSource3.DataSource = this.financeiroDataSet1;
            // 
            // financeiroDataSet1
            // 
            this.financeiroDataSet1.DataSetName = "FinanceiroDataSet";
            this.financeiroDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contasBindingSource2
            // 
            this.contasBindingSource2.DataMember = "Contas";
            this.contasBindingSource2.DataSource = this.financeiroDataSet1;
            // 
            // contasBindingSource1
            // 
            this.contasBindingSource1.DataMember = "Contas";
            this.contasBindingSource1.DataSource = this.financeiroDataSet;
            // 
            // financeiroDataSet
            // 
            this.financeiroDataSet.DataSetName = "FinanceiroDataSet";
            this.financeiroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contasBindingSource
            // 
            this.contasBindingSource.DataMember = "Contas";
            // 
            // txtconta
            // 
            this.txtconta.Location = new System.Drawing.Point(273, 54);
            this.txtconta.Name = "txtconta";
            this.txtconta.Size = new System.Drawing.Size(205, 20);
            this.txtconta.TabIndex = 0;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.BackColor = System.Drawing.Color.Transparent;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(151, 163);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(154, 18);
            this.label40.TabIndex = 47;
            this.label40.Text = "Forma de pagamento:";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.BackColor = System.Drawing.Color.Transparent;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(496, 56);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(143, 18);
            this.label42.TabIndex = 46;
            this.label42.Text = "Data de vencimento:";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.BackColor = System.Drawing.Color.Transparent;
            this.label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.Location = new System.Drawing.Point(151, 55);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(117, 18);
            this.label52.TabIndex = 45;
            this.label52.Text = "Nome da Conta:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(644, 54);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(66, 20);
            this.maskedTextBox1.TabIndex = 1;
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(258, 106);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(220, 20);
            this.txtValor.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 61;
            this.label1.Text = "Valor Mensal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(496, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 18);
            this.label2.TabIndex = 62;
            this.label2.Text = "Tipo:";
            // 
            // cbTipo
            // 
            this.cbTipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(543, 159);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(167, 21);
            this.cbTipo.TabIndex = 63;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.BackColor = System.Drawing.Color.Transparent;
            this.lblid.Location = new System.Drawing.Point(184, 251);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(43, 13);
            this.lblid.TabIndex = 64;
            this.lblid.Text = "______";
            this.lblid.Visible = false;
            // 
            // contasTableAdapter
            // 
            this.contasTableAdapter.ClearBeforeFill = true;
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
            this.alterar.Location = new System.Drawing.Point(412, 242);
            this.alterar.Name = "alterar";
            this.alterar.Size = new System.Drawing.Size(159, 29);
            this.alterar.TabIndex = 65;
            this.alterar.Text = "Alterar transação";
            this.alterar.UseVisualStyleBackColor = false;
            this.alterar.Visible = false;
            this.alterar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancelar
            // 
            this.cancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.cancelar.BackColor = System.Drawing.Color.Transparent;
            this.cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar.ForeColor = System.Drawing.Color.Black;
            this.cancelar.Image = ((System.Drawing.Image)(resources.GetObject("cancelar.Image")));
            this.cancelar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.cancelar.Location = new System.Drawing.Point(577, 242);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(159, 29);
            this.cancelar.TabIndex = 66;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = false;
            this.cancelar.Visible = false;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(151, 533);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 18);
            this.label3.TabIndex = 67;
            this.label3.Text = " ";
            // 
            // Transações
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(852, 602);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.txtn_parcelas);
            this.Controls.Add(this.label56);
            this.Controls.Add(this.pictureBox15);
            this.Controls.Add(this.pictureBox18);
            this.Controls.Add(this.cbForma);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtconta);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.label52);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.alterar);
            this.Controls.Add(this.add);
            this.Controls.Add(this.consultar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(470, 150);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Transações";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Transações";
            this.Deactivate += new System.EventHandler(this.Transações_Deactivate);
            this.Load += new System.EventHandler(this.Transações_Load);
            this.VisibleChanged += new System.EventHandler(this.Transações_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeiroDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeiroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button add;
		private System.Windows.Forms.TextBox txtn_parcelas;
		private System.Windows.Forms.Label label56;
		private System.Windows.Forms.PictureBox pictureBox15;
		private System.Windows.Forms.PictureBox pictureBox18;
		private System.Windows.Forms.ComboBox cbForma;
		private System.Windows.Forms.Button consultar;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox txtconta;
		private System.Windows.Forms.Label label40;
		private System.Windows.Forms.Label label42;
		private System.Windows.Forms.Label label52;
		private System.Windows.Forms.BindingSource contasBindingSource;
		private System.Windows.Forms.MaskedTextBox maskedTextBox1;
		private System.Windows.Forms.TextBox txtValor;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbTipo;
		private System.Windows.Forms.Label lblid;
		private FinanceiroDataSet financeiroDataSet;
		private System.Windows.Forms.BindingSource contasBindingSource1;
		private FinanceiroDataSetTableAdapters.ContasTableAdapter contasTableAdapter;
		private System.Windows.Forms.Button alterar;
		private System.Windows.Forms.Button cancelar;
		private FinanceiroDataSet financeiroDataSet1;
		private System.Windows.Forms.BindingSource contasBindingSource2;
        private System.Windows.Forms.Label label3;
		private System.Windows.Forms.BindingSource contasBindingSource3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Forma_pagamento;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
	}
}