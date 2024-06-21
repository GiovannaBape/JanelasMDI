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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace JanelasMDI
{
    public partial class Frm_BuscaCliente : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataReader dr;
        string strSQL;
        public Frm_BuscaCliente()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            buscar();
        }
        public void buscar()
        {
            try
            {
                mskCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                var valorSemMascara1 = mskCpf.Text;

                conexao = new MySqlConnection("Server = localhost; Database = escola; Uid = senai; Pwd = 1234");

                strSQL = "select * from t_clientes where CpfCliente = @cpf  OR CodigoCliente = @codigo";

                comando = new MySqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@cpf", mskCpf.Text);
                comando.Parameters.AddWithValue("@codigo", txtCodigoCliente.Text);


                conexao.Open();

                dr = comando.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        txtNomeCompleto.Text = Convert.ToString(dr["NomeCliente"]);
                        txtEmail.Text = Convert.ToString(dr["EmailCliente"]);
                        maskedTextBox2.Text = Convert.ToString(dr["DddCliente"]);
                        mskTelefone.Text = Convert.ToString(dr["TelefoneCliente"]);
                        mskDataNascimento.Text = Convert.ToString(dr["DtNascimentoCliente"]);
                        maskedTextBox1.Text = Convert.ToString(dr["CpfCliente"]);
                        textBox1.Text = Convert.ToString(dr["Genero"]);
                        txtProfissao.Text = Convert.ToString(dr["ProfissaoCliente"]);
                        textBox2.Text = Convert.ToString(dr["CodigoCliente"]);
                        mskCep.Text = Convert.ToString(dr["CepCliente"]);
                        txtRua.Text = Convert.ToString(dr["RuaCliente"]);
                        txtBairro.Text = Convert.ToString(dr["BairroCliente"]);
                        txtNumero.Text = Convert.ToString(dr["NumeroCliente"]);
                        txtCidade.Text = Convert.ToString(dr["CidadeCliente"]);
                        txtEstado.Text = Convert.ToString(dr["EstadoCliente"]);
                        txtPais.Text = Convert.ToString(dr["PaisCliente"]);

                    }
                }
                else
                {
                    string Msg = "Dados em branco ou inválidos";
                    string Titulo = "Erro";
                    var Result = MessageBox.Show(Msg, Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mskCpf.Text = "";
                    txtCodigoCliente.Text = "";
                }

                mskCpf.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

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
        private void button2_Click(object sender, EventArgs e)
        {
            limpar();
        }

        public void limpar()
        {
            txtNomeCompleto.Text = "";
            txtEmail.Text = "";
            maskedTextBox1.Text = "";
            maskedTextBox2.Text = "";
            mskTelefone.Text = "";
            mskDataNascimento.Text = "";
            txtProfissao.Text = "";
            textBox1.Text = "";
            
            radioButton1.Checked = false;
            radioButton2.Checked = false;

            mskCpf.ReadOnly = true;
            txtCodigoCliente.ReadOnly = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            mskCpf.ReadOnly = false;

            txtCodigoCliente.ReadOnly = true;

            mskCpf.Clear();
            txtCodigoCliente.Clear();

            radioButton2.Checked = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtCodigoCliente.ReadOnly = false;

            mskCpf.ReadOnly = true;

            mskCpf.Clear();
            txtCodigoCliente.Clear();

            radioButton1.Checked = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Hide();
            Frm_Principal Frm_Principal = new Frm_Principal();
            Frm_Principal.Show();
        }
    }
}
