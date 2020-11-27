
namespace pim3.formularios
{
    partial class Frm_CadLoginFuncionario
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Edt_Ativo = new System.Windows.Forms.CheckBox();
            this.Edt_Senha = new System.Windows.Forms.TextBox();
            this.lbl_Senha = new System.Windows.Forms.Label();
            this.Edt_Login = new System.Windows.Forms.TextBox();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.Edt_Nivel = new System.Windows.Forms.ComboBox();
            this.lbl_Cargo = new System.Windows.Forms.Label();
            this.Edt_IDFuncionario = new System.Windows.Forms.TextBox();
            this.lbl_IDFuncionario = new System.Windows.Forms.Label();
            this.Btn_Alterar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Btn_Salvar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Novo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_ConsultaLogin = new System.Windows.Forms.Label();
            this.Edt_ConsultaLogin = new System.Windows.Forms.TextBox();
            this.Btn_Consultar = new System.Windows.Forms.Button();
            this.Btn_Limpar = new System.Windows.Forms.Button();
            this.Edt_IDLogin = new System.Windows.Forms.TextBox();
            this.lbl_IDLogin = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(283, 258);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.lbl_IDLogin);
            this.tabPage1.Controls.Add(this.Edt_IDLogin);
            this.tabPage1.Controls.Add(this.Edt_Ativo);
            this.tabPage1.Controls.Add(this.Edt_Senha);
            this.tabPage1.Controls.Add(this.lbl_Senha);
            this.tabPage1.Controls.Add(this.Edt_Login);
            this.tabPage1.Controls.Add(this.lbl_Login);
            this.tabPage1.Controls.Add(this.Edt_Nivel);
            this.tabPage1.Controls.Add(this.lbl_Cargo);
            this.tabPage1.Controls.Add(this.Edt_IDFuncionario);
            this.tabPage1.Controls.Add(this.lbl_IDFuncionario);
            this.tabPage1.Controls.Add(this.Btn_Salvar);
            this.tabPage1.Controls.Add(this.Btn_Cancelar);
            this.tabPage1.Controls.Add(this.Btn_Alterar);
            this.tabPage1.Controls.Add(this.Btn_Novo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(275, 232);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            // 
            // Edt_Ativo
            // 
            this.Edt_Ativo.AutoSize = true;
            this.Edt_Ativo.Location = new System.Drawing.Point(174, 57);
            this.Edt_Ativo.Name = "Edt_Ativo";
            this.Edt_Ativo.Size = new System.Drawing.Size(89, 17);
            this.Edt_Ativo.TabIndex = 12;
            this.Edt_Ativo.Text = "Usuário Ativo";
            this.Edt_Ativo.UseVisualStyleBackColor = true;
            // 
            // Edt_Senha
            // 
            this.Edt_Senha.Location = new System.Drawing.Point(51, 94);
            this.Edt_Senha.Name = "Edt_Senha";
            this.Edt_Senha.PasswordChar = '*';
            this.Edt_Senha.Size = new System.Drawing.Size(115, 20);
            this.Edt_Senha.TabIndex = 11;
            this.Edt_Senha.TextChanged += new System.EventHandler(this.Edt_Senha_TextChanged);
            // 
            // lbl_Senha
            // 
            this.lbl_Senha.AutoSize = true;
            this.lbl_Senha.Location = new System.Drawing.Point(7, 97);
            this.lbl_Senha.Name = "lbl_Senha";
            this.lbl_Senha.Size = new System.Drawing.Size(38, 13);
            this.lbl_Senha.TabIndex = 10;
            this.lbl_Senha.Text = "Senha";
            // 
            // Edt_Login
            // 
            this.Edt_Login.Location = new System.Drawing.Point(51, 55);
            this.Edt_Login.Name = "Edt_Login";
            this.Edt_Login.Size = new System.Drawing.Size(115, 20);
            this.Edt_Login.TabIndex = 9;
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.Location = new System.Drawing.Point(6, 58);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(33, 13);
            this.lbl_Login.TabIndex = 8;
            this.lbl_Login.Text = "Login";
            // 
            // Edt_Nivel
            // 
            this.Edt_Nivel.FormattingEnabled = true;
            this.Edt_Nivel.Location = new System.Drawing.Point(221, 12);
            this.Edt_Nivel.Name = "Edt_Nivel";
            this.Edt_Nivel.Size = new System.Drawing.Size(50, 21);
            this.Edt_Nivel.TabIndex = 7;
            // 
            // lbl_Cargo
            // 
            this.lbl_Cargo.AutoSize = true;
            this.lbl_Cargo.Location = new System.Drawing.Point(136, 16);
            this.lbl_Cargo.Name = "lbl_Cargo";
            this.lbl_Cargo.Size = new System.Drawing.Size(85, 13);
            this.lbl_Cargo.TabIndex = 6;
            this.lbl_Cargo.Text = "Nível de acesso";
            // 
            // Edt_IDFuncionario
            // 
            this.Edt_IDFuncionario.Location = new System.Drawing.Point(79, 12);
            this.Edt_IDFuncionario.Name = "Edt_IDFuncionario";
            this.Edt_IDFuncionario.Size = new System.Drawing.Size(50, 20);
            this.Edt_IDFuncionario.TabIndex = 5;
            // 
            // lbl_IDFuncionario
            // 
            this.lbl_IDFuncionario.AutoSize = true;
            this.lbl_IDFuncionario.Location = new System.Drawing.Point(3, 16);
            this.lbl_IDFuncionario.Name = "lbl_IDFuncionario";
            this.lbl_IDFuncionario.Size = new System.Drawing.Size(76, 13);
            this.lbl_IDFuncionario.TabIndex = 4;
            this.lbl_IDFuncionario.Text = "ID Funcionário";
            // 
            // Btn_Alterar
            // 
            this.Btn_Alterar.Location = new System.Drawing.Point(54, 201);
            this.Btn_Alterar.Name = "Btn_Alterar";
            this.Btn_Alterar.Size = new System.Drawing.Size(50, 23);
            this.Btn_Alterar.TabIndex = 1;
            this.Btn_Alterar.Text = "Alterar";
            this.Btn_Alterar.UseVisualStyleBackColor = true;
            this.Btn_Alterar.Click += new System.EventHandler(this.Btn_Alterar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.Btn_Limpar);
            this.tabPage2.Controls.Add(this.Btn_Consultar);
            this.tabPage2.Controls.Add(this.Edt_ConsultaLogin);
            this.tabPage2.Controls.Add(this.lbl_ConsultaLogin);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(275, 232);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            // 
            // Btn_Salvar
            // 
            this.Btn_Salvar.Image = global::pim3.Properties.Resources.Salvar;
            this.Btn_Salvar.Location = new System.Drawing.Point(181, 201);
            this.Btn_Salvar.Name = "Btn_Salvar";
            this.Btn_Salvar.Size = new System.Drawing.Size(40, 23);
            this.Btn_Salvar.TabIndex = 3;
            this.Btn_Salvar.UseVisualStyleBackColor = true;
            this.Btn_Salvar.Click += new System.EventHandler(this.Btn_Salvar_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Image = global::pim3.Properties.Resources.Cancelar;
            this.Btn_Cancelar.Location = new System.Drawing.Point(227, 201);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(40, 23);
            this.Btn_Cancelar.TabIndex = 2;
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Btn_Novo
            // 
            this.Btn_Novo.Image = global::pim3.Properties.Resources.Novo1;
            this.Btn_Novo.Location = new System.Drawing.Point(8, 201);
            this.Btn_Novo.Name = "Btn_Novo";
            this.Btn_Novo.Size = new System.Drawing.Size(40, 23);
            this.Btn_Novo.TabIndex = 0;
            this.Btn_Novo.UseVisualStyleBackColor = true;
            this.Btn_Novo.Click += new System.EventHandler(this.Btn_Novo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(268, 187);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // lbl_ConsultaLogin
            // 
            this.lbl_ConsultaLogin.AutoSize = true;
            this.lbl_ConsultaLogin.Location = new System.Drawing.Point(8, 11);
            this.lbl_ConsultaLogin.Name = "lbl_ConsultaLogin";
            this.lbl_ConsultaLogin.Size = new System.Drawing.Size(33, 13);
            this.lbl_ConsultaLogin.TabIndex = 1;
            this.lbl_ConsultaLogin.Text = "Login";
            // 
            // Edt_ConsultaLogin
            // 
            this.Edt_ConsultaLogin.Location = new System.Drawing.Point(47, 8);
            this.Edt_ConsultaLogin.Name = "Edt_ConsultaLogin";
            this.Edt_ConsultaLogin.Size = new System.Drawing.Size(82, 20);
            this.Edt_ConsultaLogin.TabIndex = 2;
            // 
            // Btn_Consultar
            // 
            this.Btn_Consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Consultar.Location = new System.Drawing.Point(135, 6);
            this.Btn_Consultar.Name = "Btn_Consultar";
            this.Btn_Consultar.Size = new System.Drawing.Size(73, 23);
            this.Btn_Consultar.TabIndex = 3;
            this.Btn_Consultar.Text = "Consultar";
            this.Btn_Consultar.UseVisualStyleBackColor = true;
            this.Btn_Consultar.Click += new System.EventHandler(this.Btn_Consultar_Click);
            // 
            // Btn_Limpar
            // 
            this.Btn_Limpar.Location = new System.Drawing.Point(214, 6);
            this.Btn_Limpar.Name = "Btn_Limpar";
            this.Btn_Limpar.Size = new System.Drawing.Size(53, 23);
            this.Btn_Limpar.TabIndex = 4;
            this.Btn_Limpar.Text = "Limpar";
            this.Btn_Limpar.UseVisualStyleBackColor = true;
            this.Btn_Limpar.Click += new System.EventHandler(this.Btn_Limpar_Click);
            // 
            // Edt_IDLogin
            // 
            this.Edt_IDLogin.Location = new System.Drawing.Point(60, 146);
            this.Edt_IDLogin.Name = "Edt_IDLogin";
            this.Edt_IDLogin.Size = new System.Drawing.Size(33, 20);
            this.Edt_IDLogin.TabIndex = 13;
            // 
            // lbl_IDLogin
            // 
            this.lbl_IDLogin.AutoSize = true;
            this.lbl_IDLogin.Location = new System.Drawing.Point(7, 149);
            this.lbl_IDLogin.Name = "lbl_IDLogin";
            this.lbl_IDLogin.Size = new System.Drawing.Size(47, 13);
            this.lbl_IDLogin.TabIndex = 14;
            this.lbl_IDLogin.Text = "ID Login";
            // 
            // Frm_CadLoginFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tabControl1);
            this.Name = "Frm_CadLoginFuncionario";
            this.Text = "Cadastro de Login para Funcionarios";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Btn_Alterar;
        private System.Windows.Forms.Button Btn_Novo;
        private System.Windows.Forms.Button Btn_Salvar;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Label lbl_IDFuncionario;
        private System.Windows.Forms.TextBox Edt_IDFuncionario;
        private System.Windows.Forms.Label lbl_Cargo;
        private System.Windows.Forms.ComboBox Edt_Nivel;
        private System.Windows.Forms.CheckBox Edt_Ativo;
        private System.Windows.Forms.TextBox Edt_Senha;
        private System.Windows.Forms.Label lbl_Senha;
        private System.Windows.Forms.TextBox Edt_Login;
        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.TextBox Edt_ConsultaLogin;
        private System.Windows.Forms.Label lbl_ConsultaLogin;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btn_Limpar;
        private System.Windows.Forms.Button Btn_Consultar;
        private System.Windows.Forms.Label lbl_IDLogin;
        private System.Windows.Forms.TextBox Edt_IDLogin;
    }
}