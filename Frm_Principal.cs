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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace JanelasMDI
{
    public partial class Frm_Principal : Form
    {
        string cg;
        public Frm_Principal()
        {
            InitializeComponent();
        }
        public Frm_Principal(string cargo, string nomedados)
        {

            InitializeComponent();

            cg = cargo;
            textBox1.Text= nomedados;

            if (cg.Equals("COORDENADOR"))
            {
             
            }
            else
            {
                cadastrarUsúariosToolStripMenuItem.Visible = false;
            }
        }

        private void organizarNaHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void organizarNaVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void organizarEmCascataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            botaofecharjanelas();
        }
        private void fecharTodasAsJanelasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            botaofecharjanelas();
        }
        private void botaofecharjanelas()
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            botaofechar();
        }
        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            botaofechar();
        }

        private void botaofechar()
        {
            Application.Exit();
        }

        private void cadastrarUsúariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            botaoCadastrarUsuario();
        }

        private void btnNovoUsuario_Click(object sender, EventArgs e)
        {
            botaoCadastrarUsuario();
        }

        private void botaoCadastrarUsuario()
        {
            Frm_cadastroUsuario frm_cadastroUsuario = new Frm_cadastroUsuario();
            frm_cadastroUsuario.MdiParent = this;
            frm_cadastroUsuario.Show();
        }

        private void visualizarUsúariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            botaoVisualizarUsuario();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            botaoVisualizarUsuario();
        }

        private void botaoVisualizarUsuario()
        {
            Frm_VisualizarUsuarios Frm_VisualizarUsuarios = new Frm_VisualizarUsuarios();
            Frm_VisualizarUsuarios.Show();

        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            botaosobre();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            botaosobre();
        }

        private void botaosobre()
        {
            Frm_Sobre frmsobre = new Frm_Sobre();
            frmsobre.Show();
        }

        private void btnAjuda_Click(object sender, EventArgs e)
        {
            botaoAjuda();
        }

        private void ajudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            botaoAjuda();
        }

        private void botaoAjuda()
        {
            Frm_Ajuda frmajuda = new Frm_Ajuda();
            frmajuda.MdiParent = this;
            frmajuda.Show();
        }

        private void cadastarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_CadastrarCliente frm_CadastrarCliente = new Frm_CadastrarCliente();
            frm_CadastrarCliente.MdiParent = this;
            frm_CadastrarCliente.Show();
        }

        private void buscarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_BuscaCliente frm_BuscaCliente = new Frm_BuscaCliente();
            frm_BuscaCliente.MdiParent = this;
            frm_BuscaCliente.Show();
        }

        private void cadastarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_cadastroAluno frm_cadastroAluno = new frm_cadastroAluno();
            frm_cadastroAluno.MdiParent = this;
            frm_cadastroAluno.Show();
        }

        private void buscarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_BuscaAluno frm_BuscaAluno = new Frm_BuscaAluno();
            frm_BuscaAluno.MdiParent = this;
            frm_BuscaAluno.Show();
        }

        private void maximizarTodasJanelasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void minimizarTodasJanelasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agendarAtendimentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_AgendarAtendimento frm_AgendarAtendimento = new Frm_AgendarAtendimento();
            frm_AgendarAtendimento.MdiParent = this;
            frm_AgendarAtendimento.Show();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ferramentasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ListarClientes Frm_ListarClientes = new Frm_ListarClientes();
            Frm_ListarClientes.MdiParent = this;
            Frm_ListarClientes.Show();
        }

        private void listarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ListarAlunos Frm_ListarAlunos = new Frm_ListarAlunos();
            Frm_ListarAlunos.MdiParent = this;
            Frm_ListarAlunos.Show();
        }

        private void ocultarBarraDeFerramentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = false;
        }

        private void exibirBarraDeFerramentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = true;
        }
    }
}
