using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KontGeld
{
    public partial class Relatórios : Form
    {
        SqlConnection sql = new SqlConnection("Data Source=L05M01;Initial Catalog=EconomicImperium;Integrated Security=True");
        public Relatórios()
        {
            InitializeComponent();
            this.Location = new Point(TelaLogin.ini.Location.X + 202, TelaLogin.ini.Location.Y + 49);
        }

        private void Relatórios_Load(object sender, EventArgs e)
        {
         //  this.ContasTableAdapter.FillByDate(this.FinanceiroDataSet.Contas);
            this.reportViewer1.RefreshReport();
        }

        private void Relatórios_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }

		private void button1_Click(object sender, EventArgs e)
		{
		//	this.ContasTableAdapter.FillByDate(this.FinanceiroDataSet.Contas, DateTime.Parse(txtinicio.Text), DateTime.Parse(txtfim.Text));
			this.reportViewer1.RefreshReport();
		}

		private void fillByDateToolStripButton_Click(object sender, EventArgs e)
		{
			/*try
			{
				this.ContasTableAdapter.FillByDate(this.FinanceiroDataSet.Contas, inicioToolStripTextBox.Text, terminoToolStripTextBox.Text);
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
			*/
		}

		private void fillByDateToolStripButton_Click_1(object sender, EventArgs e)
		{/*
			try
			{
				this.ContasTableAdapter.FillByDate(this.FinanceiroDataSet.Contas, ((System.DateTime)(System.Convert.ChangeType(inicioToolStripTextBox.Text, typeof(System.DateTime)))), ((System.DateTime)(System.Convert.ChangeType(terminoToolStripTextBox.Text, typeof(System.DateTime)))));
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}*/

		}
	}
}
