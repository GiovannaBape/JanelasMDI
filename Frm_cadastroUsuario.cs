using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JanelasMDI
{

    public partial class Frm_cadastroUsuario : Form 
    {
        string valorCriptografado;
        string cargo;

        MySqlCommand comando;
        string strSql;
        public Frm_cadastroUsuario()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (txtSenha.Text != "")
            {
                if (checkBox1.Checked)
                {
                    txtSenha.PasswordChar = default;
                }
                else
                {
                    txtSenha.PasswordChar = '*';
                }
            }
        }
        public void criptografaDados()
        {
            try
            {
                Criptografia c = new Criptografia(SHA512.Create());

                valorCriptografado = c.CriptografarSenha(txtSenha.Text);

                MySqlConnection conexao = new MySqlConnection("Server = localhost; Database = escola; Uid = senai; Pwd = 1234;");

                strSql = "insert into t_usuarios (NomeUsuario,SenhaUsuario,Cargo) values (@NomeUsuario,@senha,@Cargo) ";

                comando = new MySqlCommand(strSql, conexao);

                if (txtNomeUsuario.Text == "" || txtSenha.Text == "" || rdbntCoordenador.Checked == true|| rdbntAtendimento.Checked == true)
                {
                    string Msg = "Dados em branco";
                    string Titulo = "Erro";
                    var Result = MessageBox.Show(Msg, Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comando.Parameters.AddWithValue("@NomeUsuario", txtNomeUsuario.Text);
                    comando.Parameters.AddWithValue("@senha", valorCriptografado.ToString());
                    comando.Parameters.AddWithValue("@cargo", cargo);

                    MessageBox.Show("Cadastrado com sucesso!");
                    conexao.Open();
                    comando.ExecuteNonQuery();

                    txtNomeUsuario.Text = "";
                    txtSenha.Text = "";
                    rdbntAtendimento.Checked = false;
                    rdbntCoordenador.Checked = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            criptografaDados();
        }

        private void rdbntCoordenador_CheckedChanged(object sender, EventArgs e)
        {
            cargo = "COORDENADOR";
        }

        private void rdbntAtendimento_CheckedChanged(object sender, EventArgs e)
        {
            cargo = "ATENDIMENTO";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Hide();
            Frm_Principal Frm_Principal = new Frm_Principal();
            Frm_Principal.Show();
        }

        private void Frm_cadastroUsuario_Load(object sender, EventArgs e)
        {

        }

        private void gpboxCargo_Enter(object sender, EventArgs e)
        {

        }

    }
}
