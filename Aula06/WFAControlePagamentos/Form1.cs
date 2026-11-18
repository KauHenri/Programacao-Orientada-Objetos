using System;
using System.Windows.Forms;

namespace WFAControlePagamentos
{
    public partial class Form1 : Form
    {
        int contaSaude = 0;
        int contaAlim = 0;

        public Form1()
        {
            InitializeComponent();
            rbSaude.Checked = true;
        }

        private void LimparCampos()
        {
            tbValor.Clear();
            tbCod.Clear();
            tbDetalhe.Clear();
            tbValor.Focus();
        }

        private void rbSaude_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSaude.Checked)
            {
                lblDetalhe.Text = "Estabelecimento:";
                LimparCampos();
            }
        }

        private void rbAlimentacao_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAlimentacao.Checked)
            {
                lblDetalhe.Text = "Descrição:";
                LimparCampos();
            }
        }

        private void btnFaturar_Click(object sender, EventArgs e)
        {
            string textoOriginal = tbCpf.Text;
            string cpfLimpo = textoOriginal.Replace(".", "")
                                           .Replace("-", "")
                                           .Replace(" ", "")
                                           .Replace("_", "")
                                           .Replace(",", "")
                                           .Trim();

            if (cpfLimpo.Length != 11 || !long.TryParse(cpfLimpo, out long cpf))
            {
                MessageBox.Show("O CPF deve conter exatamente 11 números.");
                tbCpf.Focus();
                return;
            }

            if (!double.TryParse(tbValor.Text, out double valor))
            {
                MessageBox.Show("Erro no Valor: Digite apenas números.");
                tbValor.Focus();
                return;
            }

            if (!int.TryParse(tbCod.Text, out int cod))
            {
                MessageBox.Show("Erro no Código: Digite apenas números inteiros.");
                tbCod.Focus();
                return;
            }

            string detalhe = tbDetalhe.Text;
            if (string.IsNullOrWhiteSpace(detalhe))
            {
                MessageBox.Show("Preencha o campo de " + lblDetalhe.Text.Replace(":", ""));
                tbDetalhe.Focus();
                return;
            }

            try
            {
                string nome = tbNome.Text;

                if (rbSaude.Checked)
                {
                    if (contaSaude >= 3)
                    {
                        MessageBox.Show("Limite de Saúde atingido!");
                        return;
                    }

                    Saude s = new Saude();
                    s.setCpf(cpf);
                    s.setValor(valor);
                    s.setCod(cod);
                    s.setEstabelecimento(detalhe);

                    s.faturar();

                    ListViewItem linha = new ListViewItem("Saúde");
                    linha.SubItems.Add(nome);
                    linha.SubItems.Add(s.getCpf().ToString());
                    linha.SubItems.Add(s.getValor().ToString("C2"));
                    linha.SubItems.Add(s.getVlfatSaude().ToString("C2"));
                    linha.SubItems.Add(s.getEstabelecimento());

                    listView1.Items.Add(linha);
                    contaSaude++;
                }
                else if (rbAlimentacao.Checked)
                {
                    if (contaAlim >= 3)
                    {
                        MessageBox.Show("Limite de Alimentação atingido!");
                        return;
                    }

                    Alimentacao a = new Alimentacao();
                    a.setCpf(cpf);
                    a.setValor(valor);
                    a.setCod(cod);
                    a.setDescricao(detalhe);

                    a.faturar();

                    ListViewItem linha = new ListViewItem("Alimentação");
                    linha.SubItems.Add(nome);
                    linha.SubItems.Add(a.getCpf().ToString());
                    linha.SubItems.Add(a.getValor().ToString("C2"));
                    linha.SubItems.Add(a.getVlfatAliment().ToString("C2"));
                    linha.SubItems.Add(a.getDescricao());

                    listView1.Items.Add(linha);
                    contaAlim++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado: " + ex.Message);
            }
        }

        private void lblDetalhe_Click(object sender, EventArgs e)
        {

        }
    }
}