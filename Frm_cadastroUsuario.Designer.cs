namespace JanelasMDI
{
    partial class Frm_cadastroUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_cadastroUsuario));
            this.label15 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gpboxCargo = new System.Windows.Forms.GroupBox();
            this.rdbntAtendimento = new System.Windows.Forms.RadioButton();
            this.rdbntCoordenador = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.gpboxCargo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(185)))), ((int)(((byte)(156)))));
            this.label15.Location = new System.Drawing.Point(128, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(463, 29);
            this.label15.TabIndex = 0;
            this.label15.Text = "Escola Técnica - Cadastro de usuários";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(91)))), ((int)(((byte)(165)))));
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(185)))), ((int)(((byte)(156)))));
            this.btnCadastrar.Location = new System.Drawing.Point(207, 248);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(176, 31);
            this.btnCadastrar.TabIndex = 7;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeUsuario.Location = new System.Drawing.Point(131, 114);
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(201, 21);
            this.txtNomeUsuario.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(91)))), ((int)(((byte)(165)))));
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 76);
            this.panel1.TabIndex = 43;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(185)))), ((int)(((byte)(156)))));
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(91)))), ((int)(((byte)(165)))));
            this.btnSair.Location = new System.Drawing.Point(578, 2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(31, 28);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(371, 114);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(113, 21);
            this.txtSenha.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(128, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 15);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nome de Usuário";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(368, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 15);
            this.label10.TabIndex = 30;
            this.label10.Text = "Senha";
            // 
            // gpboxCargo
            // 
            this.gpboxCargo.Controls.Add(this.rdbntAtendimento);
            this.gpboxCargo.Controls.Add(this.rdbntCoordenador);
            this.gpboxCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpboxCargo.Location = new System.Drawing.Point(174, 158);
            this.gpboxCargo.Name = "gpboxCargo";
            this.gpboxCargo.Size = new System.Drawing.Size(264, 71);
            this.gpboxCargo.TabIndex = 6;
            this.gpboxCargo.TabStop = false;
            this.gpboxCargo.Text = "Cargo";
            this.gpboxCargo.Enter += new System.EventHandler(this.gpboxCargo_Enter);
            // 
            // rdbntAtendimento
            // 
            this.rdbntAtendimento.AutoSize = true;
            this.rdbntAtendimento.Location = new System.Drawing.Point(12, 46);
            this.rdbntAtendimento.Name = "rdbntAtendimento";
            this.rdbntAtendimento.Size = new System.Drawing.Size(94, 19);
            this.rdbntAtendimento.TabIndex = 1;
            this.rdbntAtendimento.TabStop = true;
            this.rdbntAtendimento.Text = "Atendimento";
            this.rdbntAtendimento.UseVisualStyleBackColor = true;
            this.rdbntAtendimento.CheckedChanged += new System.EventHandler(this.rdbntAtendimento_CheckedChanged);
            // 
            // rdbntCoordenador
            // 
            this.rdbntCoordenador.AutoSize = true;
            this.rdbntCoordenador.Location = new System.Drawing.Point(12, 20);
            this.rdbntCoordenador.Name = "rdbntCoordenador";
            this.rdbntCoordenador.Size = new System.Drawing.Size(97, 19);
            this.rdbntCoordenador.TabIndex = 0;
            this.rdbntCoordenador.TabStop = true;
            this.rdbntCoordenador.Text = "Coordenador";
            this.rdbntCoordenador.UseVisualStyleBackColor = true;
            this.rdbntCoordenador.CheckedChanged += new System.EventHandler(this.rdbntCoordenador_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(401, 141);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(83, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Exibir senha";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Frm_cadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(185)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(612, 303);
            this.ControlBox = false;
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.gpboxCargo);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtNomeUsuario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(628, 342);
            this.Name = "Frm_cadastroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Frm_cadastroUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gpboxCargo.ResumeLayout(false);
            this.gpboxCargo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gpboxCargo;
        private System.Windows.Forms.RadioButton rdbntAtendimento;
        private System.Windows.Forms.RadioButton rdbntCoordenador;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnSair;
    }
}