using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace KontGeld
{
	public partial class Objetivos : Form
	{
		SqlConnection sql = new SqlConnection("Data Source=L05M01;Initial Catalog=EconomicImperium;Integrated Security=True");

		Objetivo objt = new Objetivo();
		public Objetivos()
		{
			InitializeComponent();
			this.Location = new Point(TelaLogin.ini.Location.X + 202, TelaLogin.ini.Location.Y + 49);
		}

		private void Objetivos_Deactivate(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void pB18_Click(object sender, EventArgs e)
		{
			gpTableObj.Visible = true;
			gpAddObj.Visible = false;
			alterar.Visible = false;
			confirmar.Visible = true;

			lbltt.Text = "";
			desc.Text = "";
			vt.Text = "";
			mobj.Text = "";
		}

		private void pictureBox7_Click(object sender, EventArgs e)
		{
			gpTableObj.Visible = false;
			gpAddObj.Visible = true;
			alterar.Visible = false;
			confirmar.Visible = true;

			lbltt.Text = "";
			desc.Text = "";
			vt.Text = "";
            mobj.Text = "";
		}

		private void pictureBox8_Click(object sender, EventArgs e)
		{
			gpTableObj.Visible = false;
			gpAddObj.Visible = true;
			confirmar.Visible = true;
			alterar.Visible = false;

			lbltt.Text = "";
			desc.Text = "";
			vt.Text = "";
			mobj.Text = "";
		}

		private void pictureBox9_Click(object sender, EventArgs e)
		{
			gpTableObj.Visible = false;
			gpAddObj.Visible = true;
			alterar.Visible = false;
			confirmar.Visible = true;

			lbltt.Text = "";
			desc.Text = "";
			vt.Text = "";
			mobj.Text = "";
		}

		private void pictureBox10_Click(object sender, EventArgs e)
		{
			gpTableObj.Visible = false;
			gpAddObj.Visible = true;
			alterar.Visible = false;
			confirmar.Visible = true;

			lbltt.Text = "";
			desc.Text = "";
			vt.Text = "";
			mobj.Text = "";
		}

		private void pictureBox14_Click(object sender, EventArgs e)
		{
			gpTableObj.Visible = false;
			gpAddObj.Visible = true;
			confirmar.Visible = true;
			alterar.Visible = false;

			lbltt.Text = "";
			desc.Text = "";
			vt.Text = "";
			mobj.Text = "";
		}

		private void pictureBox13_Click(object sender, EventArgs e)
		{
			gpTableObj.Visible = false;
			gpAddObj.Visible = true;
			confirmar.Visible = true;
			alterar.Visible = false;

			lbltt.Text = "";
			desc.Text = "";
			vt.Text = "";
			mobj.Text = "";
		}

		private void pictureBox12_Click(object sender, EventArgs e)
		{
			gpTableObj.Visible = false;
			gpAddObj.Visible = true;
			alterar.Visible = false;
			confirmar.Visible = true;

			lbltt.Text = "";
			desc.Text = "";
			vt.Text = "";
			mobj.Text = "";
		}

		private void pictureBox11_Click(object sender, EventArgs e)
		{
			gpTableObj.Visible = false;
			gpAddObj.Visible = true;
			alterar.Visible = false;
			confirmar.Visible = true;

			lbltt.Text = "";
			desc.Text = "";
			vt.Text = "";
			mobj.Text = "";
		}

		private void pB15_MouseHover(object sender, EventArgs e)
		{
			System.Windows.Forms.ToolTip toolTip1 = new System.Windows.Forms.ToolTip();
			toolTip1.SetToolTip(pB15, "Calcular objetivo");
		}

		private void pB15_Click(object sender, EventArgs e)
		{
			objt.vt = Convert.ToDouble(vt.Text);
			objt.mobj = Convert.ToInt32(mobj.Text);
		
			objt.calcular();
			lbltt.Text = Convert.ToString(objt.tt);
		}

		private void mobj_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 13)
			{
				objt.vt = Convert.ToDouble(vt.Text);
				objt.mobj = Convert.ToInt32(mobj.Text);

                objt.calcular();
				lbltt.Text = Convert.ToString(objt.tt);
			}
		}

		private void pictureBox16_MouseHover(object sender, EventArgs e)
		{
			System.Windows.Forms.ToolTip toolTip1 = new System.Windows.Forms.ToolTip();
			toolTip1.SetToolTip(pB18, "Excluir objetivos");
		}

		private void pB18_MouseHover(object sender, EventArgs e)
		{
			System.Windows.Forms.ToolTip toolTip1 = new System.Windows.Forms.ToolTip();
			toolTip1.SetToolTip(pB18, "Exibir objetivos");
		}

		private void pB18_Click_1(object sender, EventArgs e)
		{
			SqlDataAdapter da = new SqlDataAdapter("select * from Metas where ID_Usuario=" + TelaLogin.ID_USUARIO, sql);
			DataTable dt = new DataTable();
			da.Fill(dt);
			dataGridView3.DataSource = dt;

			gpTableObj.Visible = true;
			gpAddObj.Visible = false;
		}

		private void pictureBox17_MouseHover(object sender, EventArgs e)
		{
			System.Windows.Forms.ToolTip toolTip1 = new System.Windows.Forms.ToolTip();
			toolTip1.SetToolTip(pictureBox17, "Editar objetivos");
		}

		private void Objetivos_Load(object sender, EventArgs e)
		{
			//this.metasTableAdapter.Fill(this.financeiroDataSet.Metas);
			dataGridView3.ClearSelection();
		}

		private void confirmar_Click(object sender, EventArgs e)
		{
			if (desc.Text != "" & vt.Text != "" & mobj.Text != "")
			{
				SqlCommand cmmd = new SqlCommand("insert into Metas(Nome,Valor_total,Valor_mensal,Meses, ID_Usuario) values (@Nome,@Valor_total,@Valor_mensal, @Meses,@ID_Usuario)", sql);

				cmmd.Parameters.Add("@Nome", SqlDbType.VarChar).Value = desc.Text;
				cmmd.Parameters.Add("@Valor_total", SqlDbType.Decimal).Value = vt.Text;
				cmmd.Parameters.Add("@Meses", SqlDbType.Int).Value = mobj.Text;
				cmmd.Parameters.Add("@Valor_mensal", SqlDbType.Decimal).Value = lbltt.Text;
				cmmd.Parameters.Add("@ID_Usuario", SqlDbType.Int).Value = TelaLogin.ID_USUARIO;

                gpTableObj.Visible = true;
                gpAddObj.Visible = false;

                try
				{
					sql.Open();
					cmmd.ExecuteNonQuery();

                    label3.Text = "Inserido com sucesso. Atualize a tabela!";

                    desc.Text = "";
					vt.Text = "";
					mobj.Text = "";
					lbltt.Text = "";
					gpAddObj.Visible = false;
				}

				catch (Exception)
				{
                    label3.Text = "Opa, algo deu errado!";
                    desc.Text = "";
					vt.Text = "";
					mobj.Text = "";
					lbltt.Text = "";
				}

				finally
				{
					sql.Close();
				}
			}
			SqlDataAdapter da = new SqlDataAdapter("select * from Metas where Concluido is null and ID_Usuario=" + TelaLogin.ID_USUARIO, sql);
			DataTable dt = new DataTable();
			da.Fill(dt);
			dataGridView3.DataSource = dt;

			label3.Text = "";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			desc.Text = "";
			vt.Text = "";
			mobj.Text = "";
			lbltt.Text = "";

			gpAddObj.Visible = false;
		}

		private void pictureBox15_Click(object sender, EventArgs e)
		{
			SqlDataAdapter da = new SqlDataAdapter("select * from Metas where Concluido is null and ID_Usuario=" + TelaLogin.ID_USUARIO, sql);
			DataTable dt = new DataTable();
			da.Fill(dt);
			dataGridView3.DataSource = dt;
		
			label3.Text = "";
		}

		private void pictureBox15_MouseHover(object sender, EventArgs e)
		{
			System.Windows.Forms.ToolTip toolTip1 = new System.Windows.Forms.ToolTip();
			toolTip1.SetToolTip(pictureBox15, "Atualizar objetivos");
		}

		private void pictureBox17_Click(object sender, EventArgs e)
		{
			gpTableObj.Visible = false;
			gpAddObj.Visible = true;
			confirmar.Visible = false;
		}

		private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			lblid.Text = dataGridView3.Rows[dataGridView3.CurrentCell.RowIndex].Cells[0].Value.ToString();
			desc.Text = dataGridView3.Rows[dataGridView3.CurrentCell.RowIndex].Cells[1].Value.ToString();
			vt.Text = dataGridView3.Rows[dataGridView3.CurrentCell.RowIndex].Cells[2].Value.ToString();
			mobj.Text = dataGridView3.Rows[dataGridView3.CurrentCell.RowIndex].Cells[3].Value.ToString();
			lbltt.Text = dataGridView3.Rows[dataGridView3.CurrentCell.RowIndex].Cells[4].Value.ToString();

			alterar.Visible = true;
		}

		private void pictureBox16_Click(object sender, EventArgs e)
		{
			SqlCommand cmmd = new SqlCommand("delete from Metas where ID_Metas=@ID_Metas", sql);

			cmmd.Parameters.Add("@ID_Metas", SqlDbType.Int).Value = lblid.Text;

			if (desc.Text != "" & vt.Text != "" & mobj.Text != "" & lbltt.Text != "")
			{
				try
				{
					sql.Open();
					cmmd.ExecuteNonQuery();

                    label3.Text = "Excluído com sucesso. Atualize a tabela!";
                }
                catch (Exception)
				{
                    label3.Text = "Opa, algo deu errado!";
                }
                finally
				{
					sql.Close();

					desc.Text = "";
					vt.Text = "";
					mobj.Text = "";
					lbltt.Text = "";
				}
			}

			else
			{
                label3.Text = "Por favor, digite todas as informações pedidas";
            }
        }

		private void alterar_Click(object sender, EventArgs e)
		{
			SqlCommand cmmd = new SqlCommand("update Metas set Nome=@Nome, Valor_total=@Valor_total, Meses=@Meses, Valor_mensal=@Valor_mensal where ID_Metas=@ID_Metas and ID_Usuario=" + TelaLogin.ID_USUARIO, sql);

			cmmd.Parameters.Add("@ID_Metas", SqlDbType.Int).Value = lblid.Text;
			cmmd.Parameters.Add("@Nome", SqlDbType.VarChar).Value = desc.Text;
			cmmd.Parameters.Add("@Valor_total", SqlDbType.Decimal).Value = vt.Text;
			cmmd.Parameters.Add("@Meses", SqlDbType.Int).Value = mobj.Text;
			cmmd.Parameters.Add("@Valor_mensal", SqlDbType.Decimal).Value = lbltt.Text;

			if (desc.Text != "" & vt.Text != "" & mobj.Text != "")
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
					gpTableObj.Visible = true;
					gpAddObj.Visible = false;

					sql.Close();
					desc.Text = "";
					vt.Text = "";
					mobj.Text = "";
					lbltt.Text = "";
				}
			}

			SqlDataAdapter da = new SqlDataAdapter("select * from Metas where Concluido is null and ID_Usuario=" + TelaLogin.ID_USUARIO, sql);
			DataTable dt = new DataTable();
			da.Fill(dt);
			dataGridView3.DataSource = dt;

			label3.Text = "";
		}

		private void button2_Click(object sender, EventArgs e)
		{
            gpTableObj.Visible = true;
            gpAddObj.Visible = false;

            desc.Text = "";
			vt.Text = "";
			mobj.Text = "";
			lbltt.Text = "";
		}

		private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dataGridView3.CurrentCell.ColumnIndex.Equals(5) && e.RowIndex != -1)
			{
				label4.Visible = true;
				label5.Visible = true;
				label6.Visible = true;
			}
        }

		private void label5_Click(object sender, EventArgs e)
		{
			SqlCommand cmmd = new SqlCommand("delete from Metas where ID_Metas=@ID_Metas and ID_Usuario=" + TelaLogin.ID_USUARIO, sql);

			cmmd.Parameters.Add("@ID_Metas", SqlDbType.Int).Value = lblid.Text;

			try
			{
				sql.Open();
				cmmd.ExecuteNonQuery();
				label4.Visible = false;
				label5.Visible = false;
				label6.Visible = false;
				label3.Text = "Alterado com sucesso!";
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

		private void label6_Click(object sender, EventArgs e)
		{
			label4.Visible = false;
			label5.Visible = false;
			label6.Visible = false;
		}

		private void Objetivos_VisibleChanged(object sender, EventArgs e)
		{
			SqlDataAdapter da = new SqlDataAdapter("select * from Metas where Concluido is null and ID_Usuario=" + TelaLogin.ID_USUARIO, sql);
			DataTable dt = new DataTable();
			da.Fill(dt);
			dataGridView3.DataSource = dt;

			label3.Text = "";
		}
	}
}
