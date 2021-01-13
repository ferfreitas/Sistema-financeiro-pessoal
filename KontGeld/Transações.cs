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
	public partial class Transações : Form
	{
        SqlConnection sql = new SqlConnection("Data Source=L05M01;Initial Catalog=EconomicImperium;Integrated Security=True");

        public static string Despesa;
		public SqlDataReader dr;

        private void atualiza()
		{
			SqlDataAdapter da = new SqlDataAdapter("select * from Contas where Situacao is null and ID_Usuario=" + TelaLogin.ID_USUARIO + "or Situacao =0 and  ID_Usuario=" + TelaLogin.ID_USUARIO, sql);
			DataTable dt = new DataTable();
			da.Fill(dt);
			dataGridView1.DataSource = dt;
		}

		public Transações()
		{
			InitializeComponent();
			this.Location = new Point(TelaLogin.ini.Location.X + 202, TelaLogin.ini.Location.Y + 49);
		}

		private void Transações_Deactivate(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void pictureBox18_MouseHover(object sender, EventArgs e)
		{
			System.Windows.Forms.ToolTip toolTip1 = new System.Windows.Forms.ToolTip();
			toolTip1.SetToolTip(pictureBox18, "Excluir conta");
		}

		private void pictureBox15_MouseHover(object sender, EventArgs e)
		{
			System.Windows.Forms.ToolTip toolTip1 = new System.Windows.Forms.ToolTip();
			toolTip1.SetToolTip(pictureBox15, "Pagar conta");
		}

		private void button5_Click(object sender, EventArgs e)
		{
			if (txtconta.Text != "" & txtn_parcelas.Text != "" & cbForma.Text != "" & maskedTextBox1.Text != "" & txtValor.Text != "" && cbTipo.Text != "")
			{
				try
				{
					sql.Open();
					DateTime datavenc = DateTime.Parse(maskedTextBox1.Text);

					for (int i = 0; i < int.Parse(txtn_parcelas.Text); i++)
					{
						SqlCommand cmmd = new SqlCommand("insert into Contas(Nome,Valor,Parcelas,Forma_pagamentp,ID_Tipo,Vencimento, ID_Usuario) values (@Nome,@Valor,@Parcelas,@Forma_pagamentp,@ID_Tipo,@Vencimento, @ID_Usuario)", sql);

						cmmd.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txtconta.Text;
						cmmd.Parameters.Add("@Parcelas", SqlDbType.Int).Value = txtn_parcelas.Text;
						cmmd.Parameters.Add("@ID_Tipo", SqlDbType.Int).Value = cbTipo.SelectedValue;
						cmmd.Parameters.Add("@Vencimento", SqlDbType.DateTime).Value = datavenc.AddMonths(i);
						cmmd.Parameters.Add("@Valor", SqlDbType.Decimal).Value = txtValor.Text;
						cmmd.Parameters.Add("@Forma_pagamentp", SqlDbType.VarChar).Value = cbForma.Text;
						cmmd.Parameters.Add("@ID_Usuario", SqlDbType.Int).Value = TelaLogin.ID_USUARIO;
						cmmd.ExecuteNonQuery();
                    }
                    label3.Text = "Inserido com sucesso. Atualize a tabela!";
				}

				catch (Exception)
				{
					label3.Text = "Opa, algo deu errado!";
				}

				finally
				{
					sql.Close();
					txtconta.Text = "";
					txtn_parcelas.Text = "";
					txtValor.Text = "";
					maskedTextBox1.Text = "";
					cbForma.Text = "";
					cbTipo.SelectedIndex = -1;
				}
			}
		}

		private void Transações_Load(object sender, EventArgs e)
		{
			//this.contasTableAdapter.Fill(this.financeiroDataSet.Contas);
			teste();
			dataGridView1.ClearSelection();
		}

		private void pictureBox18_Click(object sender, EventArgs e)
		{
			SqlCommand cmmd = new SqlCommand("delete from Contas where ID_Contas=@ID_Contas and ID_Usuario=" + TelaLogin.ID_USUARIO, sql);

			cmmd.Parameters.Add("@ID_Contas", SqlDbType.Int).Value = lblid.Text;

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

				txtconta.Text = "";
				txtn_parcelas.Text = "";
				txtValor.Text = "";
				maskedTextBox1.Text = "";
				cbForma.Text = "";
				cbTipo.SelectedIndex = -1;

				cancelar.Visible = false;
				alterar.Visible = false;

				add.Visible = true;
				consultar.Visible = true;
			}
		}

		private void pictureBox15_Click(object sender, EventArgs e)
		{
            try
			{
				SqlDataAdapter da = new SqlDataAdapter("select * from Contas where Situacao is null and ID_Usuario=" + TelaLogin.ID_USUARIO + "or Situacao =0 and  ID_Usuario=" + TelaLogin.ID_USUARIO, sql);
				DataTable dt = new DataTable();
				da.Fill(dt);
				dataGridView1.DataSource = dt;

				label3.Text = "";
			}
			catch (Exception ex)
			{
				label3.Text = ex.Message;
			}

            alterar.Visible = false;
            consultar.Visible = true;
            add.Visible = true;
            alterar.Visible = false;

            txtconta.Text = "";
            txtn_parcelas.Text = "";
            txtValor.Text = "";
            maskedTextBox1.Text = "";
            cbForma.SelectedIndex = -1;
			cbTipo.SelectedIndex = -1;
		}

		void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			lblid.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
			txtconta.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value.ToString();
			txtn_parcelas.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString();
			cbForma.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value.ToString();
			maskedTextBox1.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[6].Value.ToString();
			txtValor.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString();
			cbTipo.SelectedValue = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[5].Value.ToString();

			add.Visible = false;
			consultar.Visible = false;
			alterar.Visible = true;
			cancelar.Visible = true;
		}

		private void button1_Click(object sender, EventArgs e)
		{
             if (txtconta.Text != "" & txtn_parcelas.Text != "" & cbTipo.Text != "" & maskedTextBox1.Text != "" & txtValor.Text != "" & cbForma.Text != "")
                {
                     SqlCommand cmmd = new SqlCommand("update Contas set Nome=@Nome, Valor=@Valor, Parcelas=@Parcelas,Forma_pagamentp=@Forma_pagamentp, ID_Tipo=@ID_Tipo, Vencimento=@Vencimento where ID_Contas=@ID_Contas and ID_Usuario=" + TelaLogin.ID_USUARIO, sql);
                    cmmd.Parameters.Add("@ID_Contas", SqlDbType.Int).Value = lblid.Text;
                    cmmd.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txtconta.Text;
                    cmmd.Parameters.Add("@Parcelas", SqlDbType.Int).Value = txtn_parcelas.Text;
                    cmmd.Parameters.Add("@ID_Tipo", SqlDbType.Int).Value = cbTipo.SelectedValue;
                    cmmd.Parameters.Add("@Vencimento", SqlDbType.Date).Value = maskedTextBox1.Text;
                    cmmd.Parameters.Add("@Valor", SqlDbType.Decimal).Value = txtValor.Text;
                    cmmd.Parameters.Add("@Forma_pagamentp", SqlDbType.VarChar).Value = cbForma.Text;
                    
                    try
                    {
                        sql.Open();
                        cmmd.ExecuteNonQuery();

                        label3.Text = "Alterado com Sucesso! Atualize a tabela!";
                    }

                    catch
                    {
                        label3.Text = "Opa, algo deu errado!";
                    }

                    finally
                    {
                        sql.Close();

                        txtconta.Text = "";
                        txtn_parcelas.Text = "";
                        txtValor.Text = "";
                        maskedTextBox1.Text = "";
                        cbForma.Text = "";
                        cbTipo.SelectedIndex = -1;

                        cancelar.Visible = false;
                        alterar.Visible = false;
                        add.Visible = true;
                        consultar.Visible = true;
                    }
                }
                else
                {
                    label3.Text = "Por favor, digite todas as informações pedidas";

                }
            
				SqlCommand sit = new SqlCommand("update Contas set Situacao=@Situacao where ID_Contas = @ID_Contas and ID_Usuario=" + TelaLogin.ID_USUARIO, sql);
				sit.Parameters.Add("@ID_Contas", SqlDbType.Int).Value = dataGridView1.CurrentRow.Cells[0].Value;
				sit.Parameters.Add("@Situacao", SqlDbType.Int).Value = dataGridView1.CurrentRow.Cells[7].Value;

				try
				{
					sql.Open();
					sit.ExecuteNonQuery();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex.Equals(7) && e.RowIndex != -1)
            {
                SqlCommand sit = new SqlCommand("update Contas set Situacao=@Situacao where ID_Contas = @ID_Contas and ID_Usuario=" + TelaLogin.ID_USUARIO, sql);
                sit.Parameters.Add("@ID_Contas", SqlDbType.Int).Value = dataGridView1.CurrentRow.Cells[0].Value;
                sit.Parameters.Add("@Situacao", SqlDbType.Int).Value = dataGridView1.CurrentRow.Cells[7].Value;

                try
                {
                    sql.Open();
                    sit.ExecuteNonQuery();
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
		}

        private void Transações_VisibleChanged(object sender, EventArgs e)
		{
			this.atualiza();
			teste();
		}

		private void cancelar_Click(object sender, EventArgs e)
		{
			txtconta.Text = "";
			txtn_parcelas.Text = "";
			txtValor.Text = "";
			maskedTextBox1.Text = "";
			cbForma.SelectedIndex = -1;
			cbTipo.SelectedIndex = -1;

			cancelar.Visible = false;
            consultar.Visible = true;
        }

        private void consultar_Click(object sender, EventArgs e)
		{
			if (txtconta.Text != "")
			{
				SqlDataAdapter da = new SqlDataAdapter("select * from Contas where Nome like '%" + txtconta.Text + "%' and ID_Usuario=" + TelaLogin.ID_USUARIO, sql);
				DataTable dt = new DataTable();
				da.Fill(dt);
				dataGridView1.DataSource = dt;

				label3.Text = "";
			}

			else
			{
				SqlDataAdapter da = new SqlDataAdapter("select * from Contas where ID_Usuario=" + TelaLogin.ID_USUARIO, sql);
				DataTable dt = new DataTable();
				da.Fill(dt);
				dataGridView1.DataSource = dt;

				label3.Text = "";
			}
		}

		public void teste()
		{
			DataTable tb = new DataTable("Tipo");
			sql.Open();
			SqlCommand cmmd = new SqlCommand("select ID_Tipo, Nome_tipo from Tipo", sql);
			dr = cmmd.ExecuteReader();
			tb.Load(dr);
			cbTipo.DisplayMember = "Nome_tipo";
			cbTipo.ValueMember = "ID_Tipo";
			cbTipo.DataSource = tb;
			sql.Close();
		}
	}
}
	
	

