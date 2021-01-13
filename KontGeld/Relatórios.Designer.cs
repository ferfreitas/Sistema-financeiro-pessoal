namespace KontGeld
{
    partial class Relatórios
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
			Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Relatórios));
			this.contasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.FinanceiroDataSet = new KontGeld.FinanceiroDataSet();
			this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtinicio = new System.Windows.Forms.MaskedTextBox();
			this.txtfim = new System.Windows.Forms.MaskedTextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.ContasTableAdapter = new KontGeld.FinanceiroDataSetTableAdapters.ContasTableAdapter();
			this.financeiroDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.contasBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.FinanceiroDataSet)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.financeiroDataSetBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// contasBindingSource1
			// 
			this.contasBindingSource1.DataMember = "Contas";
			this.contasBindingSource1.DataSource = this.FinanceiroDataSet;
			// 
			// FinanceiroDataSet
			// 
			this.FinanceiroDataSet.DataSetName = "FinanceiroDataSet";
			this.FinanceiroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// reportViewer1
			// 
			reportDataSource1.Name = "DataSet2";
			reportDataSource1.Value = this.financeiroDataSetBindingSource;
			this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
			this.reportViewer1.LocalReport.ReportEmbeddedResource = "KontGeld.Report.rdlc";
			this.reportViewer1.Location = new System.Drawing.Point(54, 149);
			this.reportViewer1.Margin = new System.Windows.Forms.Padding(2);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.ServerReport.BearerToken = null;
			this.reportViewer1.Size = new System.Drawing.Size(745, 408);
			this.reportViewer1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(193, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Início:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(384, 42);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(70, 20);
			this.label5.TabIndex = 5;
			this.label5.Text = "Término:";
			// 
			// txtinicio
			// 
			this.txtinicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtinicio.Location = new System.Drawing.Point(249, 39);
			this.txtinicio.Mask = "00/00/0000";
			this.txtinicio.Name = "txtinicio";
			this.txtinicio.Size = new System.Drawing.Size(88, 26);
			this.txtinicio.TabIndex = 6;
			this.txtinicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtinicio.ValidatingType = typeof(System.DateTime);
			// 
			// txtfim
			// 
			this.txtfim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtfim.Location = new System.Drawing.Point(460, 39);
			this.txtfim.Mask = "00/00/0000";
			this.txtfim.Name = "txtfim";
			this.txtfim.Size = new System.Drawing.Size(91, 26);
			this.txtfim.TabIndex = 7;
			this.txtfim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtfim.ValidatingType = typeof(System.DateTime);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.txtfim);
			this.groupBox1.Controls.Add(this.txtinicio);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(35, 18);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(786, 555);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Gerar relatório";
			// 
			// button1
			// 
			this.button1.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
			this.button1.BackColor = System.Drawing.Color.Transparent;
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Black;
			this.button1.Location = new System.Drawing.Point(592, 83);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(159, 29);
			this.button1.TabIndex = 67;
			this.button1.Text = "Gerar";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// ContasTableAdapter
			// 
			this.ContasTableAdapter.ClearBeforeFill = true;
			// 
			// financeiroDataSetBindingSource
			// 
			this.financeiroDataSetBindingSource.DataSource = this.FinanceiroDataSet;
			this.financeiroDataSetBindingSource.Position = 0;
			// 
			// Relatórios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(852, 602);
			this.Controls.Add(this.reportViewer1);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Relatórios";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Relatórios";
			this.Deactivate += new System.EventHandler(this.Relatórios_Deactivate);
			this.Load += new System.EventHandler(this.Relatórios_Load);
			((System.ComponentModel.ISupportInitialize)(this.contasBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.FinanceiroDataSet)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.financeiroDataSetBindingSource)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private FinanceiroDataSet FinanceiroDataSet;
        private FinanceiroDataSetTableAdapters.ContasTableAdapter ContasTableAdapter;
        private System.Windows.Forms.BindingSource contasBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtinicio;
        private System.Windows.Forms.MaskedTextBox txtfim;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
		private System.Windows.Forms.BindingSource financeiroDataSetBindingSource;
	}
}