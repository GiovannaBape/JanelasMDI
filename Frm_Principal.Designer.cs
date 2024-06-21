namespace JanelasMDI
{
    partial class Frm_Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnFechar = new System.Windows.Forms.ToolStripButton();
            this.btnNovoUsuario = new System.Windows.Forms.ToolStripButton();
            this.btnVisualizar = new System.Windows.Forms.ToolStripButton();
            this.btnAjuda = new System.Windows.Forms.ToolStripButton();
            this.btnSobre = new System.Windows.Forms.ToolStripButton();
            this.btnFecharJanelas = new System.Windows.Forms.ToolStripButton();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fecharTodasAsJanelasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ferramentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarUsúariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarUsúariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.cadastarAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.agendarAtendimentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.janelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizarNaHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizarNaVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizarEmCascataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.maximizarTodasJanelasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizarTodasJanelasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ocultarBarraDeFerramentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirBarraDeFerramentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(91)))), ((int)(((byte)(165)))));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFechar,
            this.btnNovoUsuario,
            this.btnVisualizar,
            this.btnAjuda,
            this.btnSobre,
            this.btnFecharJanelas});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 37);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btnFechar
            // 
            this.btnFechar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnFechar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(34, 34);
            this.btnFechar.Text = "Fechar";
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnNovoUsuario
            // 
            this.btnNovoUsuario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNovoUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnNovoUsuario.Image")));
            this.btnNovoUsuario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNovoUsuario.Name = "btnNovoUsuario";
            this.btnNovoUsuario.Size = new System.Drawing.Size(34, 34);
            this.btnNovoUsuario.Text = "Cadastar usúarios";
            this.btnNovoUsuario.Click += new System.EventHandler(this.btnNovoUsuario_Click);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnVisualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnVisualizar.Image")));
            this.btnVisualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(34, 34);
            this.btnVisualizar.Text = "Visualizar usúarios";
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // btnAjuda
            // 
            this.btnAjuda.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnAjuda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAjuda.Image = ((System.Drawing.Image)(resources.GetObject("btnAjuda.Image")));
            this.btnAjuda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Size = new System.Drawing.Size(34, 34);
            this.btnAjuda.Text = "Ajuda";
            this.btnAjuda.Click += new System.EventHandler(this.btnAjuda_Click);
            // 
            // btnSobre
            // 
            this.btnSobre.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSobre.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSobre.Image = ((System.Drawing.Image)(resources.GetObject("btnSobre.Image")));
            this.btnSobre.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(34, 34);
            this.btnSobre.Text = "Sobre";
            this.btnSobre.Click += new System.EventHandler(this.btnSobre_Click);
            // 
            // btnFecharJanelas
            // 
            this.btnFecharJanelas.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnFecharJanelas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFecharJanelas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFecharJanelas.Image = ((System.Drawing.Image)(resources.GetObject("btnFecharJanelas.Image")));
            this.btnFecharJanelas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFecharJanelas.Name = "btnFecharJanelas";
            this.btnFecharJanelas.Size = new System.Drawing.Size(34, 34);
            this.btnFecharJanelas.Text = "Fechar janelas";
            this.btnFecharJanelas.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fecharToolStripMenuItem,
            this.toolStripSeparator1,
            this.fecharTodasAsJanelasToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fecharToolStripMenuItem.Image")));
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.fecharToolStripMenuItem.Text = "Fechar";
            this.fecharToolStripMenuItem.Click += new System.EventHandler(this.fecharToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(195, 6);
            // 
            // fecharTodasAsJanelasToolStripMenuItem
            // 
            this.fecharTodasAsJanelasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fecharTodasAsJanelasToolStripMenuItem.Image")));
            this.fecharTodasAsJanelasToolStripMenuItem.Name = "fecharTodasAsJanelasToolStripMenuItem";
            this.fecharTodasAsJanelasToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.fecharTodasAsJanelasToolStripMenuItem.Text = "Fechar Todas As Janelas";
            this.fecharTodasAsJanelasToolStripMenuItem.Click += new System.EventHandler(this.fecharTodasAsJanelasToolStripMenuItem_Click);
            // 
            // ferramentasToolStripMenuItem
            // 
            this.ferramentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarUsúariosToolStripMenuItem,
            this.visualizarUsúariosToolStripMenuItem});
            this.ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
            this.ferramentasToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.ferramentasToolStripMenuItem.Text = "Administração";
            this.ferramentasToolStripMenuItem.Click += new System.EventHandler(this.ferramentasToolStripMenuItem_Click);
            // 
            // cadastrarUsúariosToolStripMenuItem
            // 
            this.cadastrarUsúariosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastrarUsúariosToolStripMenuItem.Image")));
            this.cadastrarUsúariosToolStripMenuItem.Name = "cadastrarUsúariosToolStripMenuItem";
            this.cadastrarUsúariosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastrarUsúariosToolStripMenuItem.Text = "Cadastrar Usuários";
            this.cadastrarUsúariosToolStripMenuItem.Click += new System.EventHandler(this.cadastrarUsúariosToolStripMenuItem_Click);
            // 
            // visualizarUsúariosToolStripMenuItem
            // 
            this.visualizarUsúariosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("visualizarUsúariosToolStripMenuItem.Image")));
            this.visualizarUsúariosToolStripMenuItem.Name = "visualizarUsúariosToolStripMenuItem";
            this.visualizarUsúariosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.visualizarUsúariosToolStripMenuItem.Text = "Visualizar Usuários";
            this.visualizarUsúariosToolStripMenuItem.Click += new System.EventHandler(this.visualizarUsúariosToolStripMenuItem_Click);
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastarClienteToolStripMenuItem,
            this.listarClientesToolStripMenuItem,
            this.buscarClienteToolStripMenuItem,
            this.toolStripSeparator6,
            this.cadastarAlunoToolStripMenuItem,
            this.listarAlunoToolStripMenuItem,
            this.buscarAlunoToolStripMenuItem,
            this.toolStripSeparator2,
            this.agendarAtendimentosToolStripMenuItem,
            this.visualizaToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // cadastarClienteToolStripMenuItem
            // 
            this.cadastarClienteToolStripMenuItem.Name = "cadastarClienteToolStripMenuItem";
            this.cadastarClienteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.cadastarClienteToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.cadastarClienteToolStripMenuItem.Text = "Cadastar Cliente";
            this.cadastarClienteToolStripMenuItem.Click += new System.EventHandler(this.cadastarClienteToolStripMenuItem_Click);
            // 
            // listarClientesToolStripMenuItem
            // 
            this.listarClientesToolStripMenuItem.Name = "listarClientesToolStripMenuItem";
            this.listarClientesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.listarClientesToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.listarClientesToolStripMenuItem.Text = "Listar Clientes";
            this.listarClientesToolStripMenuItem.Click += new System.EventHandler(this.listarClientesToolStripMenuItem_Click);
            // 
            // buscarClienteToolStripMenuItem
            // 
            this.buscarClienteToolStripMenuItem.Name = "buscarClienteToolStripMenuItem";
            this.buscarClienteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.buscarClienteToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.buscarClienteToolStripMenuItem.Text = "Buscar Cliente";
            this.buscarClienteToolStripMenuItem.Click += new System.EventHandler(this.buscarClienteToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(238, 6);
            // 
            // cadastarAlunoToolStripMenuItem
            // 
            this.cadastarAlunoToolStripMenuItem.Name = "cadastarAlunoToolStripMenuItem";
            this.cadastarAlunoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D4)));
            this.cadastarAlunoToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.cadastarAlunoToolStripMenuItem.Text = "Cadastar Aluno";
            this.cadastarAlunoToolStripMenuItem.Click += new System.EventHandler(this.cadastarAlunoToolStripMenuItem_Click);
            // 
            // listarAlunoToolStripMenuItem
            // 
            this.listarAlunoToolStripMenuItem.Name = "listarAlunoToolStripMenuItem";
            this.listarAlunoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D5)));
            this.listarAlunoToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.listarAlunoToolStripMenuItem.Text = "Listar Aluno";
            this.listarAlunoToolStripMenuItem.Click += new System.EventHandler(this.listarAlunoToolStripMenuItem_Click);
            // 
            // buscarAlunoToolStripMenuItem
            // 
            this.buscarAlunoToolStripMenuItem.Name = "buscarAlunoToolStripMenuItem";
            this.buscarAlunoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D6)));
            this.buscarAlunoToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.buscarAlunoToolStripMenuItem.Text = "Buscar Aluno";
            this.buscarAlunoToolStripMenuItem.Click += new System.EventHandler(this.buscarAlunoToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(238, 6);
            // 
            // agendarAtendimentosToolStripMenuItem
            // 
            this.agendarAtendimentosToolStripMenuItem.Name = "agendarAtendimentosToolStripMenuItem";
            this.agendarAtendimentosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D7)));
            this.agendarAtendimentosToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.agendarAtendimentosToolStripMenuItem.Text = "Agendar Atendimentos";
            this.agendarAtendimentosToolStripMenuItem.Click += new System.EventHandler(this.agendarAtendimentosToolStripMenuItem_Click);
            // 
            // visualizaToolStripMenuItem
            // 
            this.visualizaToolStripMenuItem.Name = "visualizaToolStripMenuItem";
            this.visualizaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D8)));
            this.visualizaToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.visualizaToolStripMenuItem.Text = "Visualizar Atendimentos";
            // 
            // janelaToolStripMenuItem
            // 
            this.janelaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.organizarNaHorizontalToolStripMenuItem,
            this.organizarNaVerticalToolStripMenuItem,
            this.organizarEmCascataToolStripMenuItem,
            this.toolStripSeparator5,
            this.maximizarTodasJanelasToolStripMenuItem,
            this.minimizarTodasJanelasToolStripMenuItem});
            this.janelaToolStripMenuItem.Name = "janelaToolStripMenuItem";
            this.janelaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.janelaToolStripMenuItem.Text = "Janela";
            // 
            // organizarNaHorizontalToolStripMenuItem
            // 
            this.organizarNaHorizontalToolStripMenuItem.Name = "organizarNaHorizontalToolStripMenuItem";
            this.organizarNaHorizontalToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.organizarNaHorizontalToolStripMenuItem.Text = "Organizar na Horizontal";
            this.organizarNaHorizontalToolStripMenuItem.Click += new System.EventHandler(this.organizarNaHorizontalToolStripMenuItem_Click);
            // 
            // organizarNaVerticalToolStripMenuItem
            // 
            this.organizarNaVerticalToolStripMenuItem.Name = "organizarNaVerticalToolStripMenuItem";
            this.organizarNaVerticalToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.organizarNaVerticalToolStripMenuItem.Text = "Organizar na Vertical";
            this.organizarNaVerticalToolStripMenuItem.Click += new System.EventHandler(this.organizarNaVerticalToolStripMenuItem_Click);
            // 
            // organizarEmCascataToolStripMenuItem
            // 
            this.organizarEmCascataToolStripMenuItem.Name = "organizarEmCascataToolStripMenuItem";
            this.organizarEmCascataToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.organizarEmCascataToolStripMenuItem.Text = "Organizar em Cascata";
            this.organizarEmCascataToolStripMenuItem.Click += new System.EventHandler(this.organizarEmCascataToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(199, 6);
            // 
            // maximizarTodasJanelasToolStripMenuItem
            // 
            this.maximizarTodasJanelasToolStripMenuItem.Name = "maximizarTodasJanelasToolStripMenuItem";
            this.maximizarTodasJanelasToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.maximizarTodasJanelasToolStripMenuItem.Text = "Maximizar Todas Janelas";
            this.maximizarTodasJanelasToolStripMenuItem.Click += new System.EventHandler(this.maximizarTodasJanelasToolStripMenuItem_Click);
            // 
            // minimizarTodasJanelasToolStripMenuItem
            // 
            this.minimizarTodasJanelasToolStripMenuItem.Name = "minimizarTodasJanelasToolStripMenuItem";
            this.minimizarTodasJanelasToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.minimizarTodasJanelasToolStripMenuItem.Text = "Minimizar Todas Janelas";
            this.minimizarTodasJanelasToolStripMenuItem.Click += new System.EventHandler(this.minimizarTodasJanelasToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajudaToolStripMenuItem1,
            this.toolStripSeparator4,
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // ajudaToolStripMenuItem1
            // 
            this.ajudaToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("ajudaToolStripMenuItem1.Image")));
            this.ajudaToolStripMenuItem1.Name = "ajudaToolStripMenuItem1";
            this.ajudaToolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.ajudaToolStripMenuItem1.Text = "Ajuda";
            this.ajudaToolStripMenuItem1.Click += new System.EventHandler(this.ajudaToolStripMenuItem1_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(155, 6);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sobreToolStripMenuItem.Image")));
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.sobreToolStripMenuItem.Text = "Sobre o Sistema";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.exibirToolStripMenuItem,
            this.ferramentasToolStripMenuItem,
            this.sistemaToolStripMenuItem,
            this.janelaToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.janelaToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exibirToolStripMenuItem
            // 
            this.exibirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ocultarBarraDeFerramentasToolStripMenuItem,
            this.exibirBarraDeFerramentasToolStripMenuItem});
            this.exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            this.exibirToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.exibirToolStripMenuItem.Text = "Exibir";
            // 
            // ocultarBarraDeFerramentasToolStripMenuItem
            // 
            this.ocultarBarraDeFerramentasToolStripMenuItem.Name = "ocultarBarraDeFerramentasToolStripMenuItem";
            this.ocultarBarraDeFerramentasToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.ocultarBarraDeFerramentasToolStripMenuItem.Text = "Ocultar Barra de Ferramentas";
            this.ocultarBarraDeFerramentasToolStripMenuItem.Click += new System.EventHandler(this.ocultarBarraDeFerramentasToolStripMenuItem_Click);
            // 
            // exibirBarraDeFerramentasToolStripMenuItem
            // 
            this.exibirBarraDeFerramentasToolStripMenuItem.Name = "exibirBarraDeFerramentasToolStripMenuItem";
            this.exibirBarraDeFerramentasToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.exibirBarraDeFerramentasToolStripMenuItem.Text = "Exibir Barra de Ferramentas";
            this.exibirBarraDeFerramentasToolStripMenuItem.Click += new System.EventHandler(this.exibirBarraDeFerramentasToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(487, 1);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(91)))), ((int)(((byte)(165)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnFecharJanelas;
        private System.Windows.Forms.ToolStripButton btnFechar;
        private System.Windows.Forms.ToolStripButton btnNovoUsuario;
        private System.Windows.Forms.ToolStripButton btnVisualizar;
        private System.Windows.Forms.ToolStripButton btnAjuda;
        private System.Windows.Forms.ToolStripButton btnSobre;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharTodasAsJanelasToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ferramentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarUsúariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarUsúariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem cadastarAlunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarAlunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarAlunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem agendarAtendimentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem janelaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organizarNaHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organizarNaVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organizarEmCascataToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem maximizarTodasJanelasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizarTodasJanelasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ocultarBarraDeFerramentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibirBarraDeFerramentasToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
    }
}

