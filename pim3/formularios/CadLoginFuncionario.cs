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

namespace pim3.formularios
{
    public partial class Frm_CadLoginFuncionario : Form
    {
        public void Habilita(Boolean VF)
        {
            lbl_IDLogin.Enabled = false;
            Edt_IDLogin.Enabled = false;

            lbl_Cargo.Enabled = VF;
            lbl_IDFuncionario.Enabled = VF;
            lbl_Login.Enabled = VF;
            lbl_Senha.Enabled = VF;
            Edt_IDFuncionario.Enabled = VF;
            Edt_Login.Enabled = VF;
            Edt_Ativo.Enabled = VF;
            Edt_Nivel.Enabled = VF;
            Edt_Senha.Enabled = VF;

        }
        public Frm_CadLoginFuncionario()
        {
            InitializeComponent();
            Habilita(VF: false);
        }

        private void Edt_Senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Novo_Click(object sender, EventArgs e)
        {
            Habilita(VF: true);
            Btn_Novo.Enabled = false;
            Btn_Alterar.Enabled = false;
            Btn_Salvar.Enabled = true;
            Btn_Cancelar.Enabled = true;
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Habilita(VF: false);
            Btn_Novo.Enabled = true;
            Btn_Alterar.Enabled = false;
            Btn_Salvar.Enabled = false;
            Btn_Cancelar.Enabled = false;
            Btn_Novo.Focus();
        }

        private void Btn_Alterar_Click(object sender, EventArgs e)
        {
            Habilita(VF: true);
            Btn_Novo.Enabled = false;
            Btn_Alterar.Enabled = false;
            Btn_Salvar.Enabled = true;
            Btn_Cancelar.Enabled = true;
        }

        private void Btn_Salvar_Click(object sender, EventArgs e)
        {

            if (Edt_Login.Text == "")
            {
                MessageBox.Show("Preencha todos os dados!");
            }
            else if (Edt_Senha.Text == "")
            {
                MessageBox.Show("Preencha todos os dados!");
            }
            else if(Edt_Nivel.Text == "")
            {
                MessageBox.Show("Preencha todos os dados!");
            }
            else
            {
                if (Edt_IDLogin.Text == "")
                {
                    string val_ativo;

                    if (Edt_Ativo.Checked == true)
                    {
                        val_ativo = "S";
                    }
                    else
                    {
                        val_ativo = "N";
                    }


                    string Comando = "INSERT INTO Usuarios (Login, Senha, NivelDeAcesso, Ativo) " +
                        "values ('" + Edt_Login.Text + "','" + Edt_Senha.Text + "','" +Edt_Nivel.Text + "','" + val_ativo + "')";
                    int i = SQLFunctions.ExecutaComando(Comando);
                    if (i > 0)
                    {
                        MessageBox.Show("Ocorreu um erro ao salvar!");
                    }
                    try
                    {
                        SqlConnection con = new SqlConnection(Variaveis.conexao); //Cria a variavel de conexão
                        con.Open(); //Abre a conexão
                        {

                            Habilita(VF: false);
                            Btn_Novo.Enabled = true;
                            Btn_Alterar.Enabled = false;
                            Btn_Salvar.Enabled = false;
                            Btn_Cancelar.Enabled = false;
                            Btn_Novo.Focus();
                        }

                    }
                    catch (Exception ex) //Caso retorne algum erro
                    {
                        MessageBox.Show("Erro: " + ex.ToString()); //Exibe o erro retornado
                    }
                    finally
                    {
                        SqlConnection con = new SqlConnection(Variaveis.conexao); //Cria a variavel de conexão
                        con.Close(); //Fecha a conexão
                    }
                }
                else
                {
                    string val_ativo;

                    if (Edt_Ativo.Checked == true)
                    {
                        val_ativo = "S";
                    }
                    else
                    {
                        val_ativo = "N";
                    }

                    string comando = "UPDATE Usuarios SET IDFuncionario = '" + Edt_IDFuncionario.Text + "', Login = '" + Edt_Login.Text + "', Senha = '" + Edt_Senha.Text +
                        "', NivelDeAcesso = '" + Edt_Nivel.Text + "', Ativo = '" + val_ativo + "' WHERE Login = '" + Edt_Login.Text +"'";
                    int i = SQLFunctions.ExecutaComando(comando);
                    if (i > 0)
                    {
                        MessageBox.Show("Ocorreu um erro ao salvar!");
                    }
                    Habilita(VF: false);
                    Btn_Novo.Enabled = true;
                    Btn_Alterar.Enabled = false;
                    Btn_Salvar.Enabled = false;
                    Btn_Cancelar.Enabled = false;
                    Btn_Novo.Focus();
                }
            }
        }

        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            Edt_ConsultaLogin.Text = "";


            dataGridView1.Columns.Clear();
        }

        private void Btn_Consultar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetInfos();
        }

        private DataTable GetInfos()
        {
            string consulta = "SELECT IDLogin, Login, Ativo, IDFuncionario, NivelDeAcesso FROM USUARIOS WHERE Login =" + "'" + Edt_ConsultaLogin.Text +"'";

            DataTable LoginFuncionario = new DataTable();

            SqlConnection sqlConn = new SqlConnection(Variaveis.conexao);
            SqlCommand cmd = new SqlCommand(consulta, sqlConn); //Cria o comando SQL
            sqlConn.Open();
            SqlDataReader reader = cmd.ExecuteReader(); //Executa o comando sql para fazer a select de dados
            LoginFuncionario.Load(reader);

            return LoginFuncionario;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
            Edt_IDFuncionario.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["IDFuncionario"].Value);
            Edt_Nivel.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["NivelDeAcesso"].Value);
            Edt_Login.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Login"].Value);
            Edt_IDLogin.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["IDLogin"].Value);

            Btn_Alterar.Enabled = true;
        }
    }
}
