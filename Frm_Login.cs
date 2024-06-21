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
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace JanelasMDI
{
    
    public partial class Frm_Login : Form
    {
        string valorCriptografado;

        MySqlCommand comando;
        MySqlDataReader dr;
        string strSql;

        public Frm_Login()
        {
            InitializeComponent();
        }
        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }
        private void btnEntrar_Click_1(object sender, EventArgs e)
        {   
            criptografaDados();
            executarLogin();
        }
        
        public void criptografaDados()
        {
            Criptografia c = new Criptografia(SHA512.Create());

            valorCriptografado = c.CriptografarSenha(txtSenha.Text);
        }
        private void executarLogin()
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection("Server = localhost; Database = escola; Uid = senai; Pwd = 1234;");

                strSql = "SELECT *  from t_usuarios where NomeUsuario = @login AND SenhaUsuario = @senha";

                comando = new MySqlCommand(strSql, conexao);

                comando.Parameters.AddWithValue("@login", txtNomeUsuario.Text);
                comando.Parameters.AddWithValue("@senha", valorCriptografado);

                conexao.Open();

                dr = comando.ExecuteReader();


                if (dr.HasRows)
                {
                    string cargo = " ";
                    string nomedados = txtNomeUsuario.Text;
                    while (dr.Read())
                    {
                        cargo = Convert.ToString(dr["Cargo"]);
                    }

                    Frm_Principal cad = new Frm_Principal(cargo,nomedados);
                    cad.Show(); 
                }
                else
                {
                    string texto = "Dados incorretos,digite novamente";
                    string titulo = "ERRO";

                    var result = MessageBox.Show(texto, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                    if (result == DialogResult.No)
                    {
                        Application.Exit();
                    }
                    txtNomeUsuario.Text = "";
                    txtSenha.Text = "";
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);

            }
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

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
