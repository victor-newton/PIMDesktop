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

namespace pim3.formularios
{
    public partial class Frm_SetorCargo : Form
    {
        private class Consultas
        {
            public static string consultaSetor = "SELECT * FROM SETOR";
            public static string consultaCargo = "SELECT * FROM CARGOS WHERE IDSETOR = ";
        }

        public Frm_SetorCargo()
        {
            InitializeComponent();
        }

        private void Frm_SetorCargo_Shown(object sender, EventArgs e)
        {
            Grid_Setor.DataSource = SQLFunctions.GetInfos(Consultas.consultaSetor);
        }

        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
            if (Edt_Setor.Text == "") {
                MessageBox.Show("Preencha todos os dados!");
            }
            else {
                string Comando = "INSERT INTO SETOR(SETOR) VALUES('" + Edt_Setor.Text + "')";
                int i = SQLFunctions.ExecutaComando(Comando);
                if (i > 0)
                {
                    MessageBox.Show("Ocorreu um erro ao salvar!");
                }
                Grid_Setor.DataSource = SQLFunctions.GetInfos(Consultas.consultaSetor);
            }
        }

        private void Grid_Setor_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
            Edt_Setor2.Text  = Convert.ToString(this.Grid_Setor.CurrentRow.Cells["SETOR"].Value);
            Edt_IDSetor.Text = Convert.ToString(this.Grid_Setor.CurrentRow.Cells["IDSetor"].Value);
            Grid_Cargo.DataSource = SQLFunctions.GetInfos(Consultas.consultaCargo + Edt_IDSetor.Text);
        }

        private void Btn_SalvaCargo_Click(object sender, EventArgs e)
        {
            if (Edt_Setor.Text == "")
            {
                MessageBox.Show("Preencha todos os dados!");
            }
            else
            {
                string Comando = "INSERT INTO CARGOS(CARGO, IDSETOR) VALUES('" + Edt_Cargo.Text + "','" + Edt_IDSetor.Text + "')";
                int i = SQLFunctions.ExecutaComando(Comando);
                if (i > 0)
                {
                    MessageBox.Show("Ocorreu um erro ao salvar!");
                }
                Grid_Cargo.DataSource = SQLFunctions.GetInfos(Consultas.consultaCargo + Edt_IDSetor.Text);
            }
        }

        private void Btn_Deletar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja realmente excluir ? Essa operação não pode ser desfeita!!","Confirmação", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string comando = "delete from setor where idsetor = " + Convert.ToString(this.Grid_Setor.CurrentRow.Cells["IDSetor"].Value); ;
                SQLFunctions.ExecutaComando(comando);
                Grid_Setor.DataSource = SQLFunctions.GetInfos(Consultas.consultaSetor);
            }
        }

        private void Btn_ExcluiCargo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir ? Essa operação não pode ser desfeita!!", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string comando = "delete from setor where idcargo = " + Convert.ToString(this.Grid_Setor.CurrentRow.Cells["idcargo"].Value); ;
                SQLFunctions.ExecutaComando(comando);
                Grid_Cargo.DataSource = SQLFunctions.GetInfos(Consultas.consultaCargo + Edt_IDSetor.Text);
            }
        }
    }
}
