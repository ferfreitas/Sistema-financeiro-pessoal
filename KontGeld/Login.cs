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
	public partial class TelaLogin : Form
	{
		SqlConnection sqlConn = null;
		private string strCoon = @"Data Source=L05M01;Initial Catalog = EconomicImperium; Integrated Security = True";
		private string _Sql = string.Empty;

		public static int ID_USUARIO;
		public static Inicio ini;

		public TelaLogin()
		{
			InitializeComponent();
		}

		public void logar()
		{
			sqlConn = new SqlConnection(strCoon);
			string usu, senha;

			try
			{
				usu = txtLogin.Text;
				senha = txtSenha.Text;

				_Sql = "SELECT ID_Usuario FROM Usuario WHERE Login = @Login AND Senha = @Senha";
				SqlCommand cmd = new SqlCommand(_Sql, sqlConn);

				cmd.Parameters.Add("@Login", SqlDbType.VarChar).Value = usu;
				cmd.Parameters.Add("@Senha", SqlDbType.VarChar).Value = senha;

				sqlConn.Open();

				try
				{
					ID_USUARIO = (int)cmd.ExecuteScalar();

					if (ID_USUARIO != 0)
					{
						Hide();
						ini = new Inicio();
						ini.ShowDialog();
					}
				}
				catch
				{
					txtLogin.Text = "";
					txtSenha.Text = "";
					MessageBox.Show("Usuário ou senha inválido!");
				}
   			}
			catch (SqlException ex)
			{
				MessageBox.Show(ex.Message);

				txtLogin.Text = "";
				txtSenha.Text = "";
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			logar();
		}

		private void label7_Click(object sender, EventArgs e)
		{
			txtSenha1.Text = "";
			txtNome.Text = "";
			txtConf1.Text = "";
			txtEmail.Text = "";

			lblCad.Visible = true;
			lblBox.Visible = true;
			lblNome.Visible = true;
			lblConf1.Visible = true;
			lblEmail.Visible = true;
			lblSenha1.Visible = true;
			txtNome.Visible = true;
			txtConf1.Visible = true;
			txtEmail.Visible = true;
			txtSenha1.Visible = true;
			btnCad.Visible = true;
			btnCan1.Visible = true;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			txtSenha1.Text = "";
			txtNome.Text = "";
			txtConf1.Text = "";
            txtEmail.Text = "";
		}

		private void btnCan_Click(object sender, EventArgs e)
		{
			txtSenha1.Text = "";
			txtNome.Text = "";
			txtConf1.Text = "";
			txtEmail.Text = "";
		}

		private void btnCan1_Click(object sender, EventArgs e)
		{
			txtSenha1.Text = "";
			txtNome.Text = "";
			txtConf1.Text = "";
			txtEmail.Text = "";

			lblBox.Visible = false;
			lblNome.Visible = false;
			lblConf1.Visible = false;
			lblEmail.Visible = false;
			lblSenha1.Visible = false;
			txtNome.Visible = false;
			txtConf1.Visible = false;
			txtEmail.Visible = false;
			txtSenha1.Visible = false;
			btnCad.Visible = false;
			btnCan1.Visible = false;
		}

		private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((Keys)e.KeyChar == Keys.Enter)
			{
				logar();
			}
		}
        
		private void btnCad_Click(object sender, EventArgs e)
		{
			if (txtNome.Text != "" & txtEmail.Text != "")
			{
				if (txtSenha1.Text == txtConf1.Text & txtSenha1.Text != "" & txtConf1.Text != "")
				{
					SqlConnection Sql = new SqlConnection("Data Source=L05M01;Initial Catalog=EconomicImperium;Integrated Security=True");
					SqlCommand cmmd = new SqlCommand("insert into Usuario(Nome,Login,Senha) values (@Nome,@Login,@Senha)", Sql);

					cmmd.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txtNome.Text;
					cmmd.Parameters.Add("@Login", SqlDbType.VarChar).Value = txtEmail.Text;
					cmmd.Parameters.Add("@Senha", SqlDbType.VarChar).Value = txtSenha1.Text;

					try
					{

						Sql.Open();
						cmmd.ExecuteNonQuery();

							MessageBox.Show("Perfeito!", "Login", MessageBoxButtons.OK);

							txtSenha1.Text = "";
							txtNome.Text = "";
							txtConf1.Text = "";
							txtEmail.Text = "";
				    }

					catch (Exception ex)
					{
						MessageBox.Show(ex.Message);
						txtSenha1.Text = "";
						txtNome.Text = "";
						txtConf1.Text = "";
						txtEmail.Text = "";
					}

					finally
					{
						Sql.Close();
					}
				}

				else
				{
					MessageBox.Show("Opa, algo deu errado parceiro!", "Login", MessageBoxButtons.OK);
				}

				lblBox.Visible = false;
				lblNome.Visible = false;
				lblConf1.Visible = false;
				lblEmail.Visible = false;
				lblSenha1.Visible = false;
				txtNome.Visible = false;
				txtConf1.Visible = false;
				txtEmail.Visible = false;
				txtSenha1.Visible = false;
				btnCad.Visible = false;
				btnCan1.Visible = false;
			}

		}
	}
}