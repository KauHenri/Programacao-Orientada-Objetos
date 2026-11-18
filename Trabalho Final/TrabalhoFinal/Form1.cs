using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace TrabalhoFinal
{
    public partial class Form1 : Form
    {
        int idSelecionado = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AtualizarGridAlunos();
            AtualizarGridLivros();
            CarregarComboAlunos();
            CarregarComboLivros();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtMatricula.Text) ||
                !mtbCpf.MaskCompleted)
            {
                MessageBox.Show("Por favor, preencha todos os campos e digite o CPF inteiro!");
                return;
            }

            ConexaoString stringConexao = new ConexaoString();
            string conexao = stringConexao.ConnString();

            string sqlInsert = String.Format("INSERT INTO aluno (nome_aluno, matricula_aluno, cpf_aluno) VALUES ('{0}', '{1}', '{2}')", txtNome.Text, txtMatricula.Text, mtbCpf.Text);

            try
            {
                using (NpgsqlConnection con = new NpgsqlConnection(conexao))
                {
                    con.Open();
                    using (NpgsqlCommand cmdInsert = new NpgsqlCommand(sqlInsert, con))
                    {
                        cmdInsert.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Aluno cadastrado com sucesso!");
                txtNome.Clear();
                txtMatricula.Clear();
                mtbCpf.Clear();
                AtualizarGridAlunos();
                CarregarComboAlunos();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("23505"))
                {
                    MessageBox.Show("Atenção: Já existe um aluno cadastrado com esta Matrícula ou CPF!");
                }
                else
                {
                    MessageBox.Show("Erro ao gravar: " + ex.Message);
                }
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (idSelecionado == -1)
            {
                MessageBox.Show("Por favor, dê dois cliques em um aluno na tabela antes de deletar!");
                return;
            }

            DialogResult resposta = MessageBox.Show("Tem certeza absoluta que deseja deletar este aluno?", "Aviso Crítico", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resposta == DialogResult.No)
            {
                return;
            }

            ConexaoString stringConexao = new ConexaoString();
            string conexao = stringConexao.ConnString();

            string sql = String.Format("DELETE FROM aluno WHERE id_aluno = {0}", idSelecionado);

            try
            {
                using (NpgsqlConnection con = new NpgsqlConnection(conexao))
                {
                    con.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql, con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Aluno deletado com sucesso!");

                txtNome.Clear();
                txtMatricula.Clear();
                mtbCpf.Clear();

                idSelecionado = -1;
                AtualizarGridAlunos();
                CarregarComboAlunos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao deletar: " + ex.Message);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtMatricula.Text) ||
                !mtbCpf.MaskCompleted)
            {
                MessageBox.Show("Você não pode deixar campos em branco ao atualizar os dados do aluno!");
                return; 
            }

            if (idSelecionado == -1)
            {
                MessageBox.Show("Por favor, dê dois cliques em um aluno na tabela antes de atualizar!");
                return;
            }

            ConexaoString stringConexao = new ConexaoString();
            string conexao = stringConexao.ConnString();
            string sql = String.Format("UPDATE aluno SET nome_aluno = '{0}', matricula_aluno = '{1}', cpf_aluno = '{2}' WHERE id_aluno = '{3}'", txtNome.Text, txtMatricula.Text, mtbCpf.Text, idSelecionado);
            try
            {
                using (NpgsqlConnection con = new NpgsqlConnection(conexao))
                {
                    con.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql, con))
                    {
                        int linhasAfetadas = cmd.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Aluno atualizado com sucesso!");
                            txtNome.Clear();
                            txtMatricula.Clear();
                            mtbCpf.Clear();
                            idSelecionado = -1;
                            AtualizarGridAlunos();
                            CarregarComboAlunos();
                        }
                        else
                        {
                            MessageBox.Show("Nenhum aluno encontrado com essa matrícula.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("23505"))
                {
                    MessageBox.Show("Atenção: Já existe um aluno cadastrado com esta Matrícula ou CPF!");
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar: " + ex.Message);
                }
            }
        }

        public void AtualizarGridAlunos()
        {
            ConexaoString stringConexao = new ConexaoString();
            string conexao = stringConexao.ConnString();
            string sql = "SELECT * FROM aluno";

            try
            {
                using (NpgsqlConnection con = new NpgsqlConnection(conexao))
                {
                    con.Open();
                    using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con))
                    {
                        System.Data.DataTable dt = new System.Data.DataTable();
                        da.Fill(dt);
                        dgvAlunos.DataSource = dt; 
                        dgvAlunos.Columns["id_aluno"].Visible = false;
                        dgvAlunos.Columns["nome_aluno"].HeaderText = "Nome";
                        dgvAlunos.Columns["matricula_aluno"].HeaderText = "Matrícula";
                        dgvAlunos.Columns["cpf_aluno"].HeaderText = "CPF";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar a tabela: " + ex.Message);
            }
        }

        private void dgvAlunos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow linha = dgvAlunos.Rows[e.RowIndex];

                txtNome.Text = linha.Cells["nome_aluno"].Value.ToString();
                txtMatricula.Text = linha.Cells["matricula_aluno"].Value.ToString();
                mtbCpf.Text = linha.Cells["cpf_aluno"].Value.ToString();

                idSelecionado = Convert.ToInt32(linha.Cells["id_aluno"].Value);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Deseja realmente sair do sistema?", "Encerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnGravarLivros_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitulo.Text) || string.IsNullOrWhiteSpace(txtAutor.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos!");
                return;
            }

            ConexaoString stringConexao = new ConexaoString();
            string conexao = stringConexao.ConnString();

            string sqlVerifica = String.Format("SELECT id_livro FROM livro WHERE titulo_livro = '{0}' AND autor_livro = '{1}'", txtTitulo.Text, txtAutor.Text);

            try
            {
                using (NpgsqlConnection con = new NpgsqlConnection(conexao))
                {
                    con.Open();

                    int idExistente = -1; 

                    using (NpgsqlCommand cmdVerifica = new NpgsqlCommand(sqlVerifica, con))
                    {
                        using (NpgsqlDataReader leitor = cmdVerifica.ExecuteReader())
                        {
                            if (leitor.Read()) 
                            {
                                idExistente = Convert.ToInt32(leitor["id_livro"]); 
                            }
                        } 
                    }

                    if (idExistente != -1)
                    {
                        string sqlUpdate = String.Format("UPDATE livro SET quantidade_livro = quantidade_livro + {0} WHERE id_livro = {1}", numQuantidade.Value, idExistente);

                        using (NpgsqlCommand cmdUpdate = new NpgsqlCommand(sqlUpdate, con))
                        {
                            cmdUpdate.ExecuteNonQuery();
                        }
                        MessageBox.Show("Livro já existia no catálogo. Estoque adicionado com sucesso!");
                    }
                    else
                    {
                        string sqlInsert = String.Format("INSERT INTO livro (titulo_livro, autor_livro, quantidade_livro) VALUES ('{0}', '{1}', {2})", txtTitulo.Text, txtAutor.Text, numQuantidade.Value);

                        using (NpgsqlCommand cmdInsert = new NpgsqlCommand(sqlInsert, con))
                        {
                            cmdInsert.ExecuteNonQuery();
                        }
                        MessageBox.Show("Novo livro cadastrado com sucesso!");
                    }
                }

                txtTitulo.Clear();
                txtAutor.Clear();
                numQuantidade.Value = 0;
                AtualizarGridLivros();
                CarregarComboLivros();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gravar: " + ex.Message);
            }
        }

        private void btnDeletarLivros_Click(object sender, EventArgs e)
        {
            if (idSelecionado == -1)
            {
                MessageBox.Show("Por favor, dê dois cliques em um livro na tabela antes de deletar!");
                return;
            }

            DialogResult resposta = MessageBox.Show("Tem certeza absoluta que deseja apagar este livro do sistema?", "Aviso Crítico", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resposta == DialogResult.No)
            {
                return;
            }

            ConexaoString stringConexao = new ConexaoString();
            string conexao = stringConexao.ConnString();

            string sql = String.Format("DELETE FROM livro WHERE id_livro = {0}", idSelecionado);

            try
            {
                using (NpgsqlConnection con = new NpgsqlConnection(conexao))
                {
                    con.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql, con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Livro deletado com sucesso!");

                txtTitulo.Clear();
                txtAutor.Clear();
                numQuantidade.Value = 0; 

                idSelecionado = -1;
                CarregarComboLivros();
                AtualizarGridLivros();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao deletar o livro: " + ex.Message);
            }
        }

        private void btnAtualizarLivros_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitulo.Text) || string.IsNullOrWhiteSpace(txtAutor.Text))
            {
                MessageBox.Show("Você não pode deixar o Título ou o Autor em branco!");
                return;
            }

            if (idSelecionado == -1)
            {
                MessageBox.Show("Por favor, dê dois cliques em um livro na tabela antes de atualizar!");
                return;
            }

            ConexaoString stringConexao = new ConexaoString();
            string conexao = stringConexao.ConnString();

            string sql = String.Format("UPDATE livro SET titulo_livro = '{0}', autor_livro = '{1}', quantidade_livro = {2} WHERE id_livro = {3}", txtTitulo.Text, txtAutor.Text, numQuantidade.Value, idSelecionado);

            try
            {
                using (NpgsqlConnection con = new NpgsqlConnection(conexao))
                {
                    con.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql, con))
                    {
                        int linhasAfetadas = cmd.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Livro/Estoque atualizado com sucesso!");
                            txtTitulo.Clear();
                            txtAutor.Clear();
                            numQuantidade.Value = 0;
                            idSelecionado = -1;
                            AtualizarGridLivros();
                            CarregarComboLivros();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar o livro: " + ex.Message);
            }
        }

        public void AtualizarGridLivros()
        {
            ConexaoString stringConexao = new ConexaoString();
            string conexao = stringConexao.ConnString();
            string sql = "SELECT * FROM livro";

            try
            {
                using (NpgsqlConnection con = new NpgsqlConnection(conexao))
                {
                    con.Open();
                    using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con))
                    {
                        System.Data.DataTable dt = new System.Data.DataTable();
                        da.Fill(dt);
                        dgvLivros.DataSource = dt;
                        dgvLivros.Columns["id_livro"].Visible = false;
                        dgvLivros.Columns["titulo_livro"].HeaderText = "Título";
                        dgvLivros.Columns["autor_livro"].HeaderText = "Autor";
                        dgvLivros.Columns["quantidade_livro"].HeaderText = "Quantidade";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar a tabela: " + ex.Message);
            }
        }

        private void dgvLivros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow linha = dgvLivros.Rows[e.RowIndex];

                txtTitulo.Text = linha.Cells["titulo_livro"].Value.ToString();
                txtAutor.Text = linha.Cells["autor_livro"].Value.ToString();
                numQuantidade.Value = Convert.ToDecimal(linha.Cells["quantidade_livro"].Value);

                idSelecionado = Convert.ToInt32(linha.Cells["id_livro"].Value);
            }
        }

        public void CarregarComboAlunos()
        {
            ConexaoString stringConexao = new ConexaoString();
            string conexao = stringConexao.ConnString();

            string sql = "SELECT id_aluno, nome_aluno FROM aluno";

            try
            {
                using (NpgsqlConnection con = new NpgsqlConnection(conexao))
                {
                    con.Open();
                    using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con))
                    {
                        System.Data.DataTable dt = new System.Data.DataTable();
                        da.Fill(dt);

                        cbAluno.DataSource = dt;
                        cbAluno.DisplayMember = "nome_aluno"; 
                        cbAluno.ValueMember = "id_aluno"; 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar alunos: " + ex.Message);
            }
        }

        public void CarregarComboLivros()
        {
            ConexaoString stringConexao = new ConexaoString();
            string conexao = stringConexao.ConnString();
            string sql = "SELECT id_livro, titulo_livro FROM livro";
            try
            {
                using (NpgsqlConnection con = new NpgsqlConnection(conexao))
                {
                    con.Open();
                    using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con))
                    {
                        System.Data.DataTable dt = new System.Data.DataTable();
                        da.Fill(dt);
                        cbLivro.DataSource = dt;
                        cbLivro.DisplayMember = "titulo_livro";
                        cbLivro.ValueMember = "id_livro"; 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar livros: " + ex.Message);
            }
        }

        private void btnGravarEmprestimo_Click(object sender, EventArgs e)
        {
            if (cbAluno.SelectedValue == null || cbLivro.SelectedValue == null)
            {
                MessageBox.Show("Por favor, selecione um aluno e um livro válidos!");
                return;
            }

            ConexaoString stringConexao = new ConexaoString();
            string conexao = stringConexao.ConnString();

            string dataFormatada = dtpDataRetirada.Value.ToString("yyyy-MM-dd");

            string sqlInsert = String.Format("INSERT INTO emprestimo (id_aluno, id_livro, data_retirada) VALUES ({0}, {1}, '{2}')", cbAluno.SelectedValue, cbLivro.SelectedValue, dataFormatada);

            string sqlBaixaEstoque = String.Format("UPDATE livro SET quantidade_livro = quantidade_livro - 1 WHERE id_livro = {0}", cbLivro.SelectedValue);

            try
            {
                using (NpgsqlConnection con = new NpgsqlConnection(conexao))
                {
                    con.Open();

                    using (NpgsqlCommand cmdInsert = new NpgsqlCommand(sqlInsert, con))
                    {
                        cmdInsert.ExecuteNonQuery();
                    }

                    using (NpgsqlCommand cmdBaixa = new NpgsqlCommand(sqlBaixaEstoque, con))
                    {
                        cmdBaixa.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Empréstimo registrado com sucesso!");

                AtualizarGridLivros();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gravar empréstimo: " + ex.Message);
            }
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            if (idSelecionado == -1)
            {
                MessageBox.Show("Por favor, dê dois cliques em um empréstimo na tabela antes de devolver!");
                return;
            }

            DialogResult resposta = MessageBox.Show("Confirma a devolução deste livro? O registro de empréstimo será apagado.", "Devolução", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.No)
            {
                return;
            }

            ConexaoString stringConexao = new ConexaoString();
            string conexao = stringConexao.ConnString();

            string sqlBuscaLivro = String.Format("SELECT id_livro FROM emprestimo WHERE id_emprestimo = {0}", idSelecionado);

            string sqlDelete = String.Format("DELETE FROM emprestimo WHERE id_emprestimo = {0}", idSelecionado);

            try
            {
                using (NpgsqlConnection con = new NpgsqlConnection(conexao))
                {
                    con.Open();
                    int idLivroDevolvido = -1;

                    using (NpgsqlCommand cmdBusca = new NpgsqlCommand(sqlBuscaLivro, con))
                    {
                        using (NpgsqlDataReader leitor = cmdBusca.ExecuteReader())
                        {
                            if (leitor.Read())
                            {
                                idLivroDevolvido = Convert.ToInt32(leitor["id_livro"]);
                            }
                        }
                    }

                    if (idLivroDevolvido != -1)
                    {
                        string sqlAumentaEstoque = String.Format("UPDATE livro SET quantidade_livro = quantidade_livro + 1 WHERE id_livro = {0}", idLivroDevolvido);
                        using (NpgsqlCommand cmdAumenta = new NpgsqlCommand(sqlAumentaEstoque, con))
                        {
                            cmdAumenta.ExecuteNonQuery();
                        }
                    }

                    using (NpgsqlCommand cmdDel = new NpgsqlCommand(sqlDelete, con))
                    {
                        cmdDel.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Livro devolvido com sucesso!");
                idSelecionado = -1;
                AtualizarGridLivros();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao devolver o livro: " + ex.Message);
            }
        }

        private void btnAtualizarEmprestimo_Click(object sender, EventArgs e)
        {
            if (idSelecionado == -1)
            {
                MessageBox.Show("Por favor, dê dois cliques em um empréstimo na tabela antes de atualizar!");
                return;
            }

            ConexaoString stringConexao = new ConexaoString();
            string conexao = stringConexao.ConnString();

            string dataFormatada = dtpDataRetirada.Value.ToString("yyyy-MM-dd");

            string sqlUpdate = String.Format("UPDATE emprestimo SET id_aluno = {0}, id_livro = {1}, data_retirada = '{2}' WHERE id_emprestimo = {3}", cbAluno.SelectedValue, cbLivro.SelectedValue, dataFormatada, idSelecionado);

            try
            {
                using (NpgsqlConnection con = new NpgsqlConnection(conexao))
                {
                    con.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(sqlUpdate, con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Registro de empréstimo corrigido com sucesso!");
                idSelecionado = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar o empréstimo: " + ex.Message);
            }
        }

        public void AtualizarGridEmprestimos()
        {
            ConexaoString stringConexao = new ConexaoString();
            string conexao = stringConexao.ConnString();
            string sql = "SELECT * FROM emprestimo";

            try
            {
                using (NpgsqlConnection con = new NpgsqlConnection(conexao))
                {
                    con.Open();
                    using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con))
                    {
                        System.Data.DataTable dt = new System.Data.DataTable();
                        da.Fill(dt);

                        dgvEmprestimos.DataSource = dt; 
                        dgvEmprestimos.Columns["id_emprestimo"].Visible = false;
                        dgvEmprestimos.Columns["id_aluno"].HeaderText = "ID Aluno";
                        dgvEmprestimos.Columns["id_livro"].HeaderText = "ID Livro";
                        dgvEmprestimos.Columns["data_retirada"].HeaderText = "Data de Retirada";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar a tabela de empréstimos: " + ex.Message);
            }
        }

        private void dgvEmprestimos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow linha = dgvEmprestimos.Rows[e.RowIndex];

                cbAluno.SelectedValue = Convert.ToInt32(linha.Cells["id_aluno"].Value);
                cbLivro.SelectedValue = Convert.ToInt32(linha.Cells["id_livro"].Value);

                dtpDataRetirada.Value = Convert.ToDateTime(linha.Cells["data_retirada"].Value);

                idSelecionado = Convert.ToInt32(linha.Cells["id_emprestimo"].Value);
            }
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            ConexaoString stringConexao = new ConexaoString();
            string conexao = stringConexao.ConnString();
            string sql = @"SELECT 
							e.id_emprestimo, 
							e.id_aluno,
							e.id_livro,
							a.nome_aluno AS ""Nome do Aluno"", 
							l.titulo_livro AS ""Título do Livro"", 
							e.data_retirada
						   FROM emprestimo e
						   INNER JOIN aluno a ON e.id_aluno = a.id_aluno
						   INNER JOIN livro l ON e.id_livro = l.id_livro";

            try
            {
                using (NpgsqlConnection con = new NpgsqlConnection(conexao))
                {
                    con.Open();
                    using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, con))
                    {
                        System.Data.DataTable dt = new System.Data.DataTable();
                        da.Fill(dt);

                        dgvEmprestimos.DataSource = dt;
                        dgvEmprestimos.Columns["id_emprestimo"].Visible = false;
                        dgvEmprestimos.Columns["id_aluno"].Visible = false;
                        dgvEmprestimos.Columns["id_livro"].Visible = false;
                        dgvEmprestimos.Columns["data_retirada"].HeaderText = "Data de Retirada";
                    }
                }
                MessageBox.Show("Relatório gerado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar relatório: " + ex.Message);
            }
        }
    }

}

