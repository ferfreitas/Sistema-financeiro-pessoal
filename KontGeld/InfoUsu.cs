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
    public partial class InfoUsu : Form
    {
		SqlConnection sql = new SqlConnection("Data Source=L05M01;Initial Catalog=EconomicImperium;Integrated Security=True");

		public InfoUsu()
        {
            InitializeComponent();
			this.Location = new Point(TelaLogin.ini.Location.X + 202, TelaLogin.ini.Location.Y + 49);
        }

		private void InfoUsu_Deactivate(object sender, EventArgs e)
        {
			this.Hide();
		}

		private void PictureBox4_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip1 = new System.Windows.Forms.ToolTip();
            toolTip1.SetToolTip(pictureBox4, "Adicionar emprego");
        }

        private void PictureBox6_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip1 = new System.Windows.Forms.ToolTip();
            toolTip1.SetToolTip(pictureBox6, "Excluir emprego");
        }

        private void InfoUsu_Load(object sender, EventArgs e)
        {
			//this.empregoTableAdapter.Fill(this.financeiroDataSet.Emprego);
			dataEmprego.ClearSelection();
		}

		private void button9_Click(object sender, EventArgs e)
		{
			if (txtatual.Text != "" & txtns.Text != "" & txtcs.Text != "")
			{
				if (txtns.Text == txtcs.Text & txtns.Text != "" & txtcs.Text != "")
				{
					SqlCommand command = new SqlCommand("update Usuario set Senha=@Senha where ID_Usuario=@ID_Usuario", sql);
					command.Parameters.Add("@ID_Usuario", SqlDbType.VarChar).Value = TelaLogin.ID_USUARIO;
					command.Parameters.Add("@Senha", SqlDbType.Int).Value = txtns.Text;

					try
					{
						sql.Open();
						command.ExecuteNonQuery();
                        label4.Text = "Suas informações foram atualizadas!!";
					}

					catch (Exception)
					{
                        label4.Text = "Opa, algo deu errado!";
                    }

                    finally
					{
						sql.Close();

						txtatual.Text = "";
						txtns.Text = "";
						txtcs.Text = "";
					}
				}

				else
				{

                    label4.Text = "Por favor, digite todas as informações pedidas";
                }
                txtatual.Text = "";
				txtns.Text = "";
				txtcs.Text = "";
			}
			txtatual.Enabled = false;
			txtns.Enabled = false;
			txtcs.Enabled = false;
			ok.Enabled = false;
			cancelar.Enabled = false;
		}

       private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (emp.Text != "" & sm.Text != "")
            {
                SqlCommand cmmd = new SqlCommand("insert into Emprego(Nome,Salario,ID_Usuario) values (@Nome,@Salario,@ID_Usuario)", sql);

                cmmd.Parameters.Add("@Nome", SqlDbType.VarChar).Value = emp.Text;
                cmmd.Parameters.Add("@Salario", SqlDbType.Decimal).Value = sm.Text;
                cmmd.Parameters.Add("@ID_Usuario", SqlDbType.Int).Value = TelaLogin.ID_USUARIO;

                try
                {
                   sql.Open();
                    cmmd.ExecuteNonQuery();

                    label3.Text = "Inserido com sucesso. Atualize a tabela!";

                    emp.Text = "";
                    sm.Text = "";
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    emp.Text = "";
                    sm.Text = "";
                }
                finally
                {
                    sql.Close();
                }
            }
        }

		private void label1_Click(object sender, EventArgs e)
		{
			txtatual.Enabled = true;
			txtns.Enabled = true;
			txtcs.Enabled = true;
			ok.Enabled = true;
			cancelar.Enabled = true;
		}

		private void cancelar_Click(object sender, EventArgs e)
		{
			txtatual.Enabled = false;
			txtns.Enabled = false;
			txtcs.Enabled = false;
			ok.Enabled = false;
			cancelar.Enabled = false;
		}

		private void pictureBox4_Click_1(object sender, EventArgs e)
		{
			if (emp.Text != "" & sm.Text != "")
			{
				SqlCommand cmmd = new SqlCommand("insert into Emprego (Nome,Salario,ID_Usuario) values (@Nome,@Salario,@ID_Usuario)", sql);

				cmmd.Parameters.Add("@Nome", SqlDbType.VarChar).Value = emp.Text;
				cmmd.Parameters.Add("@Salario", SqlDbType.Decimal).Value = sm.Text;
				cmmd.Parameters.Add("@ID_Usuario", SqlDbType.Int).Value = TelaLogin.ID_USUARIO;

				try
				{
					sql.Open();
					cmmd.ExecuteNonQuery();

                    label3.Text = "Inserido com sucesso. Atualize a tabela!";
                    emp.Text = "";
					sm.Text = "";
				}

				catch (Exception)
				{
                    label3.Text = "Opa, algo deu errado!";

                    emp.Text = "";
					sm.Text = "";
				}
				finally
				{
					sql.Close();
				}
			}
		}

		private void dataEmprego_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			lblid.Text = dataEmprego.Rows[dataEmprego.CurrentCell.RowIndex].Cells[0].Value.ToString();
			emp.Text = dataEmprego.Rows[dataEmprego.CurrentCell.RowIndex].Cells[1].Value.ToString();
			sm.Text = dataEmprego.Rows[dataEmprego.CurrentCell.RowIndex].Cells[2].Value.ToString();

			alterar.Visible = true;
			button1.Visible = true;
		}

		private void alterar_Click(object sender, EventArgs e)
		{
			SqlCommand cmmd = new SqlCommand("update Emprego set Nome=@Nome, Salario=@Salario where ID_Emprego=@ID_Emprego and ID_Usuario=@ID_Usuario", sql);

			cmmd.Parameters.Add("@ID_Emprego", SqlDbType.Int).Value = lblid.Text;
			cmmd.Parameters.Add("@Nome", SqlDbType.VarChar).Value = emp.Text;
			cmmd.Parameters.Add("@Salario", SqlDbType.Decimal).Value = sm.Text;
            cmmd.Parameters.Add("@ID_Usuario", SqlDbType.Int).Value = TelaLogin.ID_USUARIO;


            if (emp.Text != "" & sm.Text != "")
			{
				try
				{
					sql.Open();
					cmmd.ExecuteNonQuery();

                    label3.Text = "Alterado com Sucesso! Atualize a tabela!";

                }
                catch (Exception)
				{
                    label3.Text = "Opa, algo deu errado!";
                }
                finally
				{
					sql.Close();
					emp.Text = "";
					sm.Text = "";
					button1.Visible = false;
					alterar.Visible = false;
				}
			}

			else
			{
                label3.Text = "Por favor, digite todas as informações pedidas";

				emp.Text = "";
				sm.Text = "";
				button1.Visible = false;
				alterar.Visible = false;
			}
		}

		private void pictureBox6_Click(object sender, EventArgs e)
		{
			SqlCommand cmmd = new SqlCommand("delete from Emprego where ID_Emprego=@ID_Emprego and ID_Usuario=@ID_Usuario", sql);

			cmmd.Parameters.Add("@ID_Emprego", SqlDbType.Int).Value = lblid.Text;
            cmmd.Parameters.Add("@ID_Usuario", SqlDbType.Int).Value = TelaLogin.ID_USUARIO;


            try
            {
				sql.Open();
				cmmd.ExecuteNonQuery();

                label3.Text = "Excluído com Sucesso! Atualize a tabela!";
                emp.Text = "";
				sm.Text = "";
			}
			catch (Exception)
			{
                label3.Text = "Opa, algo deu errado!";
            }
            finally
			{
				sql.Close();
			}
		}

		private void pictureBox15_Click_1(object sender, EventArgs e)
		{
			SqlDataAdapter da = new SqlDataAdapter("select * from Emprego where ID_Usuario=" + TelaLogin.ID_USUARIO,  sql);
			DataTable dt = new DataTable();
			da.Fill(dt);
			dataEmprego.DataSource = dt;

			label3.Text = "";
		}

        private void pictureBox15_VisibleChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Emprego where ID_Usuario=" + TelaLogin.ID_USUARIO, sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataEmprego.DataSource = dt;

            label3.Text = "";
        }

        private void InfoUsu_VisibleChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Emprego where ID_Usuario=" + TelaLogin.ID_USUARIO, sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataEmprego.DataSource = dt;

            label3.Text = "";
        }
    }
}
