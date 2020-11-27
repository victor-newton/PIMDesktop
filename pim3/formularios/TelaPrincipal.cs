using pim3.formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;

namespace pim3
{
    public partial class Frm_TelaPrincipal : Form
    {
        public Frm_TelaPrincipal()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new Frm_Cliente();
            form.Show();
        }

        private void setorCargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Frm_SetorCargo();
            form.Show();
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Frm_Funcionarios();
            form.Show();
        }

        private void moedasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Frm_Moedas();
            form.Show();
        }

        private void comprarVenderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Frm_CompraVendaMoeda();
            form.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            timer1.Enabled = false;
            DataTable moedas = SQLFunctions.GetInfos("SELECT IDMOEDA, ABREVIACAO FROM MOEDAS " +
                "WHERE ABREVIACAO IN ( 'BCH', 'BTC', 'CHZ','ETH','IMOB01','LTC','MBCONS01','MBCONS02','MBFP01','MBPRK01','MBPRK02','MBPRK03','MBPRK04','PAXG','USDC','WBX','XRP')");
            int i = 0;
            while (i < moedas.Rows.Count)
            {
                string abreviacao = moedas.Rows[i]["ABREVIACAO"].ToString();
                abreviacao = abreviacao.TrimEnd();
                string jsonString = new WebClient().DownloadString("https://www.mercadobitcoin.net/api/"+abreviacao+"/ticker/");
                string valor = jsonString.Remove(0, jsonString.IndexOf("last") + 7);
                valor = valor.Remove(valor.IndexOf("buy") - 3, valor.IndexOf("date") + 4);
                SQLFunctions.ExecutaComando("UPDATE MOEDAS SET VALORMERCADO = "+valor+" WHERE IDMOEDA = "+ moedas.Rows[i]["IDMOEDA"].ToString());
                SQLFunctions.ExecutaComando("INSERT INTO HISTORICO(IDMOEDA, DATAHORA, VALOR) " +
                    "VALUES (" + moedas.Rows[i]["IDMOEDA"].ToString() + ", '" + Funcoes.FormataDataAmericana(DateTime.Now) + "', " + valor + ")");
                i = i + 1;
            }
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            this.Enabled = false;
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Frm_CadLoginFuncionario();
            form.Show();
        }
    }
}
