namespace pim3
{
    partial class Frm_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Cliente));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
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
            this.Btn_Salvar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Consultar = new System.Windows.Forms.Button();
            this.Btn_Alterar = new System.Windows.Forms.Button();
            this.Btn_Novo = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Carteira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Moeda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Edt_Contato = new System.Windows.Forms.TextBox();
            this.Lbl_Contato = new System.Windows.Forms.Label();
            this.Edt_NumTel = new System.Windows.Forms.TextBox();
            this.Lbl_NumTel = new System.Windows.Forms.Label();
            this.Edt_Tipo = new System.Windows.Forms.TextBox();
            this.Lbl_TIpo = new System.Windows.Forms.Label();
            this.Edt_Email = new System.Windows.Forms.TextBox();
            this.Lbl_Email = new System.Windows.Forms.Label();
            this.Edt_Fantasia = new System.Windows.Forms.TextBox();
            this.Lbl_Fantasia = new System.Windows.Forms.Label();
            this.Edt_Razao = new System.Windows.Forms.TextBox();
            this.Lbl_Razao = new System.Windows.Forms.Label();
            this.Edt_IE = new System.Windows.Forms.TextBox();
            this.Lbl_IE = new System.Windows.Forms.Label();
            this.Edt_Ativo = new System.Windows.Forms.CheckBox();
            this.Edt_FJ = new System.Windows.Forms.ComboBox();
            this.Edt_CPFCNPJ = new System.Windows.Forms.TextBox();
            this.Lbl_CPFCNPJ = new System.Windows.Forms.Label();
            this.Lbl_FJ = new System.Windows.Forms.Label();
            this.Edt_Cod = new System.Windows.Forms.TextBox();
            this.Lbl_Cod = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.CPFCNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(644, 450);
            this.tabControl1.TabIndex = 29;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.Btn_Salvar);
            this.tabPage1.Controls.Add(this.Btn_Cancelar);
            this.tabPage1.Controls.Add(this.Btn_Consultar);
            this.tabPage1.Controls.Add(this.Btn_Alterar);
            this.tabPage1.Controls.Add(this.Btn_Novo);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.Edt_Email);
            this.tabPage1.Controls.Add(this.Lbl_Email);
            this.tabPage1.Controls.Add(this.Edt_Fantasia);
            this.tabPage1.Controls.Add(this.Lbl_Fantasia);
            this.tabPage1.Controls.Add(this.Edt_Razao);
            this.tabPage1.Controls.Add(this.Lbl_Razao);
            this.tabPage1.Controls.Add(this.Edt_IE);
            this.tabPage1.Controls.Add(this.Lbl_IE);
            this.tabPage1.Controls.Add(this.Edt_Ativo);
            this.tabPage1.Controls.Add(this.Edt_FJ);
            this.tabPage1.Controls.Add(this.Edt_CPFCNPJ);
            this.tabPage1.Controls.Add(this.Lbl_CPFCNPJ);
            this.tabPage1.Controls.Add(this.Lbl_FJ);
            this.tabPage1.Controls.Add(this.Edt_Cod);
            this.tabPage1.Controls.Add(this.Lbl_Cod);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(636, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Edt_Complemento);
            this.groupBox4.Controls.Add(this.Edt_UF);
            this.groupBox4.Controls.Add(this.Lbl_UF);
            this.groupBox4.Controls.Add(this.Edt_CEP);
            this.groupBox4.Controls.Add(this.Lbl_CEP);
            this.groupBox4.Controls.Add(this.Edt_Num);
            this.groupBox4.Controls.Add(this.Lbl_Num);
            this.groupBox4.Controls.Add(this.Lbl_Complemento);
            this.groupBox4.Controls.Add(this.Edt_Bairro);
            this.groupBox4.Controls.Add(this.Edt_Cidade);
            this.groupBox4.Controls.Add(this.Edt_Logradouro);
            this.groupBox4.Controls.Add(this.Lbl_Bairro);
            this.groupBox4.Controls.Add(this.Lbl_Cidade);
            this.groupBox4.Controls.Add(this.Lbl_Logradouro);
            this.groupBox4.Location = new System.Drawing.Point(10, 107);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(605, 155);
            this.groupBox4.TabIndex = 84;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Endereço";
            // 
            // Edt_Complemento
            // 
            this.Edt_Complemento.Enabled = false;
            this.Edt_Complemento.Location = new System.Drawing.Point(345, 34);
            this.Edt_Complemento.Name = "Edt_Complemento";
            this.Edt_Complemento.Size = new System.Drawing.Size(254, 20);
            this.Edt_Complemento.TabIndex = 88;
            // 
            // Edt_UF
            // 
            this.Edt_UF.Enabled = false;
            this.Edt_UF.Location = new System.Drawing.Point(345, 84);
            this.Edt_UF.Name = "Edt_UF";
            this.Edt_UF.Size = new System.Drawing.Size(53, 20);
            this.Edt_UF.TabIndex = 86;
            // 
            // Lbl_UF
            // 
            this.Lbl_UF.AutoSize = true;
            this.Lbl_UF.Enabled = false;
            this.Lbl_UF.Location = new System.Drawing.Point(345, 67);
            this.Lbl_UF.Name = "Lbl_UF";
            this.Lbl_UF.Size = new System.Drawing.Size(21, 13);
            this.Lbl_UF.TabIndex = 85;
            this.Lbl_UF.Text = "UF";
            // 
            // Edt_CEP
            // 
            this.Edt_CEP.Enabled = false;
            this.Edt_CEP.Location = new System.Drawing.Point(417, 84);
            this.Edt_CEP.Name = "Edt_CEP";
            this.Edt_CEP.Size = new System.Drawing.Size(124, 20);
            this.Edt_CEP.TabIndex = 84;
            // 
            // Lbl_CEP
            // 
            this.Lbl_CEP.AutoSize = true;
            this.Lbl_CEP.Enabled = false;
            this.Lbl_CEP.Location = new System.Drawing.Point(414, 67);
            this.Lbl_CEP.Name = "Lbl_CEP";
            this.Lbl_CEP.Size = new System.Drawing.Size(28, 13);
            this.Lbl_CEP.TabIndex = 83;
            this.Lbl_CEP.Text = "CEP";
            // 
            // Edt_Num
            // 
            this.Edt_Num.Enabled = false;
            this.Edt_Num.Location = new System.Drawing.Point(345, 128);
            this.Edt_Num.Name = "Edt_Num";
            this.Edt_Num.Size = new System.Drawing.Size(71, 20);
            this.Edt_Num.TabIndex = 82;
            // 
            // Lbl_Num
            // 
            this.Lbl_Num.AutoSize = true;
            this.Lbl_Num.Enabled = false;
            this.Lbl_Num.Location = new System.Drawing.Point(342, 112);
            this.Lbl_Num.Name = "Lbl_Num";
            this.Lbl_Num.Size = new System.Drawing.Size(44, 13);
            this.Lbl_Num.TabIndex = 81;
            this.Lbl_Num.Text = "Número";
            // 
            // Lbl_Complemento
            // 
            this.Lbl_Complemento.AutoSize = true;
            this.Lbl_Complemento.Enabled = false;
            this.Lbl_Complemento.Location = new System.Drawing.Point(345, 17);
            this.Lbl_Complemento.Name = "Lbl_Complemento";
            this.Lbl_Complemento.Size = new System.Drawing.Size(71, 13);
            this.Lbl_Complemento.TabIndex = 87;
            this.Lbl_Complemento.Text = "Complemento";
            // 
            // Edt_Bairro
            // 
            this.Edt_Bairro.Enabled = false;
            this.Edt_Bairro.Location = new System.Drawing.Point(5, 128);
            this.Edt_Bairro.Name = "Edt_Bairro";
            this.Edt_Bairro.Size = new System.Drawing.Size(329, 20);
            this.Edt_Bairro.TabIndex = 80;
            // 
            // Edt_Cidade
            // 
            this.Edt_Cidade.Enabled = false;
            this.Edt_Cidade.Location = new System.Drawing.Point(5, 84);
            this.Edt_Cidade.Name = "Edt_Cidade";
            this.Edt_Cidade.Size = new System.Drawing.Size(329, 20);
            this.Edt_Cidade.TabIndex = 78;
            // 
            // Edt_Logradouro
            // 
            this.Edt_Logradouro.Enabled = false;
            this.Edt_Logradouro.Location = new System.Drawing.Point(5, 34);
            this.Edt_Logradouro.Name = "Edt_Logradouro";
            this.Edt_Logradouro.Size = new System.Drawing.Size(329, 20);
            this.Edt_Logradouro.TabIndex = 76;
            // 
            // Lbl_Bairro
            // 
            this.Lbl_Bairro.AutoSize = true;
            this.Lbl_Bairro.Enabled = false;
            this.Lbl_Bairro.Location = new System.Drawing.Point(7, 112);
            this.Lbl_Bairro.Name = "Lbl_Bairro";
            this.Lbl_Bairro.Size = new System.Drawing.Size(34, 13);
            this.Lbl_Bairro.TabIndex = 79;
            this.Lbl_Bairro.Text = "Bairro";
            // 
            // Lbl_Cidade
            // 
            this.Lbl_Cidade.AutoSize = true;
            this.Lbl_Cidade.Enabled = false;
            this.Lbl_Cidade.Location = new System.Drawing.Point(5, 68);
            this.Lbl_Cidade.Name = "Lbl_Cidade";
            this.Lbl_Cidade.Size = new System.Drawing.Size(40, 13);
            this.Lbl_Cidade.TabIndex = 77;
            this.Lbl_Cidade.Text = "Cidade";
            // 
            // Lbl_Logradouro
            // 
            this.Lbl_Logradouro.AutoSize = true;
            this.Lbl_Logradouro.Enabled = false;
            this.Lbl_Logradouro.Location = new System.Drawing.Point(5, 17);
            this.Lbl_Logradouro.Name = "Lbl_Logradouro";
            this.Lbl_Logradouro.Size = new System.Drawing.Size(61, 13);
            this.Lbl_Logradouro.TabIndex = 75;
            this.Lbl_Logradouro.Text = "Logradouro";
            // 
            // Btn_Salvar
            // 
            this.Btn_Salvar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_Salvar.Enabled = false;
            this.Btn_Salvar.Image = global::pim3.Properties.Resources.Salvar;
            this.Btn_Salvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Salvar.Location = new System.Drawing.Point(459, 389);
            this.Btn_Salvar.Name = "Btn_Salvar";
            this.Btn_Salvar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Salvar.TabIndex = 38;
            this.Btn_Salvar.Text = "  Salvar";
            this.Btn_Salvar.UseVisualStyleBackColor = false;
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_Cancelar.Enabled = false;
            this.Btn_Cancelar.Image = global::pim3.Properties.Resources.Cancelar;
            this.Btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Cancelar.Location = new System.Drawing.Point(540, 389);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancelar.TabIndex = 37;
            this.Btn_Cancelar.Text = "     Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = false;
            // 
            // Btn_Consultar
            // 
            this.Btn_Consultar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_Consultar.Image = global::pim3.Properties.Resources.procurar;
            this.Btn_Consultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Consultar.Location = new System.Drawing.Point(172, 389);
            this.Btn_Consultar.Name = "Btn_Consultar";
            this.Btn_Consultar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Consultar.TabIndex = 36;
            this.Btn_Consultar.Text = "     Consultar";
            this.Btn_Consultar.UseVisualStyleBackColor = false;
            this.Btn_Consultar.Click += new System.EventHandler(this.button3_Click);
            // 
            // Btn_Alterar
            // 
            this.Btn_Alterar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_Alterar.Enabled = false;
            this.Btn_Alterar.Image = global::pim3.Properties.Resources.Alterar;
            this.Btn_Alterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Alterar.Location = new System.Drawing.Point(91, 389);
            this.Btn_Alterar.Name = "Btn_Alterar";
            this.Btn_Alterar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Alterar.TabIndex = 35;
            this.Btn_Alterar.Text = "Alterar";
            this.Btn_Alterar.UseVisualStyleBackColor = false;
            // 
            // Btn_Novo
            // 
            this.Btn_Novo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_Novo.Image = global::pim3.Properties.Resources.Novo1;
            this.Btn_Novo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Novo.Location = new System.Drawing.Point(10, 389);
            this.Btn_Novo.Name = "Btn_Novo";
            this.Btn_Novo.Size = new System.Drawing.Size(75, 23);
            this.Btn_Novo.TabIndex = 34;
            this.Btn_Novo.Text = "Novo";
            this.Btn_Novo.UseVisualStyleBackColor = false;
            this.Btn_Novo.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(358, 267);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(257, 116);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Carteiras";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Carteira,
            this.Moeda,
            this.Valor});
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 4;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(257, 98);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Carteira
            // 
            this.Carteira.HeaderText = "Carteira";
            this.Carteira.Name = "Carteira";
            this.Carteira.ReadOnly = true;
            this.Carteira.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Moeda
            // 
            this.Moeda.HeaderText = "Moeda";
            this.Moeda.Name = "Moeda";
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Edt_Contato);
            this.groupBox1.Controls.Add(this.Lbl_Contato);
            this.groupBox1.Controls.Add(this.Edt_NumTel);
            this.groupBox1.Controls.Add(this.Lbl_NumTel);
            this.groupBox1.Controls.Add(this.Edt_Tipo);
            this.groupBox1.Controls.Add(this.Lbl_TIpo);
            this.groupBox1.Location = new System.Drawing.Point(10, 267);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 63);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Telefones";
            // 
            // Edt_Contato
            // 
            this.Edt_Contato.Enabled = false;
            this.Edt_Contato.Location = new System.Drawing.Point(221, 34);
            this.Edt_Contato.Name = "Edt_Contato";
            this.Edt_Contato.Size = new System.Drawing.Size(100, 20);
            this.Edt_Contato.TabIndex = 5;
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
            this.Edt_NumTel.TabIndex = 3;
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
            this.Edt_Tipo.TextChanged += new System.EventHandler(this.textBox14_TextChanged);
            // 
            // Lbl_TIpo
            // 
            this.Lbl_TIpo.AutoSize = true;
            this.Lbl_TIpo.Enabled = false;
            this.Lbl_TIpo.Location = new System.Drawing.Point(6, 18);
            this.Lbl_TIpo.Name = "Lbl_TIpo";
            this.Lbl_TIpo.Size = new System.Drawing.Size(28, 13);
            this.Lbl_TIpo.TabIndex = 0;
            this.Lbl_TIpo.Text = "Tipo";
            // 
            // Edt_Email
            // 
            this.Edt_Email.Enabled = false;
            this.Edt_Email.Location = new System.Drawing.Point(355, 28);
            this.Edt_Email.Name = "Edt_Email";
            this.Edt_Email.Size = new System.Drawing.Size(260, 20);
            this.Edt_Email.TabIndex = 21;
            this.Edt_Email.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // Lbl_Email
            // 
            this.Lbl_Email.AutoSize = true;
            this.Lbl_Email.Enabled = false;
            this.Lbl_Email.Location = new System.Drawing.Point(355, 11);
            this.Lbl_Email.Name = "Lbl_Email";
            this.Lbl_Email.Size = new System.Drawing.Size(32, 13);
            this.Lbl_Email.TabIndex = 20;
            this.Lbl_Email.Text = "Email";
            this.Lbl_Email.Click += new System.EventHandler(this.label9_Click);
            // 
            // Edt_Fantasia
            // 
            this.Edt_Fantasia.Enabled = false;
            this.Edt_Fantasia.Location = new System.Drawing.Point(355, 77);
            this.Edt_Fantasia.Name = "Edt_Fantasia";
            this.Edt_Fantasia.Size = new System.Drawing.Size(260, 20);
            this.Edt_Fantasia.TabIndex = 15;
            this.Edt_Fantasia.TextChanged += new System.EventHandler(this.textBox5_TextChanged_1);
            // 
            // Lbl_Fantasia
            // 
            this.Lbl_Fantasia.AutoSize = true;
            this.Lbl_Fantasia.Enabled = false;
            this.Lbl_Fantasia.Location = new System.Drawing.Point(355, 60);
            this.Lbl_Fantasia.Name = "Lbl_Fantasia";
            this.Lbl_Fantasia.Size = new System.Drawing.Size(118, 13);
            this.Lbl_Fantasia.TabIndex = 14;
            this.Lbl_Fantasia.Text = "Nome Social / Fantasia";
            this.Lbl_Fantasia.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // Edt_Razao
            // 
            this.Edt_Razao.Enabled = false;
            this.Edt_Razao.Location = new System.Drawing.Point(10, 77);
            this.Edt_Razao.Name = "Edt_Razao";
            this.Edt_Razao.Size = new System.Drawing.Size(334, 20);
            this.Edt_Razao.TabIndex = 13;
            // 
            // Lbl_Razao
            // 
            this.Lbl_Razao.AutoSize = true;
            this.Lbl_Razao.Enabled = false;
            this.Lbl_Razao.Location = new System.Drawing.Point(10, 60);
            this.Lbl_Razao.Name = "Lbl_Razao";
            this.Lbl_Razao.Size = new System.Drawing.Size(109, 13);
            this.Lbl_Razao.TabIndex = 12;
            this.Lbl_Razao.Text = "Nome / Razão Social";
            // 
            // Edt_IE
            // 
            this.Edt_IE.Enabled = false;
            this.Edt_IE.Location = new System.Drawing.Point(10, 354);
            this.Edt_IE.Name = "Edt_IE";
            this.Edt_IE.Size = new System.Drawing.Size(334, 20);
            this.Edt_IE.TabIndex = 11;
            // 
            // Lbl_IE
            // 
            this.Lbl_IE.AutoSize = true;
            this.Lbl_IE.Enabled = false;
            this.Lbl_IE.Location = new System.Drawing.Point(10, 337);
            this.Lbl_IE.Name = "Lbl_IE";
            this.Lbl_IE.Size = new System.Drawing.Size(94, 13);
            this.Lbl_IE.TabIndex = 10;
            this.Lbl_IE.Text = "Inscrição Estadual";
            // 
            // Edt_Ativo
            // 
            this.Edt_Ativo.AutoSize = true;
            this.Edt_Ativo.Enabled = false;
            this.Edt_Ativo.Location = new System.Drawing.Point(291, 28);
            this.Edt_Ativo.Name = "Edt_Ativo";
            this.Edt_Ativo.Size = new System.Drawing.Size(50, 17);
            this.Edt_Ativo.TabIndex = 9;
            this.Edt_Ativo.Text = "Ativo";
            this.Edt_Ativo.UseVisualStyleBackColor = true;
            this.Edt_Ativo.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Edt_FJ
            // 
            this.Edt_FJ.Enabled = false;
            this.Edt_FJ.FormattingEnabled = true;
            this.Edt_FJ.Items.AddRange(new object[] {
            "F",
            "J"});
            this.Edt_FJ.Location = new System.Drawing.Point(87, 26);
            this.Edt_FJ.Name = "Edt_FJ";
            this.Edt_FJ.Size = new System.Drawing.Size(40, 21);
            this.Edt_FJ.TabIndex = 8;
            // 
            // Edt_CPFCNPJ
            // 
            this.Edt_CPFCNPJ.Enabled = false;
            this.Edt_CPFCNPJ.Location = new System.Drawing.Point(139, 27);
            this.Edt_CPFCNPJ.Name = "Edt_CPFCNPJ";
            this.Edt_CPFCNPJ.Size = new System.Drawing.Size(146, 20);
            this.Edt_CPFCNPJ.TabIndex = 5;
            // 
            // Lbl_CPFCNPJ
            // 
            this.Lbl_CPFCNPJ.AutoSize = true;
            this.Lbl_CPFCNPJ.Enabled = false;
            this.Lbl_CPFCNPJ.Location = new System.Drawing.Point(139, 10);
            this.Lbl_CPFCNPJ.Name = "Lbl_CPFCNPJ";
            this.Lbl_CPFCNPJ.Size = new System.Drawing.Size(65, 13);
            this.Lbl_CPFCNPJ.TabIndex = 4;
            this.Lbl_CPFCNPJ.Text = "CPF / CNPJ";
            // 
            // Lbl_FJ
            // 
            this.Lbl_FJ.AutoSize = true;
            this.Lbl_FJ.Enabled = false;
            this.Lbl_FJ.Location = new System.Drawing.Point(84, 10);
            this.Lbl_FJ.Name = "Lbl_FJ";
            this.Lbl_FJ.Size = new System.Drawing.Size(29, 13);
            this.Lbl_FJ.TabIndex = 2;
            this.Lbl_FJ.Text = "F / J";
            // 
            // Edt_Cod
            // 
            this.Edt_Cod.Enabled = false;
            this.Edt_Cod.Location = new System.Drawing.Point(10, 27);
            this.Edt_Cod.Name = "Edt_Cod";
            this.Edt_Cod.Size = new System.Drawing.Size(64, 20);
            this.Edt_Cod.TabIndex = 1;
            // 
            // Lbl_Cod
            // 
            this.Lbl_Cod.AutoSize = true;
            this.Lbl_Cod.Enabled = false;
            this.Lbl_Cod.Location = new System.Drawing.Point(10, 10);
            this.Lbl_Cod.Name = "Lbl_Cod";
            this.Lbl_Cod.Size = new System.Drawing.Size(40, 13);
            this.Lbl_Cod.TabIndex = 0;
            this.Lbl_Cod.Text = "Código";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.textBox25);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.textBox24);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.textBox23);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(636, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(0, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(636, 374);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CPFCNPJ,
            this.Nome,
            this.NomeSocial,
            this.Email,
            this.Cidade});
            this.dataGridView2.Location = new System.Drawing.Point(0, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 4;
            this.dataGridView2.Size = new System.Drawing.Size(633, 361);
            this.dataGridView2.TabIndex = 0;
            // 
            // CPFCNPJ
            // 
            this.CPFCNPJ.HeaderText = "CPF / CNPJ";
            this.CPFCNPJ.Name = "CPFCNPJ";
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome / Razão Social";
            this.Nome.Name = "Nome";
            this.Nome.Width = 150;
            // 
            // NomeSocial
            // 
            this.NomeSocial.HeaderText = "Nome Social / Fantasia";
            this.NomeSocial.Name = "NomeSocial";
            this.NomeSocial.Width = 150;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.Width = 140;
            // 
            // Cidade
            // 
            this.Cidade.HeaderText = "Cidade";
            this.Cidade.Name = "Cidade";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(558, 21);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "Limpar";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(477, 21);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "Consultar";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // textBox25
            // 
            this.textBox25.Location = new System.Drawing.Point(372, 24);
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(84, 20);
            this.textBox25.TabIndex = 5;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(369, 8);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(54, 13);
            this.label20.TabIndex = 4;
            this.label20.Text = "Código ID";
            // 
            // textBox24
            // 
            this.textBox24.Location = new System.Drawing.Point(228, 24);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(138, 20);
            this.textBox24.TabIndex = 3;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(225, 8);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 13);
            this.label19.TabIndex = 2;
            this.label19.Text = "CPF / CNPJ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(10, 8);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(109, 13);
            this.label18.TabIndex = 1;
            this.label18.Text = "Nome / Razão Social";
            // 
            // textBox23
            // 
            this.textBox23.Location = new System.Drawing.Point(13, 25);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(209, 20);
            this.textBox23.TabIndex = 0;
            // 
            // Frm_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(645, 450);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Shown += new System.EventHandler(this.Frm_Cliente_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox Edt_FJ;
        private System.Windows.Forms.TextBox Edt_CPFCNPJ;
        private System.Windows.Forms.Label Lbl_CPFCNPJ;
        private System.Windows.Forms.Label Lbl_FJ;
        private System.Windows.Forms.TextBox Edt_Cod;
        private System.Windows.Forms.Label Lbl_Cod;
        private System.Windows.Forms.TextBox Edt_Razao;
        private System.Windows.Forms.Label Lbl_Razao;
        private System.Windows.Forms.TextBox Edt_IE;
        private System.Windows.Forms.Label Lbl_IE;
        private System.Windows.Forms.CheckBox Edt_Ativo;
        private System.Windows.Forms.TextBox Edt_Fantasia;
        private System.Windows.Forms.Label Lbl_Fantasia;
        private System.Windows.Forms.TextBox Edt_Email;
        private System.Windows.Forms.Label Lbl_Email;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Edt_Contato;
        private System.Windows.Forms.Label Lbl_Contato;
        private System.Windows.Forms.TextBox Edt_NumTel;
        private System.Windows.Forms.Label Lbl_NumTel;
        private System.Windows.Forms.TextBox Edt_Tipo;
        private System.Windows.Forms.Label Lbl_TIpo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carteira;
        private System.Windows.Forms.DataGridViewTextBoxColumn Moeda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.Button Btn_Novo;
        private System.Windows.Forms.Button Btn_Consultar;
        private System.Windows.Forms.Button Btn_Alterar;
        private System.Windows.Forms.Button Btn_Salvar;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPFCNPJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox25;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.GroupBox groupBox4;
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
    }
}