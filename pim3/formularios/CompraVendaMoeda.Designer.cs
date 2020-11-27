
namespace pim3.formularios
{
    partial class Frm_CompraVendaMoeda
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CompraVendaMoeda));
            this.Group_Top = new System.Windows.Forms.GroupBox();
            this.Btn_Vender = new System.Windows.Forms.Button();
            this.Btn_Comprar = new System.Windows.Forms.Button();
            this.Edt_VlrNegociar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Edt_ValorAtual = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_Moeda = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Group_Detalhes = new System.Windows.Forms.GroupBox();
            this.Edt_UltTransacao = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Edt_VlrUltCompra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Edt_QtdUltCompra = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Edt_VlrObtido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Edt_QtdObtida = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.historicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.historicoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.uniCriptDataSet = new pim3.UniCriptDataSet();
            this.historicoTableAdapter = new pim3.UniCriptDataSetTableAdapters.HistoricoTableAdapter();
            this.Group_Top.SuspendLayout();
            this.Group_Detalhes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historicoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniCriptDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Group_Top
            // 
            this.Group_Top.Controls.Add(this.Btn_Vender);
            this.Group_Top.Controls.Add(this.Btn_Comprar);
            this.Group_Top.Controls.Add(this.Edt_VlrNegociar);
            this.Group_Top.Controls.Add(this.label3);
            this.Group_Top.Controls.Add(this.Edt_ValorAtual);
            this.Group_Top.Controls.Add(this.label2);
            this.Group_Top.Controls.Add(this.CB_Moeda);
            this.Group_Top.Controls.Add(this.label1);
            this.Group_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Group_Top.Location = new System.Drawing.Point(0, 0);
            this.Group_Top.Name = "Group_Top";
            this.Group_Top.Size = new System.Drawing.Size(1153, 45);
            this.Group_Top.TabIndex = 0;
            this.Group_Top.TabStop = false;
            // 
            // Btn_Vender
            // 
            this.Btn_Vender.Location = new System.Drawing.Point(775, 11);
            this.Btn_Vender.Name = "Btn_Vender";
            this.Btn_Vender.Size = new System.Drawing.Size(75, 23);
            this.Btn_Vender.TabIndex = 7;
            this.Btn_Vender.Text = "Vender";
            this.Btn_Vender.UseVisualStyleBackColor = true;
            this.Btn_Vender.Click += new System.EventHandler(this.Btn_Vender_Click);
            // 
            // Btn_Comprar
            // 
            this.Btn_Comprar.Location = new System.Drawing.Point(694, 11);
            this.Btn_Comprar.Name = "Btn_Comprar";
            this.Btn_Comprar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Comprar.TabIndex = 6;
            this.Btn_Comprar.Text = "Comprar";
            this.Btn_Comprar.UseVisualStyleBackColor = true;
            this.Btn_Comprar.Click += new System.EventHandler(this.Btn_Comprar_Click);
            // 
            // Edt_VlrNegociar
            // 
            this.Edt_VlrNegociar.Location = new System.Drawing.Point(526, 13);
            this.Edt_VlrNegociar.Name = "Edt_VlrNegociar";
            this.Edt_VlrNegociar.Size = new System.Drawing.Size(150, 20);
            this.Edt_VlrNegociar.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(413, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor a negociar (R$)";
            // 
            // Edt_ValorAtual
            // 
            this.Edt_ValorAtual.Enabled = false;
            this.Edt_ValorAtual.Location = new System.Drawing.Point(257, 13);
            this.Edt_ValorAtual.Name = "Edt_ValorAtual";
            this.Edt_ValorAtual.Size = new System.Drawing.Size(150, 20);
            this.Edt_ValorAtual.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor atual";
            // 
            // CB_Moeda
            // 
            this.CB_Moeda.FormattingEnabled = true;
            this.CB_Moeda.Location = new System.Drawing.Point(52, 13);
            this.CB_Moeda.Name = "CB_Moeda";
            this.CB_Moeda.Size = new System.Drawing.Size(135, 21);
            this.CB_Moeda.TabIndex = 1;
            this.CB_Moeda.SelectedIndexChanged += new System.EventHandler(this.CB_Moeda_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Moeda";
            // 
            // Group_Detalhes
            // 
            this.Group_Detalhes.Controls.Add(this.Edt_UltTransacao);
            this.Group_Detalhes.Controls.Add(this.label8);
            this.Group_Detalhes.Controls.Add(this.Edt_VlrUltCompra);
            this.Group_Detalhes.Controls.Add(this.label6);
            this.Group_Detalhes.Controls.Add(this.Edt_QtdUltCompra);
            this.Group_Detalhes.Controls.Add(this.label7);
            this.Group_Detalhes.Controls.Add(this.Edt_VlrObtido);
            this.Group_Detalhes.Controls.Add(this.label5);
            this.Group_Detalhes.Controls.Add(this.Edt_QtdObtida);
            this.Group_Detalhes.Controls.Add(this.label4);
            this.Group_Detalhes.Dock = System.Windows.Forms.DockStyle.Top;
            this.Group_Detalhes.Enabled = false;
            this.Group_Detalhes.Location = new System.Drawing.Point(0, 45);
            this.Group_Detalhes.Name = "Group_Detalhes";
            this.Group_Detalhes.Size = new System.Drawing.Size(1153, 68);
            this.Group_Detalhes.TabIndex = 1;
            this.Group_Detalhes.TabStop = false;
            this.Group_Detalhes.Visible = false;
            // 
            // Edt_UltTransacao
            // 
            this.Edt_UltTransacao.Location = new System.Drawing.Point(698, 13);
            this.Edt_UltTransacao.Name = "Edt_UltTransacao";
            this.Edt_UltTransacao.Size = new System.Drawing.Size(88, 20);
            this.Edt_UltTransacao.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(606, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Ultima transação";
            // 
            // Edt_VlrUltCompra
            // 
            this.Edt_VlrUltCompra.Location = new System.Drawing.Point(450, 39);
            this.Edt_VlrUltCompra.Name = "Edt_VlrUltCompra";
            this.Edt_VlrUltCompra.Size = new System.Drawing.Size(150, 20);
            this.Edt_VlrUltCompra.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(310, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Valor ultima transação (R$)";
            // 
            // Edt_QtdUltCompra
            // 
            this.Edt_QtdUltCompra.Location = new System.Drawing.Point(154, 39);
            this.Edt_QtdUltCompra.Name = "Edt_QtdUltCompra";
            this.Edt_QtdUltCompra.Size = new System.Drawing.Size(150, 20);
            this.Edt_QtdUltCompra.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Quantidade ultima transação";
            // 
            // Edt_VlrObtido
            // 
            this.Edt_VlrObtido.Location = new System.Drawing.Point(450, 13);
            this.Edt_VlrObtido.Name = "Edt_VlrObtido";
            this.Edt_VlrObtido.Size = new System.Drawing.Size(150, 20);
            this.Edt_VlrObtido.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Valor na carteira (R$)";
            // 
            // Edt_QtdObtida
            // 
            this.Edt_QtdObtida.Location = new System.Drawing.Point(154, 13);
            this.Edt_QtdObtida.Name = "Edt_QtdObtida";
            this.Edt_QtdObtida.Size = new System.Drawing.Size(150, 20);
            this.Edt_QtdObtida.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Quantidade na carteira";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Default;
            this.chart1.DataSource = this.historicoBindingSource1;
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 113);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueMember = "DataHora";
            series1.YValueMembers = "Valor";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1153, 385);
            this.chart1.TabIndex = 2;
            // 
            // historicoBindingSource
            // 
            this.historicoBindingSource.DataMember = "Historico";
            // 
            // historicoBindingSource1
            // 
            this.historicoBindingSource1.DataMember = "Historico";
            this.historicoBindingSource1.DataSource = this.uniCriptDataSet;
            // 
            // uniCriptDataSet
            // 
            this.uniCriptDataSet.DataSetName = "UniCriptDataSet";
            this.uniCriptDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // historicoTableAdapter
            // 
            this.historicoTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_CompraVendaMoeda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1153, 498);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.Group_Detalhes);
            this.Controls.Add(this.Group_Top);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_CompraVendaMoeda";
            this.Text = "Comprar e Vender Criptoativos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_CompraVendaMoeda_Load);
            this.Shown += new System.EventHandler(this.Frm_CompraVendaMoeda_Shown);
            this.Group_Top.ResumeLayout(false);
            this.Group_Top.PerformLayout();
            this.Group_Detalhes.ResumeLayout(false);
            this.Group_Detalhes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historicoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniCriptDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.GroupBox Group_Top;
        private System.Windows.Forms.Button Btn_Vender;
        private System.Windows.Forms.Button Btn_Comprar;
        private System.Windows.Forms.TextBox Edt_VlrNegociar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Edt_ValorAtual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CB_Moeda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Group_Detalhes;
        private System.Windows.Forms.TextBox Edt_VlrUltCompra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Edt_QtdUltCompra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Edt_VlrObtido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Edt_QtdObtida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Edt_UltTransacao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.BindingSource historicoBindingSource;
        private UniCriptDataSet uniCriptDataSet;
        private System.Windows.Forms.BindingSource historicoBindingSource1;
        private UniCriptDataSetTableAdapters.HistoricoTableAdapter historicoTableAdapter;

        #endregion
        // private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}