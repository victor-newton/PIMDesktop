using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace pim3
{
    public partial class Frm_Funcionarios : Form
    {
        public void Habilita(Boolean VF)
        {
            Lbl_Cod.Enabled         = VF;
            Lbl_CPF.Enabled         = VF;
            Lbl_Nome.Enabled        = VF;
            Lbl_Setor.Enabled       = VF;
            Lbl_Cargo.Enabled       = VF;
            Lbl_Logradouro.Enabled  = VF;
            Lbl_Complemento.Enabled = VF;
            Lbl_Num.Enabled         = VF;
            Lbl_DTAdmissao.Enabled  = VF;
            Lbl_Email.Enabled       = VF;
            Lbl_Contato.Enabled     = VF;
            Lbl_NumTel.Enabled      = VF;
            Lbl_UF.Enabled          = VF;
            Lbl_CEP.Enabled         = VF;
            Lbl_Cidade.Enabled      = VF;
            Lbl_Bairro.Enabled      = VF;
            Lbl_Tipo.Enabled        = VF;
            Edt_CPF.Enabled         = VF;
            Edt_Nome.Enabled        = VF;
            Edt_Setor.Enabled       = VF;
            Edt_Cargo.Enabled       = VF;
            Edt_Logradouro.Enabled  = VF;
            Edt_Complemento.Enabled = VF;
            Edt_Num.Enabled         = VF;
            Edt_DTAdmissao.Enabled  = VF;
            Edt_Email.Enabled       = VF;
            Edt_Contato.Enabled     = VF;
            Edt_NumTel.Enabled      = VF;
            Edt_UF.Enabled          = VF;
            Edt_CEP.Enabled         = VF;
            Edt_Cidade.Enabled      = VF;
            Edt_Bairro.Enabled      = VF;
            Edt_Tipo.Enabled        = VF;
        }

        public void LimpaCampos()
        {
            Edt_CPF.Text         = "";
            Edt_Nome.Text        = "";
            Edt_Setor.Text       = "";
            Edt_Cargo.Text       = "";
            Edt_Logradouro.Text  = "";
            Edt_Complemento.Text = "";
            Edt_Num.Text         = "";
            Edt_DTAdmissao.Text  = "";
            Edt_Email.Text       = "";
            Edt_Contato.Text     = "";
            Edt_NumTel.Text      = "";
            Edt_UF.Text          = "";
            Edt_CEP.Text         = "";
            Edt_Cidade.Text      = "";
            Edt_Bairro.Text      = "";
            Edt_Tipo.Text        = "";
        }
        public Frm_Funcionarios()
        {
            InitializeComponent();
        }

        private void Frm_Funcionarios_Shown(object sender, EventArgs e)
        {
            Btn_Novo.Focus();
        }

        private void Btn_Cancela_Click(object sender, EventArgs e)
        {
            Habilita(VF: false);
            Btn_Novo.Enabled     = true;
            Btn_Altera.Enabled   = false;
            Btn_Consulta.Enabled = true;
            Btn_Salva.Enabled    = false;
            Btn_Cancela.Enabled  = false;
            Btn_Novo.Focus();
        }

        private void Btn_Novo_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            Habilita(VF: true);
            Btn_Novo.Enabled = false;
            Btn_Altera.Enabled = false;
            Btn_Consulta.Enabled = false;
            Btn_Salva.Enabled = true;
            Btn_Cancela.Enabled = true;
            Edt_CPF.Focus();
            Edt_DTAdmissao.Value = DateTime.Today;
        }

        private void Btn_Salva_Click(object sender, EventArgs e)
        {
            if(Edt_CPF.Text == "") //Verifica se os dados estão preenchidos
            {
                MessageBox.Show("Preencha o CPF!");
            }
            else if(Edt_Nome.Text == "")//Verifica se os dados estão preenchidos
            {
                MessageBox.Show("Preencha o nome!");
            }
            else
            {
                if (Edt_Cod.Text == "")
                {
                    #region Cadastra_Funcionario
                    //Cria o comando SQL para ser executado
                    string CadFun = "INSERT INTO FUNCIONARIOS (CPF, Nome, DataAdmissao, DataDemissao, Email) " +
                        "values ('" + Edt_CPF.Text + "','" + Edt_Nome.Text + "','" + Funcoes.FormataDataAmericana(Edt_DTAdmissao.Value) + "','"
                        + Funcoes.FormataDataAmericana(Edt_DTDemissao.Value) + "','" + Edt_Email.Text + "')";

                    SqlConnection con = new SqlConnection(Variaveis.conexao); //Cria a variavel de conexão
                    SqlCommand CmdCadFun = new SqlCommand(CadFun, con); //Cria o comando SQL juntando o comando com a conexao
                    CmdCadFun.CommandType = CommandType.Text; //Define o tipo de comando a ser executado
                    con.Open(); //Abre a conexão

                    try
                    {
                        int i = CmdCadFun.ExecuteNonQuery(); //Guarda no I o retorno da execução do comando sql
                        con.Close();
                        if (i > 0) //se o retorno for maior que um significa que deu certo
                        {
                            #region busca_ID_Funcionario 

                            SqlCommand cmd = new SqlCommand("SELECT top(1) IDFuncionario FROM Funcionarios" + //Cria o comando SQL 
                                " order by IDFuncionario desc", con);
                            con.Open();                         //Abre a conexão com o banco de dados
                            SqlDataReader dr = cmd.ExecuteReader(); //Executa o comando sql para fazer a select de dados
                            dr.Read();                          //le o retorno da select
                            string idfun = dr["IDFuncionario"].ToString();     //pega o que esta na coluna ativo
                            con.Close();

                            #endregion busca_ID_Funcionario

                            #region Cadastra_Telefone

                            SqlCommand CMDCadTel = new SqlCommand("INSERT INTO TELEFONES (CLIFUN, IDCLIFUN, CONTATO, NUMEROTELEFONE, TIPOTELEFONE)" +
                                "VALUES ('F'," + idfun + ",'" + Edt_Contato.Text + "', '" + Edt_NumTel.Text + "','" + Edt_Tipo.Text + "')", con);
                            CMDCadTel.CommandType = CommandType.Text; //Define o tipo de comando a ser executado
                            con.Open(); //Abre a conexão
                            CMDCadTel.ExecuteNonQuery();
                            con.Close();

                            #endregion Cadastra_Telefone

                            #region Cadastra_Endereco

                            SqlCommand CMDCadEnd = new SqlCommand("INSERT INTO ENDERECOS (CliFun, IDCliFun, Logradouro, Complemento, CEP, Numero, UF, Bairro, Cidade)" +
                                "Values ('F'," + idfun + ",'" + Edt_Logradouro.Text + "','" + Edt_Complemento.Text + "','" + Edt_CEP.Text + "'," + Edt_Num.Text + ",'" + Edt_UF.Text +
                                "','" + Edt_Bairro.Text + "','" + Edt_Cidade.Text + "')", con);
                            CMDCadEnd.CommandType = CommandType.Text;
                            con.Open();
                            CMDCadEnd.ExecuteNonQuery();
                            con.Close();

                            #endregion Cadastra_Endereco

                            Habilita(VF: false);
                            Btn_Novo.Enabled = true;
                            Btn_Altera.Enabled = false;
                            Btn_Consulta.Enabled = true;
                            Btn_Salva.Enabled = false;
                            Btn_Cancela.Enabled = false;
                            Btn_Novo.Focus();
                        }
                    }
                    catch (Exception ex) //Caso retorne algum erro
                    {
                        MessageBox.Show("Erro: " + ex.ToString()); //Exibe o erro retornado
                    }
                    finally
                    {
                        con.Close(); //Fecha a conexão
                    }
                    #endregion Cadastra_Funcionario
                }
                else
                {
                    string comando = "UPDATE FUNCIONARIOS SET CPF = '" + Edt_CPF.Text + "', Nome = '" + Edt_Nome.Text + "', DataAdmissao = '" + Funcoes.FormataDataAmericana(Edt_DTAdmissao.Value) +
                        "', DataDemissao = '" + Funcoes.FormataDataAmericana(Edt_DTDemissao.Value) + "', Email = '" + Edt_Email.Text + "' WHERE IDFUNCIONARIO = " + Edt_Cod.Text;
                    int i = SQLFunctions.ExecutaComando(comando);
                    if (i > 0)
                    {
                        MessageBox.Show("Ocorreu um erro ao salvar!");
                    }
                    comando = "UPDATE TELEFONES SET CONTATO = '"+ Edt_Contato.Text +"', NUMEROTELEFONE = '"+ Edt_NumTel.Text +"', TIPOTELEFONE = '"+ Edt_Tipo.Text +"' "+
                        "WHERE CLIFUN = 'F' AND IDCLIFUN = "+ Edt_Cod.Text;
                    i = SQLFunctions.ExecutaComando(comando);
                    if (i > 0)
                    {
                        MessageBox.Show("Ocorreu um erro ao salvar!");
                    }
                    comando = "UPDATE ENDERECOS SET Logradouro = '"+ Edt_Logradouro.Text +"', Complemento = '"+ Edt_Complemento.Text +"', CEP = '"+ Edt_CEP.Text +"', "+
                        "Numero = "+ Edt_Num.Text +", UF = '"+ Edt_UF.Text +"', Bairro = '"+ Edt_Bairro.Text +"', Cidade ='"+ Edt_Cidade.Text +"' "+
                        "WHERE CliFun = 'F' AND IDCliFun = "+ Edt_Cod.Text;
                    i = SQLFunctions.ExecutaComando(comando);
                    if (i > 0)
                    {
                        MessageBox.Show("Ocorreu um erro ao salvar!");
                    }
                }
                Habilita(VF: false);
                Btn_Novo.Enabled = true;
                Btn_Altera.Enabled = false;
                Btn_Consulta.Enabled = true;
                Btn_Salva.Enabled = false;
                Btn_Cancela.Enabled = false;
                Btn_Novo.Focus();
            }
        }

        private void Btn_Consulta_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            Edt_NomeConsulta.Text  = "";
            Edt_CPFConsulta.Text   = "";
            Edt_SetorConsulta.Text = "";
            dataGridView1.Columns.Clear();
        }

        private void Btn_Consultar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetInfos();
        }
        
        private DataTable GetInfos()
        {
            string consulta = "SELECT F.*, E.*, T.*                                                      " +
                              "from Funcionarios F                                                       " +
                              "left join Enderecos E on E.IDCliFun = F.IDFuncionario and E.CliFun = 'F'  " +
                              "left join Telefones T on T.IDCliFun = F.IDFuncionario and T.CliFun = 'F'  " +
                              "where 1 = 1                                                               " ;

            if (Edt_NomeConsulta.Text != "")
            {
                consulta = consulta + "and Nome like '" + Edt_NomeConsulta.Text + "%'";
            }
            if (Edt_CPFConsulta.Text != "")
            {
                consulta = consulta + "and CPF like '" + Edt_CPFConsulta.Text + "%'";
            }
            if (Edt_SetorConsulta.Text != "")
            {
                consulta = consulta + "and Setor like '" + Edt_Setor.Text + "%'";
            }

            DataTable Funcionarios = new DataTable();

            SqlConnection sqlConn = new SqlConnection(Variaveis.conexao);
            SqlCommand cmd = new SqlCommand(consulta, sqlConn); //Cria o comando SQL
            sqlConn.Open();
            SqlDataReader reader = cmd.ExecuteReader(); //Executa o comando sql para fazer a select de dados
            Funcionarios.Load(reader);

            return Funcionarios;
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
            Edt_Cod.Text         = Convert.ToString(this.dataGridView1.CurrentRow.Cells["IDFUncionario"].Value);
            Edt_CPF.Text         = Convert.ToString(this.dataGridView1.CurrentRow.Cells["CPF"].Value);
            Edt_DTAdmissao.Text  = Convert.ToString(this.dataGridView1.CurrentRow.Cells["DataAdmissao"].Value);
            Edt_Email.Text       = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Email"].Value);
            Edt_Nome.Text        = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Nome"].Value);
            Edt_Setor.Text       = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Setor"].Value);
            Edt_Cargo.Text       = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Cargo"].Value);
            Edt_Logradouro.Text  = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Logradouro"].Value);
            Edt_Complemento.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Complemento"].Value);
            Edt_Cidade.Text      = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Cidade"].Value);
            Edt_UF.Text          = Convert.ToString(this.dataGridView1.CurrentRow.Cells["UF"].Value);
            Edt_CEP.Text         = Convert.ToString(this.dataGridView1.CurrentRow.Cells["CEP"].Value);
            Edt_Bairro.Text      = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Bairro"].Value);
            Edt_Num.Text         = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Numero"].Value);
            Edt_Tipo.Text        = Convert.ToString(this.dataGridView1.CurrentRow.Cells["TipoTelefone"].Value);
            Edt_NumTel.Text      = Convert.ToString(this.dataGridView1.CurrentRow.Cells["NumeroTelefone"].Value);
            Edt_Contato.Text     = Convert.ToString(this.dataGridView1.CurrentRow.Cells["Contato"].Value);
            Edt_DTDemissao.Text  = Convert.ToString(this.dataGridView1.CurrentRow.Cells["DataDemissao"].Value);
            Btn_Altera.Enabled = true;
        }

        private void Btn_Altera_Click(object sender, EventArgs e)
        {
            if (Edt_Cod.Text == "")
            {
                MessageBox.Show("Não existem registros para serem alterados!");
            }
            else
            {
                Habilita(VF: true);
                Btn_Novo.Enabled     = false;
                Btn_Altera.Enabled   = false;
                Btn_Consulta.Enabled = false;
                Btn_Salva.Enabled    = true;
                Btn_Cancela.Enabled  = true;
            }
        }
    }
}
