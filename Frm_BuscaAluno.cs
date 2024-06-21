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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace JanelasMDI
{
    public partial class Frm_BuscaAluno : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataReader dr;
        string strSQL;
        public Frm_BuscaAluno()
        {
            InitializeComponent();
        }

        public void buscar()
        {
            try
            {
                mskCpfAluno.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                var valorSemMascara1 = mskCpfAluno.Text;

                mskCpfCliente.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                var valorSemMascara2 = mskCpfCliente.Text;


                conexao = new MySqlConnection("Server = localhost; Database = escola; Uid = senai; Pwd = 1234");

                strSQL = "select * from t_alunos where CpfAluno = @cpfaluno OR fk_CpfCliente = @fk_CpfCliente OR MatriculaAluno = @matricula";
               
                
                comando = new MySqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@cpfaluno", mskCpfAluno.Text);
                comando.Parameters.AddWithValue("@fk_CpfCliente", mskCpfCliente.Text);
                comando.Parameters.AddWithValue("@matricula", txtMatriculaAluno.Text);

                conexao.Open();

                dr = comando.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        textBox2.Text = Convert.ToString(dr["MatriculaAluno"]);
                        txtNomeCompleto.Text = Convert.ToString(dr["NomeAluno"]);
                        txtEmail.Text = Convert.ToString(dr["EmailAluno"]);
                        maskedTextBox1.Text = Convert.ToString(dr["DddAluno"]);
                        mskTelefone.Text = Convert.ToString(dr["TelefoneAluno"]);
                        mskDataNascimento.Text = Convert.ToString(dr["DtNascimentoAluno"]);
                        maskedTextBox3.Text = Convert.ToString(dr["CpfAluno"]);
                        maskedTextBox2.Text = Convert.ToString(dr["fk_CpfCliente"]);
                        textBox1.Text = Convert.ToString(dr["Genero"]);
                    }
                }
                else
                {
                    string Msg = "Dados em branco ou inválidos";
                    string Titulo = "Erro";
                    var Result = MessageBox.Show(Msg, Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mskCpfCliente.Text = "";
                    mskCpfAluno.Text = "";
                    txtMatriculaAluno.Text = "";
                }

                mskCpfAluno.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

                mskCpfCliente.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO:" + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            buscar();

        }

        public void limpar()
        {
            textBox2.Text = "";
            txtNomeCompleto.Text = "";
            txtEmail.Text = "";
            maskedTextBox1.Text = "";
            mskTelefone.Text = "";
            mskDataNascimento.Text = "";
            maskedTextBox3.Text = "";
            maskedTextBox2.Text = "";
            textBox1.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;

            mskCpfAluno.ReadOnly = true;
            mskCpfCliente.ReadOnly = true;
            txtMatriculaAluno.ReadOnly = true;


        }
        private void button1_Click(object sender, EventArgs e)
        {
            limpar();
        }
        private void Frm_BuscaAluno_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            mskCpfAluno.ReadOnly = false;

            mskCpfCliente.ReadOnly = true;
            txtMatriculaAluno.ReadOnly = true;

            mskCpfAluno.Clear();
            mskCpfCliente.Clear();
            txtMatriculaAluno.Clear();

            radioButton2.Checked = false;
            radioButton3.Checked = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            mskCpfCliente.ReadOnly = false;

            txtMatriculaAluno.ReadOnly = true;
            mskCpfAluno.ReadOnly = true;

            mskCpfAluno.Clear();
            mskCpfCliente.Clear();
            txtMatriculaAluno.Clear();

            radioButton1.Checked = false;
            radioButton3.Checked = false;

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            txtMatriculaAluno.ReadOnly = false;

            mskCpfAluno.ReadOnly = true;
            mskCpfCliente.ReadOnly = true;
            mskCpfAluno.Clear();
            mskCpfCliente.Clear();
            txtMatriculaAluno.Clear();

            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Hide();
            Frm_Principal Frm_Principal = new Frm_Principal();
            Frm_Principal.Show();
        }

        
    }
}
