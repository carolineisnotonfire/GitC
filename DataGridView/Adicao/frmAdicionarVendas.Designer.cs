namespace DataGridView.Adicao
{
    partial class frmAdicionarVendas
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.vendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.querysInnerJoinDataSet1 = new DataGridView.QuerysInnerJoinDataSet1();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.vendasTableAdapter = new DataGridView.QuerysInnerJoinDataSet1TableAdapters.VendasTableAdapter();
            this.carrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carrosTableAdapter = new DataGridView.QuerysInnerJoinDataSet1TableAdapters.CarrosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.querysInnerJoinDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(207, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Carro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantidade:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.carrosBindingSource;
            this.comboBox1.DisplayMember = "Modelo";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(119, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(283, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.ValueMember = "Id";
            // 
            // vendasBindingSource
            // 
            this.vendasBindingSource.DataMember = "Vendas";
            this.vendasBindingSource.DataSource = this.querysInnerJoinDataSet1;
            // 
            // querysInnerJoinDataSet1
            // 
            this.querysInnerJoinDataSet1.DataSetName = "QuerysInnerJoinDataSet1";
            this.querysInnerJoinDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 130);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(283, 22);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(119, 83);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(283, 22);
            this.textBox2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valor:";
            // 
            // vendasTableAdapter
            // 
            this.vendasTableAdapter.ClearBeforeFill = true;
            // 
            // carrosBindingSource
            // 
            this.carrosBindingSource.DataMember = "Carros";
            this.carrosBindingSource.DataSource = this.querysInnerJoinDataSet1;
            // 
            // carrosTableAdapter
            // 
            this.carrosTableAdapter.ClearBeforeFill = true;
            // 
            // frmAdicionarVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(414, 244);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "frmAdicionarVendas";
            this.Text = "Adicionar vendas";
            this.Load += new System.EventHandler(this.FrmAdicionarVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.querysInnerJoinDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private QuerysInnerJoinDataSet1 querysInnerJoinDataSet1;
        private System.Windows.Forms.BindingSource vendasBindingSource;
        private QuerysInnerJoinDataSet1TableAdapters.VendasTableAdapter vendasTableAdapter;
        private System.Windows.Forms.BindingSource carrosBindingSource;
        private QuerysInnerJoinDataSet1TableAdapters.CarrosTableAdapter carrosTableAdapter;
    }
}