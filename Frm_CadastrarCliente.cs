using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace JanelasMDI
{
    public partial class Frm_CadastrarCliente : Form
    {
        MySqlCommand comando;
        MySqlDataReader dr;
        string strSql;
        string genero = "";
        public Frm_CadastrarCliente()
        {
            InitializeComponent();
        }

        private void Frm_CadastrarCliente_Load(object sender, EventArgs e)
        {

        }
        public void cadastroCliente()
        {
            try
            {
                maskedTextBox1.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                var valorSemMascara1 = maskedTextBox1.Text;

                mskTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                var valorSemMascara2 = mskTelefone.Text;

                mskCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                var valorSemMascara3 = mskCpf.Text;

                mskCep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                var valorSemMascara4 = mskCep.Text;

                MySqlConnection conexao = new MySqlConnection("Server = localhost; Database = escola; Uid = senai; Pwd = 1234;");

                strSql = "insert into t_clientes (NomeCliente,Genero,CepCliente,RuaCliente,BairroCliente,NumeroCliente,CidadeCliente,EstadoCliente,PaisCliente,DddCliente,TelefoneCliente,EmailCliente,DtNascimentoCliente,CpfCliente,ProfissaoCliente) values (@NomeCliente,@Genero,@CepCliente,@RuaCliente,@BairroCliente,@NumeroCliente,@CidadeCliente,@EstadoCliente,@PaisCliente,@DddCliente,@TelefoneCliente,@EmailCliente,@DtNascimentoCliente,@CpfCliente,@ProfissaoCliente)";

                comando = new MySqlCommand(strSql, conexao);

                if (txtNomeCompleto.Text == "" || !maskedTextBox1.MaskCompleted || !mskTelefone.MaskCompleted || !mskCep.MaskCompleted || txtRua.Text == "" || txtCidade.Text == "" || txtEstado.Text == "" || !mskCpf.MaskCompleted || txtNumero.Text== "" || txtEmail.Text == "" || txtBairro.Text == "" || txtProfissao.Text == "")
                {
                    string Msg = "Dados em branco";
                    string Titulo = "Erro";
                    var Result = MessageBox.Show(Msg, Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (!txtEmail.Text.Contains("@") && !txtEmail.Text.Contains("."))
                    {
                        string Msg = "E-mail está fora dos padrões";
                        string Titulo = "Erro";
                        var Result = MessageBox.Show(Msg, Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        comando.Parameters.AddWithValue("@NomeCliente", txtNomeCompleto.Text);
                        comando.Parameters.AddWithValue("@DddCliente", maskedTextBox1.Text);
                        comando.Parameters.AddWithValue("@TelefoneCliente", mskTelefone.Text);
                        comando.Parameters.AddWithValue("@CepCliente", mskCep.Text);
                        comando.Parameters.AddWithValue("@RuaCliente", txtRua.Text);
                        comando.Parameters.AddWithValue("@BairroCliente", txtBairro.Text);
                        comando.Parameters.AddWithValue("@NumeroCliente", txtNumero.Text);
                        comando.Parameters.AddWithValue("@CidadeCliente", txtCidade.Text);
                        comando.Parameters.AddWithValue("@EstadoCliente", txtEstado.Text);
                        comando.Parameters.AddWithValue("@PaisCliente", comboBox1.Text);
                        comando.Parameters.AddWithValue("@EmailCliente", txtEmail.Text);
                        comando.Parameters.AddWithValue("@DtNascimentoCliente", Convert.ToDateTime(mskDataNascimento.Text));
                        comando.Parameters.AddWithValue("@CpfCliente", mskCpf.Text);
                        comando.Parameters.AddWithValue("@ProfissaoCliente", txtProfissao.Text);
                        comando.Parameters.AddWithValue("@Genero", Convert.ToString(genero));


                        conexao.Open();
                        dr = comando.ExecuteReader();

                        string Msg = "Contato salvo com sucesso";
                        string Titulo = "Sucesso";
                        var Result = MessageBox.Show(Msg, Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                maskedTextBox1.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                mskTelefone.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                mskCpf.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                mskCep.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        public void limpar()
        {
            txtNomeCompleto.Text = "";
            maskedTextBox1.Text = "";
            mskTelefone.Text = "";
            mskCep.Text = "";
            txtRua.Text = "";
            txtBairro.Text = "";
            txtNumero.Text = "";
            txtCidade.Text = "";
            txtEstado.Text = "";
            comboBox1.Text = "";
            txtEmail.Text = "";
            mskDataNascimento.Text = "";
            mskCpf.Text = "";
            txtProfissao.Text = "";
            gpboxGenero.Text = "";
            rdbntFeminino.Checked = false;
            rdbntMasculino.Checked = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            cadastroCliente();
            limpar();
        }

        private void rdbntMasculino_CheckedChanged(object sender, EventArgs e)
        {
            genero = "MASCULINO";
        }
        private void rdbntFeminino_CheckedChanged_1(object sender, EventArgs e)
        {
            genero = "FEMININO";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Hide();
            Frm_Principal Frm_Principal = new Frm_Principal();
            Frm_Principal.Show();
        }

        private void executaBuscaTratada()
        {
            mskCep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            var valorSemMascara4 = mskCep.Text;


            string entrada = mskCep.Text;
            int c;

            if (int.TryParse(entrada, out c) && entrada.Length == 8)
            {
                try
                {
                    BuscaCep buscaCep = new BuscaCep(c);

                    if (string.IsNullOrEmpty(buscaCep.Cep))
                    {
                        MessageBox.Show("CEP não encontrado." +
                            "Verifique o número digitado e tente novamente.",
                            "CEP inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        txtRua.Text = buscaCep.Rua;
                        txtBairro.Text = buscaCep.Bairro;
                        txtCidade.Text = buscaCep.Cidade;
                        txtEstado.Text = buscaCep.Estado;

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao buscar o CEP:" + ex.Message,
                        "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor," +
                    "Insira um CEP válido de 8 dígitos que contenha apenas número.",
                    "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);

                mskCep.Clear();
                mskCep.Focus();
            }


            mskCep.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

        }

        private void mskCep_Leave(object sender, EventArgs e)
        {
            executaBuscaTratada();
        }
    }
}
