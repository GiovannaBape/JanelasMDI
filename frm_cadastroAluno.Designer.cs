namespace JanelasMDI
{
    partial class frm_cadastroAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cadastroAluno));
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNomeCompleto = new System.Windows.Forms.TextBox();
            this.txtMatriculaAluno = new System.Windows.Forms.TextBox();
            this.rdbntFeminino = new System.Windows.Forms.RadioButton();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.gpboxGenero = new System.Windows.Forms.GroupBox();
            this.rdbntMasculino = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mskCpfAluno = new System.Windows.Forms.MaskedTextBox();
            this.mskCpfCliente = new System.Windows.Forms.MaskedTextBox();
            this.mskDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpboxGenero.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(31, 167);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(187, 21);
            this.txtEmail.TabIndex = 6;
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
            this.panel1.Size = new System.Drawing.Size(603, 76);
            this.panel1.TabIndex = 43;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(185)))), ((int)(((byte)(156)))));
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(91)))), ((int)(((byte)(165)))));
            this.btnSair.Location = new System.Drawing.Point(569, 3);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(31, 28);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(185)))), ((int)(((byte)(156)))));
            this.label15.Location = new System.Drawing.Point(135, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(441, 29);
            this.label15.TabIndex = 0;
            this.label15.Text = "Escola Técnica - Cadastro de alunos";
            // 
            // txtNomeCompleto
            // 
            this.txtNomeCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCompleto.Location = new System.Drawing.Point(168, 108);
            this.txtNomeCompleto.Name = "txtNomeCompleto";
            this.txtNomeCompleto.Size = new System.Drawing.Size(233, 21);
            this.txtNomeCompleto.TabIndex = 3;
            this.txtNomeCompleto.TextChanged += new System.EventHandler(this.txtNomeCompleto_TextChanged);
            // 
            // txtMatriculaAluno
            // 
            this.txtMatriculaAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatriculaAluno.Location = new System.Drawing.Point(31, 108);
            this.txtMatriculaAluno.Name = "txtMatriculaAluno";
            this.txtMatriculaAluno.ReadOnly = true;
            this.txtMatriculaAluno.Size = new System.Drawing.Size(100, 21);
            this.txtMatriculaAluno.TabIndex = 2;
            // 
            // rdbntFeminino
            // 
            this.rdbntFeminino.AutoSize = true;
            this.rdbntFeminino.Location = new System.Drawing.Point(12, 46);
            this.rdbntFeminino.Name = "rdbntFeminino";
            this.rdbntFeminino.Size = new System.Drawing.Size(77, 19);
            this.rdbntFeminino.TabIndex = 1;
            this.rdbntFeminino.TabStop = true;
            this.rdbntFeminino.Text = "Feminino";
            this.rdbntFeminino.UseVisualStyleBackColor = true;
            this.rdbntFeminino.CheckedChanged += new System.EventHandler(this.rdbntFeminino_CheckedChanged);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(91)))), ((int)(((byte)(165)))));
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(185)))), ((int)(((byte)(156)))));
            this.btnCadastrar.Location = new System.Drawing.Point(201, 284);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(177, 31);
            this.btnCadastrar.TabIndex = 11;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // gpboxGenero
            // 
            this.gpboxGenero.Controls.Add(this.rdbntFeminino);
            this.gpboxGenero.Controls.Add(this.rdbntMasculino);
            this.gpboxGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpboxGenero.Location = new System.Drawing.Point(367, 184);
            this.gpboxGenero.Name = "gpboxGenero";
            this.gpboxGenero.Size = new System.Drawing.Size(163, 71);
            this.gpboxGenero.TabIndex = 10;
            this.gpboxGenero.TabStop = false;
            this.gpboxGenero.Text = "Gênero";
            // 
            // rdbntMasculino
            // 
            this.rdbntMasculino.AutoSize = true;
            this.rdbntMasculino.Location = new System.Drawing.Point(12, 20);
            this.rdbntMasculino.Name = "rdbntMasculino";
            this.rdbntMasculino.Size = new System.Drawing.Size(82, 19);
            this.rdbntMasculino.TabIndex = 0;
            this.rdbntMasculino.TabStop = true;
            this.rdbntMasculino.Text = "Masculino";
            this.rdbntMasculino.UseVisualStyleBackColor = true;
            this.rdbntMasculino.CheckedChanged += new System.EventHandler(this.rdbntMasculino_CheckedChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(165, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nome Completo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 27;
            this.label1.Text = "Matrícula do Aluno";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(34, 217);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 15);
            this.label13.TabIndex = 33;
            this.label13.Text = "CPF do Aluno";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(259, 151);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 15);
            this.label12.TabIndex = 32;
            this.label12.Text = "Data de Nascimento";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(194, 217);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 15);
            this.label14.TabIndex = 34;
            this.label14.Text = "CPF do Cliente";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(28, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 15);
            this.label11.TabIndex = 31;
            this.label11.Text = "E-mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(427, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 30;
            this.label3.Text = "Telefone";
            // 
            // mskCpfAluno
            // 
            this.mskCpfAluno.Location = new System.Drawing.Point(37, 235);
            this.mskCpfAluno.Mask = "000,000,000-00";
            this.mskCpfAluno.Name = "mskCpfAluno";
            this.mskCpfAluno.Size = new System.Drawing.Size(100, 20);
            this.mskCpfAluno.TabIndex = 8;
            // 
            // mskCpfCliente
            // 
            this.mskCpfCliente.Location = new System.Drawing.Point(193, 235);
            this.mskCpfCliente.Mask = "000,000,000-00";
            this.mskCpfCliente.Name = "mskCpfCliente";
            this.mskCpfCliente.Size = new System.Drawing.Size(100, 20);
            this.mskCpfCliente.TabIndex = 9;
            // 
            // mskDataNascimento
            // 
            this.mskDataNascimento.Location = new System.Drawing.Point(258, 169);
            this.mskDataNascimento.Mask = "00/00/0000";
            this.mskDataNascimento.Name = "mskDataNascimento";
            this.mskDataNascimento.Size = new System.Drawing.Size(100, 20);
            this.mskDataNascimento.TabIndex = 7;
            // 
            // mskTelefone
            // 
            this.mskTelefone.Location = new System.Drawing.Point(461, 110);
            this.mskTelefone.Mask = "00000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(100, 20);
            this.mskTelefone.TabIndex = 5;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(430, 110);
            this.maskedTextBox1.Mask = "(00)";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(25, 20);
            this.maskedTextBox1.TabIndex = 4;
            // 
            // frm_cadastroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(185)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(603, 342);
            this.ControlBox = false;
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.mskTelefone);
            this.Controls.Add(this.mskDataNascimento);
            this.Controls.Add(this.mskCpfCliente);
            this.Controls.Add(this.mskCpfAluno);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtNomeCompleto);
            this.Controls.Add(this.txtMatriculaAluno);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.gpboxGenero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(619, 381);
            this.Name = "frm_cadastroAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpboxGenero.ResumeLayout(false);
            this.gpboxGenero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtNomeCompleto;
        private System.Windows.Forms.TextBox txtMatriculaAluno;
        private System.Windows.Forms.RadioButton rdbntFeminino;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.GroupBox gpboxGenero;
        private System.Windows.Forms.RadioButton rdbntMasculino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskCpfAluno;
        private System.Windows.Forms.MaskedTextBox mskCpfCliente;
        private System.Windows.Forms.MaskedTextBox mskDataNascimento;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}