namespace Cursos
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarAlunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarProfessorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarCursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarDiciplinasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarAlunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarProfessorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarCursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarMateriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mudarDeMenuParaBotõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnBtns = new System.Windows.Forms.Panel();
            this.btnCadastroAlunos = new System.Windows.Forms.Button();
            this.btnCadastrarProfessores = new System.Windows.Forms.Button();
            this.btnCadastraCursos = new System.Windows.Forms.Button();
            this.btnCadastrarMaterias = new System.Windows.Forms.Button();
            this.btnConsultarMaterias = new System.Windows.Forms.Button();
            this.btnConsultarCursos = new System.Windows.Forms.Button();
            this.btnConsultarProfessores = new System.Windows.Forms.Button();
            this.btnConsultarAlunos = new System.Windows.Forms.Button();
            this.btnUsarMenu = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnBtns.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.sistemasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1350, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarAlunosToolStripMenuItem,
            this.cadastrarProfessorToolStripMenuItem,
            this.cadastrarCursosToolStripMenuItem,
            this.cadastrarDiciplinasToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // cadastrarAlunosToolStripMenuItem
            // 
            this.cadastrarAlunosToolStripMenuItem.Name = "cadastrarAlunosToolStripMenuItem";
            this.cadastrarAlunosToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.cadastrarAlunosToolStripMenuItem.Text = "Cadastrar Alunos";
            this.cadastrarAlunosToolStripMenuItem.Click += new System.EventHandler(this.cadastrarAlunosToolStripMenuItem_Click);
            // 
            // cadastrarProfessorToolStripMenuItem
            // 
            this.cadastrarProfessorToolStripMenuItem.Name = "cadastrarProfessorToolStripMenuItem";
            this.cadastrarProfessorToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.cadastrarProfessorToolStripMenuItem.Text = "Cadastrar Professor";
            this.cadastrarProfessorToolStripMenuItem.Click += new System.EventHandler(this.cadastrarProfessorToolStripMenuItem_Click);
            // 
            // cadastrarCursosToolStripMenuItem
            // 
            this.cadastrarCursosToolStripMenuItem.Name = "cadastrarCursosToolStripMenuItem";
            this.cadastrarCursosToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.cadastrarCursosToolStripMenuItem.Text = "Cadastrar Cursos";
            this.cadastrarCursosToolStripMenuItem.Click += new System.EventHandler(this.cadastrarCursosToolStripMenuItem_Click);
            // 
            // cadastrarDiciplinasToolStripMenuItem
            // 
            this.cadastrarDiciplinasToolStripMenuItem.Name = "cadastrarDiciplinasToolStripMenuItem";
            this.cadastrarDiciplinasToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.cadastrarDiciplinasToolStripMenuItem.Text = "Cadastrar Diciplinas";
            this.cadastrarDiciplinasToolStripMenuItem.Click += new System.EventHandler(this.cadastrarDiciplinasToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarAlunosToolStripMenuItem,
            this.consultarProfessorToolStripMenuItem,
            this.consultarCursosToolStripMenuItem,
            this.consultarMateriasToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // consultarAlunosToolStripMenuItem
            // 
            this.consultarAlunosToolStripMenuItem.Name = "consultarAlunosToolStripMenuItem";
            this.consultarAlunosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultarAlunosToolStripMenuItem.Text = "Consultar Alunos";
            this.consultarAlunosToolStripMenuItem.Click += new System.EventHandler(this.consultarAlunosToolStripMenuItem_Click);
            // 
            // consultarProfessorToolStripMenuItem
            // 
            this.consultarProfessorToolStripMenuItem.Name = "consultarProfessorToolStripMenuItem";
            this.consultarProfessorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultarProfessorToolStripMenuItem.Text = "Consultar Professor";
            this.consultarProfessorToolStripMenuItem.Click += new System.EventHandler(this.consultarProfessorToolStripMenuItem_Click);
            // 
            // consultarCursosToolStripMenuItem
            // 
            this.consultarCursosToolStripMenuItem.Name = "consultarCursosToolStripMenuItem";
            this.consultarCursosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultarCursosToolStripMenuItem.Text = "Consultar Cursos";
            this.consultarCursosToolStripMenuItem.Click += new System.EventHandler(this.consultarCursosToolStripMenuItem_Click);
            // 
            // consultarMateriasToolStripMenuItem
            // 
            this.consultarMateriasToolStripMenuItem.Name = "consultarMateriasToolStripMenuItem";
            this.consultarMateriasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultarMateriasToolStripMenuItem.Text = "Consultar Materias";
            this.consultarMateriasToolStripMenuItem.Click += new System.EventHandler(this.consultarMateriasToolStripMenuItem_Click);
            // 
            // sistemasToolStripMenuItem
            // 
            this.sistemasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mudarDeMenuParaBotõesToolStripMenuItem});
            this.sistemasToolStripMenuItem.Name = "sistemasToolStripMenuItem";
            this.sistemasToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemasToolStripMenuItem.Text = "Sistema";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1350, 705);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // mudarDeMenuParaBotõesToolStripMenuItem
            // 
            this.mudarDeMenuParaBotõesToolStripMenuItem.Name = "mudarDeMenuParaBotõesToolStripMenuItem";
            this.mudarDeMenuParaBotõesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mudarDeMenuParaBotõesToolStripMenuItem.Text = "Mudar para botões";
            this.mudarDeMenuParaBotõesToolStripMenuItem.Click += new System.EventHandler(this.mudarDeMenuParaBotõesToolStripMenuItem_Click);
            // 
            // pnBtns
            // 
            this.pnBtns.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnBtns.BackgroundImage")));
            this.pnBtns.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnBtns.Controls.Add(this.btnUsarMenu);
            this.pnBtns.Controls.Add(this.btnConsultarMaterias);
            this.pnBtns.Controls.Add(this.btnConsultarCursos);
            this.pnBtns.Controls.Add(this.btnConsultarProfessores);
            this.pnBtns.Controls.Add(this.btnConsultarAlunos);
            this.pnBtns.Controls.Add(this.btnCadastrarMaterias);
            this.pnBtns.Controls.Add(this.btnCadastraCursos);
            this.pnBtns.Controls.Add(this.btnCadastrarProfessores);
            this.pnBtns.Controls.Add(this.btnCadastroAlunos);
            this.pnBtns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBtns.Location = new System.Drawing.Point(0, 24);
            this.pnBtns.Name = "pnBtns";
            this.pnBtns.Size = new System.Drawing.Size(1350, 705);
            this.pnBtns.TabIndex = 10;
            this.pnBtns.Visible = false;
            // 
            // btnCadastroAlunos
            // 
            this.btnCadastroAlunos.Location = new System.Drawing.Point(59, 147);
            this.btnCadastroAlunos.Name = "btnCadastroAlunos";
            this.btnCadastroAlunos.Size = new System.Drawing.Size(252, 148);
            this.btnCadastroAlunos.TabIndex = 0;
            this.btnCadastroAlunos.Text = "Cadastrar Alunos";
            this.btnCadastroAlunos.UseVisualStyleBackColor = true;
            this.btnCadastroAlunos.Click += new System.EventHandler(this.btnCadastroAlunos_Click);
            // 
            // btnCadastrarProfessores
            // 
            this.btnCadastrarProfessores.Location = new System.Drawing.Point(347, 147);
            this.btnCadastrarProfessores.Name = "btnCadastrarProfessores";
            this.btnCadastrarProfessores.Size = new System.Drawing.Size(252, 148);
            this.btnCadastrarProfessores.TabIndex = 1;
            this.btnCadastrarProfessores.Text = "Cadastrar Professores";
            this.btnCadastrarProfessores.UseVisualStyleBackColor = true;
            this.btnCadastrarProfessores.Click += new System.EventHandler(this.btnCadastrarProfessores_Click);
            // 
            // btnCadastraCursos
            // 
            this.btnCadastraCursos.Location = new System.Drawing.Point(643, 147);
            this.btnCadastraCursos.Name = "btnCadastraCursos";
            this.btnCadastraCursos.Size = new System.Drawing.Size(252, 148);
            this.btnCadastraCursos.TabIndex = 2;
            this.btnCadastraCursos.Text = "Cadastrar Cursos";
            this.btnCadastraCursos.UseVisualStyleBackColor = true;
            this.btnCadastraCursos.Click += new System.EventHandler(this.btnCadastraCursos_Click);
            // 
            // btnCadastrarMaterias
            // 
            this.btnCadastrarMaterias.Location = new System.Drawing.Point(939, 147);
            this.btnCadastrarMaterias.Name = "btnCadastrarMaterias";
            this.btnCadastrarMaterias.Size = new System.Drawing.Size(252, 148);
            this.btnCadastrarMaterias.TabIndex = 3;
            this.btnCadastrarMaterias.Text = "Cadastrar Matérias";
            this.btnCadastrarMaterias.UseVisualStyleBackColor = true;
            this.btnCadastrarMaterias.Click += new System.EventHandler(this.btnCadastrarMaterias_Click);
            // 
            // btnConsultarMaterias
            // 
            this.btnConsultarMaterias.Location = new System.Drawing.Point(939, 360);
            this.btnConsultarMaterias.Name = "btnConsultarMaterias";
            this.btnConsultarMaterias.Size = new System.Drawing.Size(252, 148);
            this.btnConsultarMaterias.TabIndex = 7;
            this.btnConsultarMaterias.Text = "Consultar Matérias";
            this.btnConsultarMaterias.UseVisualStyleBackColor = true;
            this.btnConsultarMaterias.Click += new System.EventHandler(this.btnConsultarMaterias_Click);
            // 
            // btnConsultarCursos
            // 
            this.btnConsultarCursos.Location = new System.Drawing.Point(643, 360);
            this.btnConsultarCursos.Name = "btnConsultarCursos";
            this.btnConsultarCursos.Size = new System.Drawing.Size(252, 148);
            this.btnConsultarCursos.TabIndex = 6;
            this.btnConsultarCursos.Text = "Consultar Cursos";
            this.btnConsultarCursos.UseVisualStyleBackColor = true;
            this.btnConsultarCursos.Click += new System.EventHandler(this.btnConsultarCursos_Click);
            // 
            // btnConsultarProfessores
            // 
            this.btnConsultarProfessores.Location = new System.Drawing.Point(347, 360);
            this.btnConsultarProfessores.Name = "btnConsultarProfessores";
            this.btnConsultarProfessores.Size = new System.Drawing.Size(252, 148);
            this.btnConsultarProfessores.TabIndex = 5;
            this.btnConsultarProfessores.Text = "Consultar Professores";
            this.btnConsultarProfessores.UseVisualStyleBackColor = true;
            this.btnConsultarProfessores.Click += new System.EventHandler(this.btnConsultarProfessores_Click);
            // 
            // btnConsultarAlunos
            // 
            this.btnConsultarAlunos.Location = new System.Drawing.Point(59, 360);
            this.btnConsultarAlunos.Name = "btnConsultarAlunos";
            this.btnConsultarAlunos.Size = new System.Drawing.Size(252, 148);
            this.btnConsultarAlunos.TabIndex = 4;
            this.btnConsultarAlunos.Text = "Consultar Alunos";
            this.btnConsultarAlunos.UseVisualStyleBackColor = true;
            this.btnConsultarAlunos.Click += new System.EventHandler(this.btnConsultarAlunos_Click);
            // 
            // btnUsarMenu
            // 
            this.btnUsarMenu.Location = new System.Drawing.Point(59, 41);
            this.btnUsarMenu.Name = "btnUsarMenu";
            this.btnUsarMenu.Size = new System.Drawing.Size(252, 80);
            this.btnUsarMenu.TabIndex = 8;
            this.btnUsarMenu.Text = "Mudar para Menu";
            this.btnUsarMenu.UseVisualStyleBackColor = true;
            this.btnUsarMenu.Click += new System.EventHandler(this.btnUsarMenu_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.pnBtns);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnBtns.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarAlunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarProfessorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarCursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarDiciplinasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarAlunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarProfessorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarCursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarMateriasToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem mudarDeMenuParaBotõesToolStripMenuItem;
        private System.Windows.Forms.Panel pnBtns;
        private System.Windows.Forms.Button btnConsultarMaterias;
        private System.Windows.Forms.Button btnConsultarCursos;
        private System.Windows.Forms.Button btnConsultarProfessores;
        private System.Windows.Forms.Button btnConsultarAlunos;
        private System.Windows.Forms.Button btnCadastrarMaterias;
        private System.Windows.Forms.Button btnCadastraCursos;
        private System.Windows.Forms.Button btnCadastrarProfessores;
        private System.Windows.Forms.Button btnCadastroAlunos;
        private System.Windows.Forms.Button btnUsarMenu;
    }
}

