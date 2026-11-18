using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql; // Importa a biblioteca Npgsql para trabalhar com PostgreSQL

namespace WfaBDCliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Pessoa objPessoa = new Pessoa(mtbCpf.Text, tbNome.Text, Convert.ToDouble(tbSalario.Text));

            ConexaoString stringConexao = new ConexaoString(); // objeto de conexão

            string conexao = stringConexao.ConnString(); // gera string de conexão (método ConnString())

            NpgsqlConnection con = new NpgsqlConnection(conexao); // Cria uma conexao com o banco

            con.Open(); // Abre a conexao com o banco

            string commandText = String.Format("INSERT INTO cliente(cpf_cliente,nome_cliente,salario_cliente,creduti_cliente) " +
                                                "values('{0}','{1}',{2},{3})", objPessoa.Cpf, objPessoa.Nome, objPessoa.Salario, objPessoa.calcCredito());

            using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(commandText, con))
            {
                pgsqlcommand.ExecuteNonQuery();
            }

            con.Close(); // Fecha a conexão com o banco
            MessageBox.Show("Cadastro Inserido com Sucesso: ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
