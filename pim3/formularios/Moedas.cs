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
    public partial class Frm_Moedas : Form
    {
        public Frm_Moedas()
        {
            InitializeComponent();
        }

        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            Edt_Abrevicao.Text = "";
            Edt_Descricao.Text = "";
        }

        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
            if (Edt_Abrevicao.Text == "")
            {
                MessageBox.Show("Preencha a abreviação!");
            }
            else if (Edt_Descricao.Text == "")
            {
                MessageBox.Show("Preencha a Descrição!");
            }
            else
            {
                string comando = "Insert into Moedas (NomeMoeda, Abreviacao, ValorMercado) "+
                    "Values ('" + Edt_Descricao.Text + "', '" + Edt_Abrevicao.Text + "', 0)";
                int i = SQLFunctions.ExecutaComando(comando);
                if (i > 0)
                {
                    MessageBox.Show("Ocorreu um erro ao salvar!");
                }
                Grd_Moedas.DataSource = SQLFunctions.GetInfos("select * from moedas");
            }
        }

        private void Frm_Moedas_Shown(object sender, EventArgs e)
        {
            Grd_Moedas.DataSource = SQLFunctions.GetInfos("select * from moedas");
        }
    }
}
