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

namespace JanelasMDI
{
    public partial class Frm_ListarAlunos : Form
    {
        MySqlDataAdapter da;
        string strSql;
        public Frm_ListarAlunos()
        {
            InitializeComponent();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Hide();
            Frm_Principal Frm_Principal = new Frm_Principal();
            Frm_Principal.Show();
        }
        public void listar()
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection("Server = localhost; Database = escola; Uid = senai; Pwd = 1234;");

                strSql = "select * from t_alunos";

                da = new MySqlDataAdapter(strSql, conexao);

                conexao.Open();
                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }


        private void btnListar_Click(object sender, EventArgs e)
        {
            listar();
        }
    }
}
