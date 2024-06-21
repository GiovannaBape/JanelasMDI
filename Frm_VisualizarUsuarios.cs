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
    public partial class Frm_VisualizarUsuarios : Form
    {
        MySqlDataAdapter da;
        string strSql;
        public Frm_VisualizarUsuarios()
        {
            InitializeComponent();
        }
        public void listar()
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection("Server = localhost; Database = escola; Uid = senai; Pwd = 1234;");

                strSql = "select * from t_usuarios";

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

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Hide();
            Frm_Principal frm_Principal = new Frm_Principal();
            frm_Principal.ShowDialog();
        }
    }
}
