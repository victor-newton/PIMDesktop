namespace pim3.formularios
{
    partial class Frm_SetorCargo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_SetorCargo));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Grid_Setor = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_Deletar = new System.Windows.Forms.Button();
            this.Btn_Salvar = new System.Windows.Forms.Button();
            this.Edt_Setor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Grid_Cargo = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Btn_ExcluiCargo = new System.Windows.Forms.Button();
            this.Btn_SalvarCargo = new System.Windows.Forms.Button();
            this.Edt_Cargo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Edt_IDSetor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Edt_Setor2 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Setor)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Cargo)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(372, 284);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Grid_Setor);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(364, 258);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Setor";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Grid_Setor
            // 
            this.Grid_Setor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Setor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid_Setor.Location = new System.Drawing.Point(3, 36);
            this.Grid_Setor.Name = "Grid_Setor";
            this.Grid_Setor.Size = new System.Drawing.Size(358, 219);
            this.Grid_Setor.TabIndex = 1;
            this.Grid_Setor.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Grid_Setor_CellMouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.Btn_Deletar);
            this.groupBox1.Controls.Add(this.Btn_Salvar);
            this.groupBox1.Controls.Add(this.Edt_Setor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 33);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // Btn_Deletar
            // 
            this.Btn_Deletar.BackgroundImage = global::pim3.Properties.Resources.limpar;
            this.Btn_Deletar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Deletar.Location = new System.Drawing.Point(322, 2);
            this.Btn_Deletar.Name = "Btn_Deletar";
            this.Btn_Deletar.Size = new System.Drawing.Size(25, 25);
            this.Btn_Deletar.TabIndex = 3;
            this.Btn_Deletar.UseVisualStyleBackColor = true;
            this.Btn_Deletar.Click += new System.EventHandler(this.Btn_Deletar_Click);
            // 
            // Btn_Salvar
            // 
            this.Btn_Salvar.BackgroundImage = global::pim3.Properties.Resources.Salvar;
            this.Btn_Salvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Salvar.Location = new System.Drawing.Point(291, 2);
            this.Btn_Salvar.Name = "Btn_Salvar";
            this.Btn_Salvar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Btn_Salvar.Size = new System.Drawing.Size(25, 25);
            this.Btn_Salvar.TabIndex = 2;
            this.Btn_Salvar.UseVisualStyleBackColor = true;
            this.Btn_Salvar.Click += new System.EventHandler(this.Btn_Salvar_Click);
            // 
            // Edt_Setor
            // 
            this.Edt_Setor.Location = new System.Drawing.Point(44, 5);
            this.Edt_Setor.Name = "Edt_Setor";
            this.Edt_Setor.Size = new System.Drawing.Size(241, 20);
            this.Edt_Setor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Setor";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Grid_Cargo);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(364, 258);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cargo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Grid_Cargo
            // 
            this.Grid_Cargo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Cargo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid_Cargo.Location = new System.Drawing.Point(3, 63);
            this.Grid_Cargo.Name = "Grid_Cargo";
            this.Grid_Cargo.Size = new System.Drawing.Size(358, 192);
            this.Grid_Cargo.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Btn_ExcluiCargo);
            this.groupBox3.Controls.Add(this.Btn_SalvarCargo);
            this.groupBox3.Controls.Add(this.Edt_Cargo);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(358, 30);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // Btn_ExcluiCargo
            // 
            this.Btn_ExcluiCargo.BackgroundImage = global::pim3.Properties.Resources.limpar;
            this.Btn_ExcluiCargo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_ExcluiCargo.Location = new System.Drawing.Point(327, 1);
            this.Btn_ExcluiCargo.Name = "Btn_ExcluiCargo";
            this.Btn_ExcluiCargo.Size = new System.Drawing.Size(25, 25);
            this.Btn_ExcluiCargo.TabIndex = 5;
            this.Btn_ExcluiCargo.UseVisualStyleBackColor = true;
            this.Btn_ExcluiCargo.Click += new System.EventHandler(this.Btn_ExcluiCargo_Click);
            // 
            // Btn_SalvarCargo
            // 
            this.Btn_SalvarCargo.BackgroundImage = global::pim3.Properties.Resources.Salvar;
            this.Btn_SalvarCargo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_SalvarCargo.Cursor = System.Windows.Forms.Cursors.Default;
            this.Btn_SalvarCargo.Location = new System.Drawing.Point(291, 2);
            this.Btn_SalvarCargo.Name = "Btn_SalvarCargo";
            this.Btn_SalvarCargo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Btn_SalvarCargo.Size = new System.Drawing.Size(25, 25);
            this.Btn_SalvarCargo.TabIndex = 4;
            this.Btn_SalvarCargo.UseVisualStyleBackColor = true;
            this.Btn_SalvarCargo.Click += new System.EventHandler(this.Btn_SalvaCargo_Click);
            // 
            // Edt_Cargo
            // 
            this.Edt_Cargo.Location = new System.Drawing.Point(44, 5);
            this.Edt_Cargo.Name = "Edt_Cargo";
            this.Edt_Cargo.Size = new System.Drawing.Size(241, 20);
            this.Edt_Cargo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cargo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Edt_IDSetor);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.Edt_Setor2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 30);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // Edt_IDSetor
            // 
            this.Edt_IDSetor.Location = new System.Drawing.Point(291, 5);
            this.Edt_IDSetor.Name = "Edt_IDSetor";
            this.Edt_IDSetor.Size = new System.Drawing.Size(61, 20);
            this.Edt_IDSetor.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Setor";
            // 
            // Edt_Setor2
            // 
            this.Edt_Setor2.Location = new System.Drawing.Point(44, 5);
            this.Edt_Setor2.Name = "Edt_Setor2";
            this.Edt_Setor2.Size = new System.Drawing.Size(241, 20);
            this.Edt_Setor2.TabIndex = 1;
            // 
            // Frm_SetorCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 284);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_SetorCargo";
            this.Text = "Setor e Cargo";
            this.Shown += new System.EventHandler(this.Frm_SetorCargo_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Setor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Cargo)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView Grid_Setor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_Deletar;
        private System.Windows.Forms.Button Btn_Salvar;
        private System.Windows.Forms.TextBox Edt_Setor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Grid_Cargo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Btn_ExcluiCargo;
        private System.Windows.Forms.Button Btn_SalvarCargo;
        private System.Windows.Forms.TextBox Edt_Cargo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Edt_Setor2;
        private System.Windows.Forms.TextBox Edt_IDSetor;
    }
}