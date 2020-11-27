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

namespace pim3
{
    
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            if (Txt_Login.Text == "" || Txt_Senha.Text == "") //Verifica se os dados para login estão preenchidos
            {
                MessageBox.Show("Preencha os campos para logar!");
            }
            else
            {
                string ativo = "N"; 
                SqlConnection sqlConn = new SqlConnection(Variaveis.conexao); //Cria a conexão usando a variavel statica definida na classe variavel
                SqlCommand cmd = new SqlCommand("SELECT top(1) idlogin, login, senha, ativo FROM usuarios"+ //Cria o comando SQL 
                    " where upper(login) = upper('" + Txt_Login.Text + "') and senha = upper('" + Txt_Senha.Text + "')", sqlConn);
                sqlConn.Open();                         //Abre a conexão com o banco de dados
                SqlDataReader dr = cmd.ExecuteReader(); //Executa o comando sql para fazer a select de dados
                if (dr.HasRows)                         //verifica se a select retornou dados
                {
                    dr.Read();                          //le o retorno da select
                    ativo = dr["Ativo"].ToString();     //pega o que esta na coluna ativo
                    
                    if (ativo == "N")                   //se o usuario estiver inativo
                    {
                        MessageBox.Show("Usuario Inativo! \nContate seu supervisor!");
                    }
                    else
                    {
                        Session.Instance.UserID = dr["idlogin"].ToString();
                        var form = new Frm_TelaPrincipal(); //Cria o form principal
                        form.Show();                    //Exibe o form principal
                    }
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos, tente novamente!");
                }

            }
        }
    }
}
