namespace WFAControlePagamentos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbSaude = new System.Windows.Forms.RadioButton();
            this.rbAlimentacao = new System.Windows.Forms.RadioButton();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.tbCod = new System.Windows.Forms.TextBox();
            this.tbCpf = new System.Windows.Forms.MaskedTextBox();
            this.tbDetalhe = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblDetalhe = new System.Windows.Forms.Label();
            this.btnFaturar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbSaude
            // 
            this.rbSaude.AutoSize = true;
            this.rbSaude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSaude.Location = new System.Drawing.Point(106, 28);
            this.rbSaude.Name = "rbSaude";
            this.rbSaude.Size = new System.Drawing.Size(91, 29);
            this.rbSaude.TabIndex = 0;
            this.rbSaude.TabStop = true;
            this.rbSaude.Text = "Saúde";
            this.rbSaude.UseVisualStyleBackColor = true;
            this.rbSaude.CheckedChanged += new System.EventHandler(this.rbSaude_CheckedChanged);
            // 
            // rbAlimentacao
            // 
            this.rbAlimentacao.AutoSize = true;
            this.rbAlimentacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAlimentacao.Location = new System.Drawing.Point(446, 28);
            this.rbAlimentacao.Name = "rbAlimentacao";
            this.rbAlimentacao.Size = new System.Drawing.Size(141, 29);
            this.rbAlimentacao.TabIndex = 1;
            this.rbAlimentacao.TabStop = true;
            this.rbAlimentacao.Text = "Alimentação";
            this.rbAlimentacao.UseVisualStyleBackColor = true;
            this.rbAlimentacao.CheckedChanged += new System.EventHandler(this.rbAlimentacao_CheckedChanged);
            // 
            // tbNome
            // 
            this.tbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNome.Location = new System.Drawing.Point(285, 80);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(169, 30);
            this.tbNome.TabIndex = 2;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(209, 83);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(70, 25);
            this.lbNome.TabIndex = 3;
            this.lbNome.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(221, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "CPF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(215, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Valor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(198, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Código:";
            // 
            // tbValor
            // 
            this.tbValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbValor.Location = new System.Drawing.Point(285, 204);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(169, 30);
            this.tbValor.TabIndex = 7;
            // 
            // tbCod
            // 
            this.tbCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCod.Location = new System.Drawing.Point(285, 273);
            this.tbCod.Name = "tbCod";
            this.tbCod.Size = new System.Drawing.Size(169, 30);
            this.tbCod.TabIndex = 8;
            // 
            // tbCpf
            // 
            this.tbCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCpf.Location = new System.Drawing.Point(285, 142);
            this.tbCpf.Mask = "000\\.000\\.000-00";
            this.tbCpf.Name = "tbCpf";
            this.tbCpf.Size = new System.Drawing.Size(169, 30);
            this.tbCpf.TabIndex = 9;
            // 
            // tbDetalhe
            // 
            this.tbDetalhe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDetalhe.Location = new System.Drawing.Point(285, 339);
            this.tbDetalhe.Name = "tbDetalhe";
            this.tbDetalhe.Size = new System.Drawing.Size(169, 30);
            this.tbDetalhe.TabIndex = 10;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(106, 490);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(481, 126);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tipo";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "CPF";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Valor";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Total";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Detalhe";
            // 
            // lblDetalhe
            // 
            this.lblDetalhe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalhe.Location = new System.Drawing.Point(83, 342);
            this.lblDetalhe.Name = "lblDetalhe";
            this.lblDetalhe.Size = new System.Drawing.Size(196, 25);
            this.lblDetalhe.TabIndex = 12;
            this.lblDetalhe.Text = "Desc/Estab:";
            this.lblDetalhe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDetalhe.Click += new System.EventHandler(this.lblDetalhe_Click);
            // 
            // btnFaturar
            // 
            this.btnFaturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFaturar.Location = new System.Drawing.Point(270, 406);
            this.btnFaturar.Name = "btnFaturar";
            this.btnFaturar.Size = new System.Drawing.Size(136, 57);
            this.btnFaturar.TabIndex = 13;
            this.btnFaturar.Text = "Faturar";
            this.btnFaturar.UseVisualStyleBackColor = true;
            this.btnFaturar.Click += new System.EventHandler(this.btnFaturar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 628);
            this.Controls.Add(this.btnFaturar);
            this.Controls.Add(this.lblDetalhe);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.tbDetalhe);
            this.Controls.Add(this.tbCpf);
            this.Controls.Add(this.tbCod);
            this.Controls.Add(this.tbValor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.rbAlimentacao);
            this.Controls.Add(this.rbSaude);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbSaude;
        private System.Windows.Forms.RadioButton rbAlimentacao;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.TextBox tbCod;
        private System.Windows.Forms.MaskedTextBox tbCpf;
        private System.Windows.Forms.TextBox tbDetalhe;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lblDetalhe;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnFaturar;
    }
}

