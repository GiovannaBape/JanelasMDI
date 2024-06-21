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
    public partial class frm_cadastroAluno : Form
    {
        MySqlCommand comando;
        MySqlDataReader dr;
        string strSql;
        string genero = " ";

        public frm_cadastroAluno()
        {
            InitializeComponent();
        }

        private void txtNomeCompleto_TextChanged(object sender, EventArgs e)
        {

        }
        public void cadastrarAluno()
        {
            try
            {
                mskCpfAluno.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                var valorSemMascara1 = mskCpfAluno.Text;

                maskedTextBox1.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                var valorSemMascara2 = maskedTextBox1.Text;

                mskTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                var valorSemMascara4 = mskTelefone.Text;

                mskCpfCliente.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                var valorSemMascara5 = mskCpfCliente.Text;

                MySqlConnection conexao = new MySqlConnection("Server = localhost; Database = escola; Uid = senai; Pwd = 1234;");

                strSql = "insert into t_alunos (NomeAluno, DddAluno,TelefoneAluno,EmailAluno,Genero,DtNascimentoAluno,CpfAluno,fk_CpfCliente) values (@NomeAluno, @DddAluno,@TelefoneAluno,@EmailAluno,@Genero,@DtNascimentoAluno,@CpfAluno,@fk_CpfCliente)";

                comando = new MySqlCommand(strSql, conexao);

                if (txtNomeCompleto.Text == "" || !mskCpfAluno.MaskCompleted || !maskedTextBox1.MaskCompleted || !mskTelefone.MaskCompleted || txtEmail.Text == "" || !mskCpfCliente.MaskCompleted)
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
                        comando.Parameters.AddWithValue("@NomeAluno", txtNomeCompleto.Text);
                        comando.Parameters.AddWithValue("@DddAluno", maskedTextBox1.Text);
                        comando.Parameters.AddWithValue("@TelefoneAluno", mskTelefone.Text);
                        comando.Parameters.AddWithValue("@EmailAluno", txtEmail.Text);
                        comando.Parameters.AddWithValue("@DtNascimentoAluno", Convert.ToDateTime(mskDataNascimento.Text));
                        comando.Parameters.AddWithValue("@CpfAluno", mskCpfAluno.Text);
                        comando.Parameters.AddWithValue("@fk_CpfCliente", mskCpfCliente.Text);
                        comando.Parameters.AddWithValue("@Genero", Convert.ToString(genero));

                        conexao.Open();
                        dr = comando.ExecuteReader();

                        string Msg = "Contato salvo com sucesso";
                        string Titulo = "Sucesso";
                        var Result = MessageBox.Show(Msg, Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                mskCpfAluno.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                maskedTextBox1.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                mskTelefone.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
                mskCpfCliente.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        public void limpar()
        {
            txtNomeCompleto.Text = "";
            maskedTextBox1.Text = "";
            mskTelefone.Text = "";
            txtEmail.Text = "";
            mskDataNascimento.Text = "";
            mskCpfAluno.Text = "";
            mskCpfCliente.Text = "";
            gpboxGenero.Text = "";
            rdbntFeminino.Checked = false;
            rdbntMasculino.Checked = false;
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            cadastrarAluno();
            limpar();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Hide();
            Frm_Principal Frm_Principal = new Frm_Principal();
            Frm_Principal.Show();
        }
        private void rdbntMasculino_CheckedChanged_1(object sender, EventArgs e)
        {
            genero = "MASCULINO";
        }
        private void rdbntFeminino_CheckedChanged(object sender, EventArgs e)
        {
            genero = "FEMiNINO";
        }

    }
}
