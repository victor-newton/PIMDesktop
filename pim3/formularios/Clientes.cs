using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pim3
{
    public partial class Frm_Cliente : Form
    {

        public void Habilita(Boolean VF)
        {
            Lbl_Cod.Enabled         = VF;
            Lbl_CPFCNPJ.Enabled     = VF;
            Lbl_Razao.Enabled       = VF;
            Lbl_Fantasia.Enabled    = VF;
            Lbl_Logradouro.Enabled  = VF;
            Lbl_Complemento.Enabled = VF;
            Lbl_Num.Enabled         = VF;
            Lbl_Email.Enabled       = VF;
            Lbl_Contato.Enabled     = VF;
            Lbl_NumTel.Enabled      = VF;
            Lbl_UF.Enabled          = VF;
            Lbl_CEP.Enabled         = VF;
            Lbl_Cidade.Enabled      = VF;
            Lbl_Bairro.Enabled      = VF;
            Lbl_TIpo.Enabled        = VF;
            Lbl_IE.Enabled          = VF;
            Lbl_FJ.Enabled          = VF;
            Edt_CPFCNPJ.Enabled     = VF;
            Edt_Razao.Enabled       = VF;
            Edt_Fantasia.Enabled    = VF;
            Edt_Logradouro.Enabled  = VF;
            Edt_Complemento.Enabled = VF;
            Edt_Num.Enabled         = VF;
            Edt_Email.Enabled       = VF;
            Edt_Contato.Enabled     = VF;
            Edt_NumTel.Enabled      = VF;
            Edt_UF.Enabled          = VF;
            Edt_CEP.Enabled         = VF;
            Edt_Cidade.Enabled      = VF;
            Edt_Bairro.Enabled      = VF;
            Edt_Tipo.Enabled        = VF;
            Edt_IE.Enabled          = VF;
            Edt_Ativo.Enabled       = VF;
            Edt_FJ.Enabled          = VF;
        }

        public Frm_Cliente()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Habilita(VF: true);
            Btn_Novo.Enabled      = false;
            Btn_Alterar.Enabled   = false;
            Btn_Consultar.Enabled = false;
            Btn_Salvar.Enabled    = true;
            Btn_Cancelar.Enabled  = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Cliente_Shown(object sender, EventArgs e)
        {
            Btn_Novo.Focus();
        }
    }
}
