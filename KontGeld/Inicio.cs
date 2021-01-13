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
	public partial class Inicio : Form
	{
		SqlConnection sql = new SqlConnection("Data Source=L05M01;Initial Catalog=EconomicImperium;Integrated Security=True");

		public Inicio()
		{
			InitializeComponent();

			/*DateTime date = DateTime.Now;
			var firstDayOfMonth = new DateTime(date.Year, date.Month, 1);
			var lastDayOfMonth = new DateTime(date.Year, date.Month, DateTime.DaysInMonth(date.Year, date.Month));*/
		}

		private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaLogin log = new TelaLogin();
            log.ShowDialog();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
		
			   private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
			TelaLogin log = new TelaLogin();
			log.ShowDialog();
	    }

		private void pictureBox6_Click(object sender, EventArgs e)
		{
			var form = new Transações();
			form.Show();
		}

		private void pictureBox7_Click(object sender, EventArgs e)
		{
		    var form = new Objetivos();
		    form.Show();
		}

		private void pictureBox8_Click(object sender, EventArgs e)
		{
			var form = new InfoUsu();
			form.Show();
		}

		private void Inicio_Load(object sender, EventArgs e)
		{
            //this.contasTableAdapter.Fill(this.financeiroDataSet.Contas);
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			SqlCommand cmmd = new SqlCommand("Select Nome, Valor, Vencimento from Contas where ID_Tipo=1 and Situacao is null and ID_Usuario=" + TelaLogin.ID_USUARIO + "or Situacao =0 and ID_Tipo=1 and ID_Usuario=" + TelaLogin.ID_USUARIO, sql);
		}

		private void inicio1_VisibleChanged(object sender, EventArgs e)
		{
			Meta();
			Receitas();
			RPendente();
			Despesas();
			SaldoSeguro();
            DPendente();
            SaldoTotal();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            var form = new Relatórios();
            form.Show();
        }

		public void Meta()
		{
			SqlCommand cmmd = new SqlCommand("Select sum(Valor_mensal) as Valor_mensal from Metas where Concluido is null and ID_Usuario=" + TelaLogin.ID_USUARIO + "or Concluido=0 and ID_Usuario=" + TelaLogin.ID_USUARIO, sql);

			try
			{
				sql.Open();
				SqlDataReader drms = cmmd.ExecuteReader();

				if (drms.HasRows == false)
				{
                    Meta1.Text = "Nenhuma meta cadastrada!";
				}
                else
                {
                    drms.Read();
                    Meta1.Text = Convert.ToString("R$ " + drms["Valor_mensal"]);
                }
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				sql.Close();
			}

		}

		public void Receitas()
		{
			SqlCommand cmmd = new SqlCommand("Select sum(Valor) as Valor from Contas where Situacao is null and ID_Tipo=2 and ID_Usuario=" + TelaLogin.ID_USUARIO + "or Situacao=0 and ID_Tipo=2 and ID_Usuario=" + TelaLogin.ID_USUARIO, sql);

			try
			{
				sql.Open();
				SqlDataReader drms = cmmd.ExecuteReader();

				if (drms.HasRows == false)
				{
					drms.Read();
					receitas1.Text = "Nenhuma receita cadastrada!";
				}

				else
				{
					drms.Read();
					receitas1.Text = Convert.ToString("R$ " + drms["Valor"]);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				sql.Close();
			}
		}
		public void Despesas()
		{
			SqlCommand cmmd = new SqlCommand("Select sum(Valor) as Valor from Contas where Situacao is null and ID_Tipo=1 and ID_Usuario=" + TelaLogin.ID_USUARIO + "  or Situacao = 0 and ID_Tipo=1 and  ID_Usuario=" + TelaLogin.ID_USUARIO, sql);

			try
			{
				sql.Open();
				SqlDataReader drms = cmmd.ExecuteReader();

				if (drms.HasRows == false)
				{
					drms.Read();
					Despesas1.Text = "Nenhuma despesa cadastrada!";
				}

				else
				{
					drms.Read();
					Despesas1.Text = Convert.ToString("R$ " + drms["Valor"]);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				sql.Close();
			}
		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			Meta();
			Receitas();
			Despesas();
		    RPendente();
			SaldoSeguro();
            DPendente();
            SaldoTotal();

            SqlDataAdapter da = new SqlDataAdapter("Select Nome, Valor, Vencimento from Contas where ID_Tipo=1 and Situacao is null and ID_Usuario=" + TelaLogin.ID_USUARIO + "or Situacao =0 and ID_Tipo=1 and ID_Usuario=" + TelaLogin.ID_USUARIO, sql);
			DataTable dt = new DataTable();
			da.Fill(dt);
			dataGridView1.DataSource = dt;
		}

        public void DPendente()
        {
            SqlCommand cmmd = new SqlCommand("Select sum(Valor) as Valor from Contas where Situacao is null and ID_Tipo=1 and Vencimento between '01-12-2018' and '31-12-2018' and ID_Usuario=" + TelaLogin.ID_USUARIO + "or Situacao=0 and ID_Tipo=1 and  ID_Usuario="
                + TelaLogin.ID_USUARIO + "and Vencimento between '01-12-2018' and '31-12-2018'", sql);

            try
            {
                sql.Open();
                SqlDataReader drms = cmmd.ExecuteReader();

                if (drms.HasRows == false)
                {
                    drms.Read();
                    dpendente1.Text = "Nenhuma despesa cadastrada!";
                }

                else
                {
                    drms.Read();
                    dpendente1.Text = Convert.ToString("R$ " + drms["Valor"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sql.Close();
            }
        }
        
        public void RPendente()
		{
            SqlCommand cmmd = new SqlCommand("Select sum(Valor) as Valor from Contas where Situacao is null and ID_Tipo=2 and Vencimento between '01-12-2018' and '31-12-2018' and ID_Usuario=" + TelaLogin.ID_USUARIO + "or Situacao=0 and ID_Tipo=2 and  ID_Usuario="
                  + TelaLogin.ID_USUARIO + "and Vencimento between '01-12-2018' and '31-12-2018'", sql);

            try
			{
				sql.Open();
				SqlDataReader drms = cmmd.ExecuteReader();

				if (drms.HasRows == false)
				{
					drms.Read();
					receitas2.Text = "Nenhuma receita cadastrada!";
				}

				else
				{
					drms.Read();
					receitas2.Text = Convert.ToString("R$ " + drms["Valor"]);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				sql.Close();
			}
		}

     public void SaldoTotal()
        {
            SqlCommand cmmd = new SqlCommand("Select ((select sum(Valor) From Contas where Situacao is null and ID_Tipo = 1 and Vencimento between '01-12-2018' and '31-12-2018' and ID_Usuario=" + TelaLogin.ID_USUARIO + "or Situacao=0 and  ID_Tipo = 1 and Vencimento between '01-12-2018' and '31-12-2018' and ID_Usuario=" + TelaLogin.ID_USUARIO+ ")"
               + "- (select sum(Salario) from Emprego where ID_Usuario= " + TelaLogin.ID_USUARIO +"))" +
                "+ (select sum(Valor) From Contas where Situacao = 1 and ID_Tipo = 2 and Vencimento between '01-12-2018' and '31-12-2018' and ID_Usuario=" + TelaLogin.ID_USUARIO+") as total", sql);

            try
            {
                sql.Open();

                SqlDataReader drms = cmmd.ExecuteReader();

                if (drms.HasRows == false)
                {
                    drms.Read();
                    saldototal2.Text = "Não há informações cadastradas!";
                }

                else
                {
                    drms.Read();
                    saldototal2.Text = Convert.ToString("R$ " + drms["total"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sql.Close();
            }
        }

		public void SaldoSeguro()
		{
			SqlCommand cmmd = new SqlCommand("Select sum(Salario) as Salario from Emprego where ID_Usuario=" + TelaLogin.ID_USUARIO, sql);

			try
			{
				sql.Open();
				SqlDataReader drms = cmmd.ExecuteReader();

				if (drms.HasRows == false)
				{
					drms.Read();
					sseguro.Text = "Nenhum emprego cadastrado!";
				}

				else
				{
					drms.Read();
					sseguro.Text = Convert.ToString("R$ " + drms["Salario"]);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				sql.Close();
			}
		}

		private void Inicio_VisibleChanged(object sender, EventArgs e)
		{
			SqlDataAdapter da = new SqlDataAdapter("Select Nome, Valor, Vencimento from Contas where ID_Tipo=1 and Situacao is null and ID_Usuario=" + TelaLogin.ID_USUARIO + "or Situacao =0 and ID_Tipo=1 and ID_Usuario=" + TelaLogin.ID_USUARIO, sql);
			DataTable dt = new DataTable();
			da.Fill(dt);
			dataGridView1.DataSource = dt;
		}
    }
}

