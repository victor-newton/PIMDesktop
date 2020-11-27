namespace pim3
{
    partial class Frm_Funcionarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Funcionarios));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Edt_SetorConsulta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Edt_CPFConsulta = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.Edt_NomeConsulta = new System.Windows.Forms.TextBox();
            this.Btn_Limpar = new System.Windows.Forms.Button();
            this.Btn_Consultar = new System.Windows.Forms.Button();
            this.funcionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Salva = new System.Windows.Forms.Button();
            this.Btn_Cancela = new System.Windows.Forms.Button();
            this.Btn_Consulta = new System.Windows.Forms.Button();
            this.Btn_Altera = new System.Windows.Forms.Button();
            this.Btn_Novo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Edt_Complemento = new System.Windows.Forms.TextBox();
            this.Edt_UF = new System.Windows.Forms.TextBox();
            this.Lbl_UF = new System.Windows.Forms.Label();
            this.Edt_CEP = new System.Windows.Forms.TextBox();
            this.Lbl_CEP = new System.Windows.Forms.Label();
            this.Edt_Num = new System.Windows.Forms.TextBox();
            this.Lbl_Num = new System.Windows.Forms.Label();
            this.Lbl_Complemento = new System.Windows.Forms.Label();
            this.Edt_Bairro = new System.Windows.Forms.TextBox();
            this.Edt_Cidade = new System.Windows.Forms.TextBox();
            this.Edt_Logradouro = new System.Windows.Forms.TextBox();
            this.Lbl_Bairro = new System.Windows.Forms.Label();
            this.Lbl_Cidade = new System.Windows.Forms.Label();
            this.Lbl_Logradouro = new System.Windows.Forms.Label();
            this.Lbl_DTAdmissao = new System.Windows.Forms.Label();
            this.Edt_DTAdmissao = new System.Windows.Forms.DateTimePicker();
            this.Edt_CPF = new System.Windows.Forms.TextBox();
            this.Lbl_CPF = new System.Windows.Forms.Label();
            this.Edt_Cod = new System.Windows.Forms.TextBox();
            this.Lbl_Cod = new System.Windows.Forms.Label();
            this.setorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Edt_Email = new System.Windows.Forms.TextBox();
            this.Edt_Nome = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Edt_Contato = new System.Windows.Forms.TextBox();
            this.Lbl_Contato = new System.Windows.Forms.Label();
            this.Edt_NumTel = new System.Windows.Forms.TextBox();
            this.Lbl_NumTel = new System.Windows.Forms.Label();
            this.Edt_Tipo = new System.Windows.Forms.TextBox();
            this.Lbl_Tipo = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Edt_DTDemissao = new System.Windows.Forms.DateTimePicker();
            this.Lbl_Setor = new System.Windows.Forms.Label();
            this.Lbl_Email = new System.Windows.Forms.Label();
            this.Lbl_Cargo = new System.Windows.Forms.Label();
            this.Lbl_Nome = new System.Windows.Forms.Label();
            this.Edt_Cargo = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Edt_Setor = new System.Windows.Forms.ComboBox();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setorBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.Edt_SetorConsulta);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.Edt_CPFConsulta);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.label22);
            this.tabPage2.Controls.Add(this.Edt_NomeConsulta);
            this.tabPage2.Controls.Add(this.Btn_Limpar);
            this.tabPage2.Controls.Add(this.Btn_Consultar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(620, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 51);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(620, 363);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // Edt_SetorConsulta
            // 
            this.Edt_SetorConsulta.FormattingEnabled = true;
            this.Edt_SetorConsulta.Location = new System.Drawing.Point(356, 24);
            this.Edt_SetorConsulta.Name = "Edt_SetorConsulta";
            this.Edt_SetorConsulta.Size = new System.Drawing.Size(115, 21);
            this.Edt_SetorConsulta.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Setor";
            // 
            // Edt_CPFConsulta
            // 
            this.Edt_CPFConsulta.Location = new System.Drawing.Point(224, 25);
            this.Edt_CPFConsulta.Name = "Edt_CPFConsulta";
            this.Edt_CPFConsulta.Size = new System.Drawing.Size(126, 20);
            this.Edt_CPFConsulta.TabIndex = 19;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(221, 7);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(27, 13);
            this.label21.TabIndex = 18;
            this.label21.Text = "CPF";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(5, 7);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(35, 13);
            this.label22.TabIndex = 17;
            this.label22.Text = "Nome";
            // 
            // Edt_NomeConsulta
            // 
            this.Edt_NomeConsulta.Location = new System.Drawing.Point(8, 24);
            this.Edt_NomeConsulta.Name = "Edt_NomeConsulta";
            this.Edt_NomeConsulta.Size = new System.Drawing.Size(209, 20);
            this.Edt_NomeConsulta.TabIndex = 16;
            // 
            // Btn_Limpar
            // 
            this.Btn_Limpar.Image = global::pim3.Properties.Resources.limpar;
            this.Btn_Limpar.Location = new System.Drawing.Point(587, 19);
            this.Btn_Limpar.Name = "Btn_Limpar";
            this.Btn_Limpar.Size = new System.Drawing.Size(25, 25);
            this.Btn_Limpar.TabIndex = 23;
            this.Btn_Limpar.UseVisualStyleBackColor = true;
            this.Btn_Limpar.Click += new System.EventHandler(this.Btn_Limpar_Click);
            // 
            // Btn_Consultar
            // 
            this.Btn_Consultar.Image = global::pim3.Properties.Resources.procurar;
            this.Btn_Consultar.Location = new System.Drawing.Point(556, 19);
            this.Btn_Consultar.Name = "Btn_Consultar";
            this.Btn_Consultar.Size = new System.Drawing.Size(25, 25);
            this.Btn_Consultar.TabIndex = 22;
            this.Btn_Consultar.UseVisualStyleBackColor = true;
            this.Btn_Consultar.Click += new System.EventHandler(this.Btn_Consultar_Click);
            // 
            // funcionariosBindingSource
            // 
            this.funcionariosBindingSource.DataMember = "Funcionarios";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Edt_Setor);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.Lbl_DTAdmissao);
            this.tabPage1.Controls.Add(this.Edt_DTAdmissao);
            this.tabPage1.Controls.Add(this.Edt_CPF);
            this.tabPage1.Controls.Add(this.Lbl_CPF);
            this.tabPage1.Controls.Add(this.Edt_Cod);
            this.tabPage1.Controls.Add(this.Lbl_Cod);
            this.tabPage1.Controls.Add(this.Edt_Email);
            this.tabPage1.Controls.Add(this.Edt_Nome);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.Lbl_Setor);
            this.tabPage1.Controls.Add(this.Lbl_Email);
            this.tabPage1.Controls.Add(this.Lbl_Cargo);
            this.tabPage1.Controls.Add(this.Lbl_Nome);
            this.tabPage1.Controls.Add(this.Edt_Cargo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(620, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.Btn_Salva);
            this.panel1.Controls.Add(this.Btn_Cancela);
            this.panel1.Controls.Add(this.Btn_Consulta);
            this.panel1.Controls.Add(this.Btn_Altera);
            this.panel1.Controls.Add(this.Btn_Novo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 361);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 33);
            this.panel1.TabIndex = 83;
            // 
            // Btn_Salva
            // 
            this.Btn_Salva.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_Salva.Enabled = false;
            this.Btn_Salva.Image = global::pim3.Properties.Resources.Salvar;
            this.Btn_Salva.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Salva.Location = new System.Drawing.Point(454, 5);
            this.Btn_Salva.Name = "Btn_Salva";
            this.Btn_Salva.Size = new System.Drawing.Size(75, 23);
            this.Btn_Salva.TabIndex = 69;
            this.Btn_Salva.Text = "  Salvar";
            this.Btn_Salva.UseVisualStyleBackColor = false;
            this.Btn_Salva.Click += new System.EventHandler(this.Btn_Salva_Click);
            // 
            // Btn_Cancela
            // 
            this.Btn_Cancela.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_Cancela.Enabled = false;
            this.Btn_Cancela.Image = global::pim3.Properties.Resources.Cancelar;
            this.Btn_Cancela.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Cancela.Location = new System.Drawing.Point(534, 5);
            this.Btn_Cancela.Name = "Btn_Cancela";
            this.Btn_Cancela.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancela.TabIndex = 68;
            this.Btn_Cancela.Text = "      Cancelar";
            this.Btn_Cancela.UseVisualStyleBackColor = false;
            this.Btn_Cancela.Click += new System.EventHandler(this.Btn_Cancela_Click);
            // 
            // Btn_Consulta
            // 
            this.Btn_Consulta.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_Consulta.Image = global::pim3.Properties.Resources.procurar;
            this.Btn_Consulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Consulta.Location = new System.Drawing.Point(165, 5);
            this.Btn_Consulta.Name = "Btn_Consulta";
            this.Btn_Consulta.Size = new System.Drawing.Size(75, 23);
            this.Btn_Consulta.TabIndex = 67;
            this.Btn_Consulta.Text = "    Consultar";
            this.Btn_Consulta.UseVisualStyleBackColor = false;
            this.Btn_Consulta.Click += new System.EventHandler(this.Btn_Consulta_Click);
            // 
            // Btn_Altera
            // 
            this.Btn_Altera.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_Altera.Enabled = false;
            this.Btn_Altera.Image = global::pim3.Properties.Resources.Alterar;
            this.Btn_Altera.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Altera.Location = new System.Drawing.Point(85, 5);
            this.Btn_Altera.Name = "Btn_Altera";
            this.Btn_Altera.Size = new System.Drawing.Size(75, 23);
            this.Btn_Altera.TabIndex = 66;
            this.Btn_Altera.Text = "Alterar";
            this.Btn_Altera.UseVisualStyleBackColor = false;
            this.Btn_Altera.Click += new System.EventHandler(this.Btn_Altera_Click);
            // 
            // Btn_Novo
            // 
            this.Btn_Novo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_Novo.Image = global::pim3.Properties.Resources.Novo1;
            this.Btn_Novo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Novo.Location = new System.Drawing.Point(5, 5);
            this.Btn_Novo.Name = "Btn_Novo";
            this.Btn_Novo.Size = new System.Drawing.Size(75, 23);
            this.Btn_Novo.TabIndex = 65;
            this.Btn_Novo.Text = "Novo";
            this.Btn_Novo.UseVisualStyleBackColor = false;
            this.Btn_Novo.Click += new System.EventHandler(this.Btn_Novo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Edt_Complemento);
            this.groupBox2.Controls.Add(this.Edt_UF);
            this.groupBox2.Controls.Add(this.Lbl_UF);
            this.groupBox2.Controls.Add(this.Edt_CEP);
            this.groupBox2.Controls.Add(this.Lbl_CEP);
            this.groupBox2.Controls.Add(this.Edt_Num);
            this.groupBox2.Controls.Add(this.Lbl_Num);
            this.groupBox2.Controls.Add(this.Lbl_Complemento);
            this.groupBox2.Controls.Add(this.Edt_Bairro);
            this.groupBox2.Controls.Add(this.Edt_Cidade);
            this.groupBox2.Controls.Add(this.Edt_Logradouro);
            this.groupBox2.Controls.Add(this.Lbl_Bairro);
            this.groupBox2.Controls.Add(this.Lbl_Cidade);
            this.groupBox2.Controls.Add(this.Lbl_Logradouro);
            this.groupBox2.Location = new System.Drawing.Point(10, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(605, 172);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Endereço";
            // 
            // Edt_Complemento
            // 
            this.Edt_Complemento.Enabled = false;
            this.Edt_Complemento.Location = new System.Drawing.Point(345, 39);
            this.Edt_Complemento.Name = "Edt_Complemento";
            this.Edt_Complemento.Size = new System.Drawing.Size(254, 20);
            this.Edt_Complemento.TabIndex = 2;
            // 
            // Edt_UF
            // 
            this.Edt_UF.Enabled = false;
            this.Edt_UF.Location = new System.Drawing.Point(345, 89);
            this.Edt_UF.Name = "Edt_UF";
            this.Edt_UF.Size = new System.Drawing.Size(71, 20);
            this.Edt_UF.TabIndex = 4;
            // 
            // Lbl_UF
            // 
            this.Lbl_UF.AutoSize = true;
            this.Lbl_UF.Enabled = false;
            this.Lbl_UF.Location = new System.Drawing.Point(345, 72);
            this.Lbl_UF.Name = "Lbl_UF";
            this.Lbl_UF.Size = new System.Drawing.Size(21, 13);
            this.Lbl_UF.TabIndex = 85;
            this.Lbl_UF.Text = "UF";
            // 
            // Edt_CEP
            // 
            this.Edt_CEP.Enabled = false;
            this.Edt_CEP.Location = new System.Drawing.Point(432, 89);
            this.Edt_CEP.Name = "Edt_CEP";
            this.Edt_CEP.Size = new System.Drawing.Size(124, 20);
            this.Edt_CEP.TabIndex = 5;
            // 
            // Lbl_CEP
            // 
            this.Lbl_CEP.AutoSize = true;
            this.Lbl_CEP.Enabled = false;
            this.Lbl_CEP.Location = new System.Drawing.Point(429, 72);
            this.Lbl_CEP.Name = "Lbl_CEP";
            this.Lbl_CEP.Size = new System.Drawing.Size(28, 13);
            this.Lbl_CEP.TabIndex = 83;
            this.Lbl_CEP.Text = "CEP";
            // 
            // Edt_Num
            // 
            this.Edt_Num.Enabled = false;
            this.Edt_Num.Location = new System.Drawing.Point(345, 138);
            this.Edt_Num.Name = "Edt_Num";
            this.Edt_Num.Size = new System.Drawing.Size(71, 20);
            this.Edt_Num.TabIndex = 7;
            // 
            // Lbl_Num
            // 
            this.Lbl_Num.AutoSize = true;
            this.Lbl_Num.Enabled = false;
            this.Lbl_Num.Location = new System.Drawing.Point(345, 122);
            this.Lbl_Num.Name = "Lbl_Num";
            this.Lbl_Num.Size = new System.Drawing.Size(44, 13);
            this.Lbl_Num.TabIndex = 81;
            this.Lbl_Num.Text = "Número";
            // 
            // Lbl_Complemento
            // 
            this.Lbl_Complemento.AutoSize = true;
            this.Lbl_Complemento.Enabled = false;
            this.Lbl_Complemento.Location = new System.Drawing.Point(345, 22);
            this.Lbl_Complemento.Name = "Lbl_Complemento";
            this.Lbl_Complemento.Size = new System.Drawing.Size(71, 13);
            this.Lbl_Complemento.TabIndex = 87;
            this.Lbl_Complemento.Text = "Complemento";
            // 
            // Edt_Bairro
            // 
            this.Edt_Bairro.Enabled = false;
            this.Edt_Bairro.Location = new System.Drawing.Point(5, 138);
            this.Edt_Bairro.Name = "Edt_Bairro";
            this.Edt_Bairro.Size = new System.Drawing.Size(329, 20);
            this.Edt_Bairro.TabIndex = 6;
            // 
            // Edt_Cidade
            // 
            this.Edt_Cidade.Enabled = false;
            this.Edt_Cidade.Location = new System.Drawing.Point(5, 89);
            this.Edt_Cidade.Name = "Edt_Cidade";
            this.Edt_Cidade.Size = new System.Drawing.Size(329, 20);
            this.Edt_Cidade.TabIndex = 3;
            // 
            // Edt_Logradouro
            // 
            this.Edt_Logradouro.Enabled = false;
            this.Edt_Logradouro.Location = new System.Drawing.Point(5, 39);
            this.Edt_Logradouro.Name = "Edt_Logradouro";
            this.Edt_Logradouro.Size = new System.Drawing.Size(329, 20);
            this.Edt_Logradouro.TabIndex = 1;
            // 
            // Lbl_Bairro
            // 
            this.Lbl_Bairro.AutoSize = true;
            this.Lbl_Bairro.Enabled = false;
            this.Lbl_Bairro.Location = new System.Drawing.Point(9, 122);
            this.Lbl_Bairro.Name = "Lbl_Bairro";
            this.Lbl_Bairro.Size = new System.Drawing.Size(34, 13);
            this.Lbl_Bairro.TabIndex = 79;
            this.Lbl_Bairro.Text = "Bairro";
            // 
            // Lbl_Cidade
            // 
            this.Lbl_Cidade.AutoSize = true;
            this.Lbl_Cidade.Enabled = false;
            this.Lbl_Cidade.Location = new System.Drawing.Point(5, 73);
            this.Lbl_Cidade.Name = "Lbl_Cidade";
            this.Lbl_Cidade.Size = new System.Drawing.Size(40, 13);
            this.Lbl_Cidade.TabIndex = 77;
            this.Lbl_Cidade.Text = "Cidade";
            // 
            // Lbl_Logradouro
            // 
            this.Lbl_Logradouro.AutoSize = true;
            this.Lbl_Logradouro.Enabled = false;
            this.Lbl_Logradouro.Location = new System.Drawing.Point(5, 22);
            this.Lbl_Logradouro.Name = "Lbl_Logradouro";
            this.Lbl_Logradouro.Size = new System.Drawing.Size(61, 13);
            this.Lbl_Logradouro.TabIndex = 75;
            this.Lbl_Logradouro.Text = "Logradouro";
            // 
            // Lbl_DTAdmissao
            // 
            this.Lbl_DTAdmissao.AutoSize = true;
            this.Lbl_DTAdmissao.Enabled = false;
            this.Lbl_DTAdmissao.Location = new System.Drawing.Point(249, 10);
            this.Lbl_DTAdmissao.Name = "Lbl_DTAdmissao";
            this.Lbl_DTAdmissao.Size = new System.Drawing.Size(78, 13);
            this.Lbl_DTAdmissao.TabIndex = 82;
            this.Lbl_DTAdmissao.Text = "Data Admissão";
            // 
            // Edt_DTAdmissao
            // 
            this.Edt_DTAdmissao.Enabled = false;
            this.Edt_DTAdmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Edt_DTAdmissao.Location = new System.Drawing.Point(249, 27);
            this.Edt_DTAdmissao.Name = "Edt_DTAdmissao";
            this.Edt_DTAdmissao.Size = new System.Drawing.Size(95, 20);
            this.Edt_DTAdmissao.TabIndex = 2;
            this.Edt_DTAdmissao.Value = new System.DateTime(2020, 6, 9, 0, 0, 0, 0);
            // 
            // Edt_CPF
            // 
            this.Edt_CPF.Enabled = false;
            this.Edt_CPF.Location = new System.Drawing.Point(95, 27);
            this.Edt_CPF.Name = "Edt_CPF";
            this.Edt_CPF.Size = new System.Drawing.Size(146, 20);
            this.Edt_CPF.TabIndex = 1;
            // 
            // Lbl_CPF
            // 
            this.Lbl_CPF.AutoSize = true;
            this.Lbl_CPF.Enabled = false;
            this.Lbl_CPF.Location = new System.Drawing.Point(92, 10);
            this.Lbl_CPF.Name = "Lbl_CPF";
            this.Lbl_CPF.Size = new System.Drawing.Size(27, 13);
            this.Lbl_CPF.TabIndex = 79;
            this.Lbl_CPF.Text = "CPF";
            // 
            // Edt_Cod
            // 
            this.Edt_Cod.Enabled = false;
            this.Edt_Cod.Location = new System.Drawing.Point(10, 27);
            this.Edt_Cod.Name = "Edt_Cod";
            this.Edt_Cod.Size = new System.Drawing.Size(75, 20);
            this.Edt_Cod.TabIndex = 78;
            // 
            // Lbl_Cod
            // 
            this.Lbl_Cod.AutoSize = true;
            this.Lbl_Cod.Enabled = false;
            this.Lbl_Cod.Location = new System.Drawing.Point(10, 10);
            this.Lbl_Cod.Name = "Lbl_Cod";
            this.Lbl_Cod.Size = new System.Drawing.Size(40, 13);
            this.Lbl_Cod.TabIndex = 77;
            this.Lbl_Cod.Text = "Código";
            // 
            // setorBindingSource
            // 
            this.setorBindingSource.DataMember = "Setor";
            // 
            // Edt_Email
            // 
            this.Edt_Email.Enabled = false;
            this.Edt_Email.Location = new System.Drawing.Point(355, 27);
            this.Edt_Email.Name = "Edt_Email";
            this.Edt_Email.Size = new System.Drawing.Size(260, 20);
            this.Edt_Email.TabIndex = 3;
            // 
            // Edt_Nome
            // 
            this.Edt_Nome.Enabled = false;
            this.Edt_Nome.Location = new System.Drawing.Point(10, 77);
            this.Edt_Nome.Name = "Edt_Nome";
            this.Edt_Nome.Size = new System.Drawing.Size(334, 20);
            this.Edt_Nome.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Edt_Contato);
            this.groupBox1.Controls.Add(this.Lbl_Contato);
            this.groupBox1.Controls.Add(this.Edt_NumTel);
            this.groupBox1.Controls.Add(this.Lbl_NumTel);
            this.groupBox1.Controls.Add(this.Edt_Tipo);
            this.groupBox1.Controls.Add(this.Lbl_Tipo);
            this.groupBox1.Location = new System.Drawing.Point(10, 294);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 63);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Telefones";
            // 
            // Edt_Contato
            // 
            this.Edt_Contato.Enabled = false;
            this.Edt_Contato.Location = new System.Drawing.Point(221, 34);
            this.Edt_Contato.Name = "Edt_Contato";
            this.Edt_Contato.Size = new System.Drawing.Size(100, 20);
            this.Edt_Contato.TabIndex = 3;
            // 
            // Lbl_Contato
            // 
            this.Lbl_Contato.AutoSize = true;
            this.Lbl_Contato.Enabled = false;
            this.Lbl_Contato.Location = new System.Drawing.Point(218, 18);
            this.Lbl_Contato.Name = "Lbl_Contato";
            this.Lbl_Contato.Size = new System.Drawing.Size(75, 13);
            this.Lbl_Contato.TabIndex = 4;
            this.Lbl_Contato.Text = "Nome Contato";
            // 
            // Edt_NumTel
            // 
            this.Edt_NumTel.Enabled = false;
            this.Edt_NumTel.Location = new System.Drawing.Point(109, 34);
            this.Edt_NumTel.Name = "Edt_NumTel";
            this.Edt_NumTel.Size = new System.Drawing.Size(106, 20);
            this.Edt_NumTel.TabIndex = 2;
            // 
            // Lbl_NumTel
            // 
            this.Lbl_NumTel.AutoSize = true;
            this.Lbl_NumTel.Enabled = false;
            this.Lbl_NumTel.Location = new System.Drawing.Point(106, 18);
            this.Lbl_NumTel.Name = "Lbl_NumTel";
            this.Lbl_NumTel.Size = new System.Drawing.Size(44, 13);
            this.Lbl_NumTel.TabIndex = 2;
            this.Lbl_NumTel.Text = "Número";
            // 
            // Edt_Tipo
            // 
            this.Edt_Tipo.Enabled = false;
            this.Edt_Tipo.Location = new System.Drawing.Point(9, 34);
            this.Edt_Tipo.Name = "Edt_Tipo";
            this.Edt_Tipo.Size = new System.Drawing.Size(94, 20);
            this.Edt_Tipo.TabIndex = 1;
            // 
            // Lbl_Tipo
            // 
            this.Lbl_Tipo.AutoSize = true;
            this.Lbl_Tipo.Enabled = false;
            this.Lbl_Tipo.Location = new System.Drawing.Point(6, 18);
            this.Lbl_Tipo.Name = "Lbl_Tipo";
            this.Lbl_Tipo.Size = new System.Drawing.Size(28, 13);
            this.Lbl_Tipo.TabIndex = 0;
            this.Lbl_Tipo.Text = "Tipo";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Edt_DTDemissao);
            this.groupBox3.Location = new System.Drawing.Point(355, 294);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(112, 63);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data Demissão";
            // 
            // Edt_DTDemissao
            // 
            this.Edt_DTDemissao.Enabled = false;
            this.Edt_DTDemissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Edt_DTDemissao.Location = new System.Drawing.Point(11, 31);
            this.Edt_DTDemissao.Name = "Edt_DTDemissao";
            this.Edt_DTDemissao.Size = new System.Drawing.Size(87, 20);
            this.Edt_DTDemissao.TabIndex = 60;
            this.Edt_DTDemissao.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            // 
            // Lbl_Setor
            // 
            this.Lbl_Setor.AutoSize = true;
            this.Lbl_Setor.Enabled = false;
            this.Lbl_Setor.Location = new System.Drawing.Point(355, 60);
            this.Lbl_Setor.Name = "Lbl_Setor";
            this.Lbl_Setor.Size = new System.Drawing.Size(32, 13);
            this.Lbl_Setor.TabIndex = 50;
            this.Lbl_Setor.Text = "Setor";
            // 
            // Lbl_Email
            // 
            this.Lbl_Email.AutoSize = true;
            this.Lbl_Email.Enabled = false;
            this.Lbl_Email.Location = new System.Drawing.Point(355, 10);
            this.Lbl_Email.Name = "Lbl_Email";
            this.Lbl_Email.Size = new System.Drawing.Size(32, 13);
            this.Lbl_Email.TabIndex = 48;
            this.Lbl_Email.Text = "Email";
            // 
            // Lbl_Cargo
            // 
            this.Lbl_Cargo.AutoSize = true;
            this.Lbl_Cargo.Enabled = false;
            this.Lbl_Cargo.Location = new System.Drawing.Point(486, 61);
            this.Lbl_Cargo.Name = "Lbl_Cargo";
            this.Lbl_Cargo.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Cargo.TabIndex = 36;
            this.Lbl_Cargo.Text = "Cargo";
            // 
            // Lbl_Nome
            // 
            this.Lbl_Nome.AutoSize = true;
            this.Lbl_Nome.Enabled = false;
            this.Lbl_Nome.Location = new System.Drawing.Point(10, 60);
            this.Lbl_Nome.Name = "Lbl_Nome";
            this.Lbl_Nome.Size = new System.Drawing.Size(82, 13);
            this.Lbl_Nome.TabIndex = 4;
            this.Lbl_Nome.Text = "Nome Completo";
            // 
            // Edt_Cargo
            // 
            this.Edt_Cargo.Enabled = false;
            this.Edt_Cargo.FormattingEnabled = true;
            this.Edt_Cargo.Location = new System.Drawing.Point(489, 77);
            this.Edt_Cargo.Name = "Edt_Cargo";
            this.Edt_Cargo.Size = new System.Drawing.Size(126, 21);
            this.Edt_Cargo.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(628, 423);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // Edt_Setor
            // 
            this.Edt_Setor.Enabled = false;
            this.Edt_Setor.FormattingEnabled = true;
            this.Edt_Setor.Location = new System.Drawing.Point(355, 77);
            this.Edt_Setor.Name = "Edt_Setor";
            this.Edt_Setor.Size = new System.Drawing.Size(126, 21);
            this.Edt_Setor.TabIndex = 84;
            // 
            // Frm_Funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 423);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Funcionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionários";
            this.Shown += new System.EventHandler(this.Frm_Funcionarios_Shown);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setorBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker Edt_DTDemissao;
        private System.Windows.Forms.Label Lbl_Setor;
        private System.Windows.Forms.Label Lbl_Email;
        private System.Windows.Forms.Label Lbl_Cargo;
        private System.Windows.Forms.Label Lbl_Nome;
        private System.Windows.Forms.ComboBox Edt_Cargo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button Btn_Limpar;
        private System.Windows.Forms.Button Btn_Consultar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Edt_CPFConsulta;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox Edt_NomeConsulta;
        private System.Windows.Forms.ComboBox Edt_SetorConsulta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Edt_Contato;
        private System.Windows.Forms.Label Lbl_Contato;
        private System.Windows.Forms.TextBox Edt_NumTel;
        private System.Windows.Forms.Label Lbl_NumTel;
        private System.Windows.Forms.TextBox Edt_Tipo;
        private System.Windows.Forms.Label Lbl_Tipo;
        private System.Windows.Forms.TextBox Edt_Nome;
        private System.Windows.Forms.TextBox Edt_Email;
        private System.Windows.Forms.TextBox Edt_CPF;
        private System.Windows.Forms.Label Lbl_CPF;
        private System.Windows.Forms.TextBox Edt_Cod;
        private System.Windows.Forms.Label Lbl_Cod;
        private System.Windows.Forms.Label Lbl_DTAdmissao;
        private System.Windows.Forms.DateTimePicker Edt_DTAdmissao;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Edt_Complemento;
        private System.Windows.Forms.TextBox Edt_UF;
        private System.Windows.Forms.Label Lbl_UF;
        private System.Windows.Forms.TextBox Edt_CEP;
        private System.Windows.Forms.Label Lbl_CEP;
        private System.Windows.Forms.TextBox Edt_Num;
        private System.Windows.Forms.Label Lbl_Num;
        private System.Windows.Forms.Label Lbl_Complemento;
        private System.Windows.Forms.TextBox Edt_Bairro;
        private System.Windows.Forms.TextBox Edt_Cidade;
        private System.Windows.Forms.TextBox Edt_Logradouro;
        private System.Windows.Forms.Label Lbl_Bairro;
        private System.Windows.Forms.Label Lbl_Cidade;
        private System.Windows.Forms.Label Lbl_Logradouro;
        private System.Windows.Forms.BindingSource funcionariosBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Salva;
        private System.Windows.Forms.Button Btn_Cancela;
        private System.Windows.Forms.Button Btn_Consulta;
        private System.Windows.Forms.Button Btn_Altera;
        private System.Windows.Forms.Button Btn_Novo;
        private System.Windows.Forms.BindingSource setorBindingSource;
        private System.Windows.Forms.ComboBox Edt_Setor;
    }
}