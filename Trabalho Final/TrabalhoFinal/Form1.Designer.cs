namespace TrabalhoFinal
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.mtbCpf = new System.Windows.Forms.MaskedTextBox();
            this.dgvAlunos = new System.Windows.Forms.DataGridView();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbCpf = new System.Windows.Forms.Label();
            this.lbMatricula = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.numQuantidade = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDeletarLivros = new System.Windows.Forms.Button();
            this.btnAtualizarLivros = new System.Windows.Forms.Button();
            this.btnGravarLivros = new System.Windows.Forms.Button();
            this.dgvLivros = new System.Windows.Forms.DataGridView();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.dgvEmprestimos = new System.Windows.Forms.DataGridView();
            this.dtpDataRetirada = new System.Windows.Forms.DateTimePicker();
            this.cbLivro = new System.Windows.Forms.ComboBox();
            this.cbAluno = new System.Windows.Forms.ComboBox();
            this.btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestimos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(653, 554);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnDeletar);
            this.tabPage1.Controls.Add(this.btnAtualizar);
            this.tabPage1.Controls.Add(this.btnGravar);
            this.tabPage1.Controls.Add(this.mtbCpf);
            this.tabPage1.Controls.Add(this.dgvAlunos);
            this.tabPage1.Controls.Add(this.txtMatricula);
            this.tabPage1.Controls.Add(this.txtNome);
            this.tabPage1.Controls.Add(this.lbCpf);
            this.tabPage1.Controls.Add(this.lbMatricula);
            this.tabPage1.Controls.Add(this.lbNome);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(645, 516);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Aluno";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(339, 447);
            this.btnDeletar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(129, 44);
            this.btnDeletar.TabIndex = 14;
            this.btnDeletar.Text = "DELETAR";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(180, 447);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(152, 44);
            this.btnAtualizar.TabIndex = 13;
            this.btnAtualizar.Text = "ATUALIZAR";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(53, 447);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(120, 44);
            this.btnGravar.TabIndex = 12;
            this.btnGravar.Text = "GRAVAR";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // mtbCpf
            // 
            this.mtbCpf.Location = new System.Drawing.Point(249, 162);
            this.mtbCpf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtbCpf.Mask = "000\\.000\\.000-00";
            this.mtbCpf.Name = "mtbCpf";
            this.mtbCpf.Size = new System.Drawing.Size(235, 30);
            this.mtbCpf.TabIndex = 11;
            // 
            // dgvAlunos
            // 
            this.dgvAlunos.AllowUserToAddRows = false;
            this.dgvAlunos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlunos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunos.Location = new System.Drawing.Point(56, 246);
            this.dgvAlunos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAlunos.Name = "dgvAlunos";
            this.dgvAlunos.RowHeadersVisible = false;
            this.dgvAlunos.RowHeadersWidth = 51;
            this.dgvAlunos.RowTemplate.Height = 24;
            this.dgvAlunos.Size = new System.Drawing.Size(523, 172);
            this.dgvAlunos.TabIndex = 10;
            this.dgvAlunos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlunos_CellDoubleClick);
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(249, 110);
            this.txtMatricula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(235, 30);
            this.txtMatricula.TabIndex = 8;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(249, 58);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(235, 30);
            this.txtNome.TabIndex = 7;
            // 
            // lbCpf
            // 
            this.lbCpf.AutoSize = true;
            this.lbCpf.Location = new System.Drawing.Point(135, 167);
            this.lbCpf.Name = "lbCpf";
            this.lbCpf.Size = new System.Drawing.Size(58, 25);
            this.lbCpf.TabIndex = 2;
            this.lbCpf.Text = "CPF:";
            // 
            // lbMatricula
            // 
            this.lbMatricula.AutoSize = true;
            this.lbMatricula.Location = new System.Drawing.Point(135, 114);
            this.lbMatricula.Name = "lbMatricula";
            this.lbMatricula.Size = new System.Drawing.Size(97, 25);
            this.lbMatricula.TabIndex = 1;
            this.lbMatricula.Text = "Matricula:";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(135, 63);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(70, 25);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Nome:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.numQuantidade);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.btnDeletarLivros);
            this.tabPage2.Controls.Add(this.btnAtualizarLivros);
            this.tabPage2.Controls.Add(this.btnGravarLivros);
            this.tabPage2.Controls.Add(this.dgvLivros);
            this.tabPage2.Controls.Add(this.txtAutor);
            this.tabPage2.Controls.Add(this.txtTitulo);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(645, 516);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Livro";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // numQuantidade
            // 
            this.numQuantidade.Location = new System.Drawing.Point(267, 183);
            this.numQuantidade.Margin = new System.Windows.Forms.Padding(4);
            this.numQuantidade.Name = "numQuantidade";
            this.numQuantidade.Size = new System.Drawing.Size(65, 30);
            this.numQuantidade.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 191);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Quantidade:";
            // 
            // btnDeletarLivros
            // 
            this.btnDeletarLivros.Location = new System.Drawing.Point(339, 447);
            this.btnDeletarLivros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeletarLivros.Name = "btnDeletarLivros";
            this.btnDeletarLivros.Size = new System.Drawing.Size(129, 44);
            this.btnDeletarLivros.TabIndex = 14;
            this.btnDeletarLivros.Text = "DELETAR";
            this.btnDeletarLivros.UseVisualStyleBackColor = true;
            this.btnDeletarLivros.Click += new System.EventHandler(this.btnDeletarLivros_Click);
            // 
            // btnAtualizarLivros
            // 
            this.btnAtualizarLivros.Location = new System.Drawing.Point(180, 447);
            this.btnAtualizarLivros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAtualizarLivros.Name = "btnAtualizarLivros";
            this.btnAtualizarLivros.Size = new System.Drawing.Size(152, 44);
            this.btnAtualizarLivros.TabIndex = 13;
            this.btnAtualizarLivros.Text = "ATUALIZAR";
            this.btnAtualizarLivros.UseVisualStyleBackColor = true;
            this.btnAtualizarLivros.Click += new System.EventHandler(this.btnAtualizarLivros_Click);
            // 
            // btnGravarLivros
            // 
            this.btnGravarLivros.Location = new System.Drawing.Point(53, 447);
            this.btnGravarLivros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGravarLivros.Name = "btnGravarLivros";
            this.btnGravarLivros.Size = new System.Drawing.Size(120, 44);
            this.btnGravarLivros.TabIndex = 12;
            this.btnGravarLivros.Text = "GRAVAR";
            this.btnGravarLivros.UseVisualStyleBackColor = true;
            this.btnGravarLivros.Click += new System.EventHandler(this.btnGravarLivros_Click);
            // 
            // dgvLivros
            // 
            this.dgvLivros.AllowUserToAddRows = false;
            this.dgvLivros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLivros.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivros.Location = new System.Drawing.Point(53, 247);
            this.dgvLivros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvLivros.Name = "dgvLivros";
            this.dgvLivros.RowHeadersVisible = false;
            this.dgvLivros.RowHeadersWidth = 51;
            this.dgvLivros.RowTemplate.Height = 24;
            this.dgvLivros.Size = new System.Drawing.Size(523, 172);
            this.dgvLivros.TabIndex = 11;
            this.dgvLivros.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLivros_CellDoubleClick);
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(267, 132);
            this.txtAutor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(215, 30);
            this.txtAutor.TabIndex = 4;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(267, 78);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(215, 30);
            this.txtTitulo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Autor do Livro:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Título do Livro:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.btnRelatorio);
            this.tabPage3.Controls.Add(this.dgvEmprestimos);
            this.tabPage3.Controls.Add(this.dtpDataRetirada);
            this.tabPage3.Controls.Add(this.cbLivro);
            this.tabPage3.Controls.Add(this.cbAluno);
            this.tabPage3.Controls.Add(this.btn);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(645, 516);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Empréstimo";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "Data de retirada:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "Livro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "Aluno:";
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Location = new System.Drawing.Point(224, 182);
            this.btnRelatorio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(161, 44);
            this.btnRelatorio.TabIndex = 22;
            this.btnRelatorio.Text = "RELATÓRIO";
            this.btnRelatorio.UseVisualStyleBackColor = true;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // dgvEmprestimos
            // 
            this.dgvEmprestimos.AllowUserToAddRows = false;
            this.dgvEmprestimos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmprestimos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvEmprestimos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmprestimos.Location = new System.Drawing.Point(39, 245);
            this.dgvEmprestimos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvEmprestimos.Name = "dgvEmprestimos";
            this.dgvEmprestimos.RowHeadersVisible = false;
            this.dgvEmprestimos.RowHeadersWidth = 51;
            this.dgvEmprestimos.RowTemplate.Height = 24;
            this.dgvEmprestimos.Size = new System.Drawing.Size(536, 172);
            this.dgvEmprestimos.TabIndex = 21;
            this.dgvEmprestimos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmprestimos_CellDoubleClick);
            // 
            // dtpDataRetirada
            // 
            this.dtpDataRetirada.Location = new System.Drawing.Point(195, 132);
            this.dtpDataRetirada.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDataRetirada.Name = "dtpDataRetirada";
            this.dtpDataRetirada.Size = new System.Drawing.Size(241, 30);
            this.dtpDataRetirada.TabIndex = 20;
            // 
            // cbLivro
            // 
            this.cbLivro.FormattingEnabled = true;
            this.cbLivro.Location = new System.Drawing.Point(195, 90);
            this.cbLivro.Margin = new System.Windows.Forms.Padding(4);
            this.cbLivro.Name = "cbLivro";
            this.cbLivro.Size = new System.Drawing.Size(241, 33);
            this.cbLivro.TabIndex = 19;
            // 
            // cbAluno
            // 
            this.cbAluno.FormattingEnabled = true;
            this.cbAluno.Location = new System.Drawing.Point(195, 48);
            this.cbAluno.Margin = new System.Windows.Forms.Padding(4);
            this.cbAluno.Name = "cbAluno";
            this.cbAluno.Size = new System.Drawing.Size(241, 33);
            this.cbAluno.TabIndex = 18;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(321, 446);
            this.btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(145, 44);
            this.btn.TabIndex = 17;
            this.btn.Text = "DEVOLVER";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(164, 446);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 44);
            this.button2.TabIndex = 16;
            this.button2.Text = "ATUALIZAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnAtualizarEmprestimo_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(39, 446);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 44);
            this.button3.TabIndex = 15;
            this.button3.Text = "GRAVAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnGravarEmprestimo_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(477, 481);
            this.btnSair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(103, 44);
            this.btnSair.TabIndex = 16;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 555);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestimos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lbCpf;
        private System.Windows.Forms.Label lbMatricula;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DataGridView dgvAlunos;
        private System.Windows.Forms.MaskedTextBox mtbCpf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.DataGridView dgvLivros;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnDeletarLivros;
        private System.Windows.Forms.Button btnAtualizarLivros;
        private System.Windows.Forms.Button btnGravarLivros;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numQuantidade;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dtpDataRetirada;
        private System.Windows.Forms.ComboBox cbLivro;
        private System.Windows.Forms.ComboBox cbAluno;
        private System.Windows.Forms.DataGridView dgvEmprestimos;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

