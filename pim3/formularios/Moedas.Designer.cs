namespace pim3.formularios
{
    partial class Frm_Moedas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Moedas));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Edt_Cod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Edt_Abrevicao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Edt_Descricao = new System.Windows.Forms.TextBox();
            this.Grd_Moedas = new System.Windows.Forms.DataGridView();
            this.Btn_Salvar = new System.Windows.Forms.Button();
            this.Btn_Limpar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Moedas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_Limpar);
            this.groupBox1.Controls.Add(this.Btn_Salvar);
            this.groupBox1.Controls.Add(this.Edt_Descricao);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Edt_Abrevicao);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Edt_Cod);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 69);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // Edt_Cod
            // 
            this.Edt_Cod.Enabled = false;
            this.Edt_Cod.Location = new System.Drawing.Point(61, 12);
            this.Edt_Cod.Name = "Edt_Cod";
            this.Edt_Cod.Size = new System.Drawing.Size(62, 20);
            this.Edt_Cod.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Abreviação";
            // 
            // Edt_Abrevicao
            // 
            this.Edt_Abrevicao.Location = new System.Drawing.Point(196, 12);
            this.Edt_Abrevicao.Name = "Edt_Abrevicao";
            this.Edt_Abrevicao.Size = new System.Drawing.Size(100, 20);
            this.Edt_Abrevicao.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descrição";
            // 
            // Edt_Descricao
            // 
            this.Edt_Descricao.Location = new System.Drawing.Point(61, 41);
            this.Edt_Descricao.Name = "Edt_Descricao";
            this.Edt_Descricao.Size = new System.Drawing.Size(235, 20);
            this.Edt_Descricao.TabIndex = 5;
            // 
            // Grd_Moedas
            // 
            this.Grd_Moedas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grd_Moedas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grd_Moedas.Location = new System.Drawing.Point(0, 69);
            this.Grd_Moedas.Name = "Grd_Moedas";
            this.Grd_Moedas.Size = new System.Drawing.Size(344, 193);
            this.Grd_Moedas.TabIndex = 1;
            // 
            // Btn_Salvar
            // 
            this.Btn_Salvar.BackgroundImage = global::pim3.Properties.Resources.Salvar;
            this.Btn_Salvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Salvar.Cursor = System.Windows.Forms.Cursors.Default;
            this.Btn_Salvar.Location = new System.Drawing.Point(307, 9);
            this.Btn_Salvar.Name = "Btn_Salvar";
            this.Btn_Salvar.Size = new System.Drawing.Size(25, 25);
            this.Btn_Salvar.TabIndex = 6;
            this.Btn_Salvar.UseVisualStyleBackColor = true;
            this.Btn_Salvar.Click += new System.EventHandler(this.Btn_Salvar_Click);
            // 
            // Btn_Limpar
            // 
            this.Btn_Limpar.BackgroundImage = global::pim3.Properties.Resources.limpar;
            this.Btn_Limpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Limpar.Location = new System.Drawing.Point(307, 38);
            this.Btn_Limpar.Name = "Btn_Limpar";
            this.Btn_Limpar.Size = new System.Drawing.Size(25, 25);
            this.Btn_Limpar.TabIndex = 7;
            this.Btn_Limpar.UseVisualStyleBackColor = true;
            this.Btn_Limpar.Click += new System.EventHandler(this.Btn_Limpar_Click);
            // 
            // Frm_Moedas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 262);
            this.Controls.Add(this.Grd_Moedas);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Moedas";
            this.Text = "Moedas";
            this.Shown += new System.EventHandler(this.Frm_Moedas_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grd_Moedas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Limpar;
        private System.Windows.Forms.Button Btn_Salvar;
        private System.Windows.Forms.TextBox Edt_Descricao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Edt_Abrevicao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Edt_Cod;
        private System.Windows.Forms.DataGridView Grd_Moedas;
    }
}