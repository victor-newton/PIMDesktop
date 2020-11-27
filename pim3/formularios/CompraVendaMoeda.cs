using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pim3.formularios
{
    public partial class Frm_CompraVendaMoeda : Form
    {
        public Frm_CompraVendaMoeda()
        {
            InitializeComponent();
        }

        private void Frm_CompraVendaMoeda_Shown(object sender, EventArgs e)
        {
            CB_Moeda.DropDownStyle = ComboBoxStyle.DropDownList;
            CB_Moeda.DataSource = SQLFunctions.GetInfos("SELECT * FROM MOEDAS");
            CB_Moeda.ValueMember = "IDMOEDA";
            CB_Moeda.DisplayMember = "NOMEMOEDA";
            CB_Moeda.Update();
            Group_Detalhes.Visible = false;
            System.Data.SqlClient.SqlConnection SqlCon = new System.Data.SqlClient.SqlConnection(Variaveis.conexao);
            historicoTableAdapter.Adapter.SelectCommand = new System.Data.SqlClient.SqlCommand("SELECT DATAHORA, VALOR FROM HISTORICO where idmoeda = " + Convert.ToString(CB_Moeda.SelectedValue), SqlCon);
        }

        private void CB_Moeda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_Moeda.ValueMember.Length > 0)
            {
                Group_Detalhes.Visible = true;
                DataTable dados_moeda = SQLFunctions.GetInfos("SELECT * FROM MOEDAS WHERE IDMOEDA = " + Convert.ToString(CB_Moeda.SelectedValue));
                Edt_ValorAtual.Text = dados_moeda.Rows[0]["VALORMERCADO"].ToString();
                DataTable dados_detalhes_total = SQLFunctions.GetInfos("SELECT top(1) NroCarteira, IDMoeda, Quantidade, IDUsuario FROM CARTEIRA " +
                                                                     "WHERE IDUSUARIO = " + Session.Instance.UserID + " and IDMOEDA = "+ Convert.ToString(CB_Moeda.SelectedValue));
                DataTable dados_detalhes_ult = SQLFunctions.GetInfos("SELECT top(1) QUANTOPERADA, VALOROPERACAO, OPERACAO FROM OPERACAO " +
                        "WHERE IDUSUARIO = " + Session.Instance.UserID + " AND IDMOEDA = " + Convert.ToString(CB_Moeda.SelectedValue) + " ORDER BY DATAHORA DESC ");
                if (dados_detalhes_total.Rows.Count <= 0 || dados_detalhes_ult.Rows.Count <= 0)
                {
                    Edt_QtdObtida.Text = "Nenhuma operação localizada";
                    Edt_VlrObtido.Text = "Nenhuma operação localizada";
                    Edt_QtdUltCompra.Text = "Nenhuma operação localizada";
                    Edt_VlrUltCompra.Text = "Nenhuma operação localizada";
                    Edt_UltTransacao.Text = "Nenhuma";
                }
                else
                {
                    Edt_QtdObtida.Text = dados_detalhes_total.Rows[0]["QUANTIDADE"].ToString();
                    double valor_mercado = (Convert.ToDouble(Edt_ValorAtual.Text) * Convert.ToDouble(dados_detalhes_total.Rows[0]["QUANTIDADE"].ToString()));
                    Edt_VlrObtido.Text = valor_mercado.ToString();
                    Edt_QtdUltCompra.Text = dados_detalhes_ult.Rows[0]["QUANTOPERADA"].ToString();
                    Edt_VlrUltCompra.Text = dados_detalhes_ult.Rows[0]["VALOROPERACAO"].ToString();
                    Edt_UltTransacao.Text = dados_detalhes_ult.Rows[0]["OPERACAO"].ToString();
                }
            }
        }

        private void Btn_Comprar_Click(object sender, EventArgs e)
        {
            if (CB_Moeda.Text == "")
            {
                MessageBox.Show("Seleciona a moeda que deseja operar!");
            }
            else if (Edt_VlrNegociar.Text == "")
            {
                MessageBox.Show("Selecione o valor que deseja operar!");
            }
            else
            {
                double quant_obtida = (Convert.ToDouble(Edt_VlrNegociar.Text) / (Convert.ToDouble(Edt_ValorAtual.Text)));
                if (MessageBox.Show("Deseja gastar R$"+ Edt_VlrNegociar.Text +" para adquirir "+Convert.ToString(quant_obtida)+ " " +CB_Moeda.Text, 
                    "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Operacao:
                    DataTable pega_carteira = SQLFunctions.GetInfos("SELECT NROCARTEIRA, QUANTIDADE FROM CARTEIRA WHERE IDUSUARIO = "+ 
                                                                    Session.Instance.UserID + " AND IDMOEDA = " + Convert.ToString(CB_Moeda.SelectedValue));
                    if (pega_carteira.Rows.Count < 1)
                    {
                        SQLFunctions.ExecutaComando("INSERT INTO CARTEIRA (IDMOEDA,IDUSUARIO,QUANTIDADE) " +
                            "VALUES(" + Convert.ToString(CB_Moeda.SelectedValue) + ", " + Session.Instance.UserID + ", 0)");
                        goto Operacao;
                    }
                    string carteira = pega_carteira.Rows[0]["NROCARTEIRA"].ToString();
                    string comando = "INSERT INTO Operacao(ValorOperacao, DataHora, IDMoeda, NroCarteira, IDUsuario, Operacao, QuantOperada)"+
                                     "VALUES ("+ Edt_VlrNegociar.Text+",'"+Funcoes.FormataDataAmericana(DateTime.Now)+"',"+ Convert.ToString(CB_Moeda.SelectedValue) +", "+carteira+", "+
                                     Session.Instance.UserID+", 'COMPRA',"+Convert.ToString(quant_obtida)+")";
                    int i = SQLFunctions.ExecutaComando(comando);
                    if (i == 1)
                    {
                        MessageBox.Show("Ocorreu um erro ao processar a requisição!! \n Aguarde e tente novamente!!");
                    }
                    else
                    {
                        double quantidade = Convert.ToDouble(pega_carteira.Rows[0]["QUANTIDADE"].ToString());
                        quant_obtida = quantidade + quant_obtida;
                        SQLFunctions.ExecutaComando("UPDATE CARTEIRA SET QUANTIDADE = " + quant_obtida.ToString() +
                                                    "WHERE NROCARTEIRA = "+carteira);
                        MessageBox.Show("Transação realizada!");
                        CB_Moeda.Text = "";
                        Edt_VlrNegociar.Text = "";
                        Group_Detalhes.Visible = false;
                    }
                }
            }
        }

        private void Btn_Vender_Click(object sender, EventArgs e)
        {
            if (CB_Moeda.Text == "")
            {
                MessageBox.Show("Seleciona a moeda que deseja operar!");
            }
            else if (Edt_VlrNegociar.Text == "")
            {
                MessageBox.Show("Selecione o valor que deseja operar!");
            }
            double quant_obtida = (Convert.ToDouble(Edt_VlrNegociar.Text) / (Convert.ToDouble(Edt_ValorAtual.Text)));
            if (MessageBox.Show("Deseja vender " + Convert.ToString(quant_obtida) +" "+ CB_Moeda.Text + " para obter R$ " + Edt_VlrNegociar.Text,
                "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
            Operacao:
                DataTable pega_carteira = SQLFunctions.GetInfos("SELECT NROCARTEIRA, QUANTIDADE FROM CARTEIRA WHERE IDUSUARIO = " +
                                                                Session.Instance.UserID + " AND IDMOEDA = " + Convert.ToString(CB_Moeda.SelectedValue));
                if (pega_carteira.Rows.Count < 1)
                {
                    SQLFunctions.ExecutaComando("INSERT INTO CARTEIRA (IDMOEDA,IDUSUARIO,QUANTIDADE) " +
                        "VALUES(" + Convert.ToString(CB_Moeda.SelectedValue) + ", " + Session.Instance.UserID + ", 0)");
                    goto Operacao;
                }
                string carteira = pega_carteira.Rows[0]["NROCARTEIRA"].ToString();
                double quantidade = Convert.ToDouble(pega_carteira.Rows[0]["QUANTIDADE"].ToString());
                if (quantidade < quant_obtida)
                {
                    MessageBox.Show("Não é possivel vender! \n Valor a ser negociado maior que saldo disponivel");
                }
                else
                {
                    string comando = "INSERT INTO Operacao(ValorOperacao, DataHora, IDMoeda, NroCarteira, IDUsuario, Operacao, QuantOperada)" +
                                     "VALUES (" + Edt_VlrNegociar.Text + ",'" + Funcoes.FormataDataAmericana(DateTime.Now) + "'," + Convert.ToString(CB_Moeda.SelectedValue) + ", " + carteira + ", " +
                                     Session.Instance.UserID + ", 'VENDA'," + Convert.ToString(quant_obtida) + ")";
                    int i = SQLFunctions.ExecutaComando(comando);
                    if (i == 1)
                    {
                        MessageBox.Show("Ocorreu um erro ao processar a requisição!! \n Aguarde e tente novamente!!");
                    }
                    else
                    {

                        quant_obtida = quantidade - quant_obtida;
                        SQLFunctions.ExecutaComando("UPDATE CARTEIRA SET QUANTIDADE = " + quant_obtida.ToString() +
                                                    "WHERE NROCARTEIRA = " + carteira);
                        MessageBox.Show("Transação realizada!");
                        CB_Moeda.Text = "";
                        Edt_VlrNegociar.Text = "";
                        Group_Detalhes.Visible = false;
                    }
                }
            }
        }

        private void Frm_CompraVendaMoeda_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'uniCriptDataSet.Historico'. Você pode movê-la ou removê-la conforme necessário.
            this.historicoTableAdapter.Fill(this.uniCriptDataSet.Historico);

        }
    }
}
