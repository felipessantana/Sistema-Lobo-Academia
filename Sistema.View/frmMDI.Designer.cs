namespace Sistema.View
{
    partial class frmMDI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMDI));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.UsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EmpresaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.AlunosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.FuncionariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treinamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treinoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UsuariosToolStripMenuItem,
            this.EmpresaToolStripMenuItem1,
            this.AlunosToolStripMenuItem1,
            this.FuncionariosToolStripMenuItem,
            this.treinamentoToolStripMenuItem,
            this.SairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1002, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // UsuariosToolStripMenuItem
            // 
            this.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem";
            this.UsuariosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.UsuariosToolStripMenuItem.Text = "Usuários";
            this.UsuariosToolStripMenuItem.Click += new System.EventHandler(this.UsuariosToolStripMenuItem_Click);
            // 
            // EmpresaToolStripMenuItem1
            // 
            this.EmpresaToolStripMenuItem1.Name = "EmpresaToolStripMenuItem1";
            this.EmpresaToolStripMenuItem1.Size = new System.Drawing.Size(64, 20);
            this.EmpresaToolStripMenuItem1.Text = "Empresa";
            this.EmpresaToolStripMenuItem1.Click += new System.EventHandler(this.EmpresaToolStripMenuItem1_Click);
            // 
            // AlunosToolStripMenuItem1
            // 
            this.AlunosToolStripMenuItem1.Name = "AlunosToolStripMenuItem1";
            this.AlunosToolStripMenuItem1.Size = new System.Drawing.Size(56, 20);
            this.AlunosToolStripMenuItem1.Text = "Alunos";
            this.AlunosToolStripMenuItem1.Click += new System.EventHandler(this.AlunosToolStripMenuItem1_Click);
            // 
            // FuncionariosToolStripMenuItem
            // 
            this.FuncionariosToolStripMenuItem.Name = "FuncionariosToolStripMenuItem";
            this.FuncionariosToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.FuncionariosToolStripMenuItem.Text = "Funcionários";
            this.FuncionariosToolStripMenuItem.Click += new System.EventHandler(this.FuncionariosToolStripMenuItem_Click);
            // 
            // treinamentoToolStripMenuItem
            // 
            this.treinamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.treinoToolStripMenuItem});
            this.treinamentoToolStripMenuItem.Name = "treinamentoToolStripMenuItem";
            this.treinamentoToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.treinamentoToolStripMenuItem.Text = "Cadastro de Ficha";
            // 
            // SairToolStripMenuItem
            // 
            this.SairToolStripMenuItem.Name = "SairToolStripMenuItem";
            this.SairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.SairToolStripMenuItem.Text = "Sair";
            this.SairToolStripMenuItem.Click += new System.EventHandler(this.SairToolStripMenuItem_Click);
            // 
            // treinoToolStripMenuItem
            // 
            this.treinoToolStripMenuItem.Name = "treinoToolStripMenuItem";
            this.treinoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.treinoToolStripMenuItem.Text = "Treino";
            this.treinoToolStripMenuItem.Click += new System.EventHandler(this.treinoToolStripMenuItem_Click);
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMDI";
            this.Text = "Lobo Academia - Pagina Inicial";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem UsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AlunosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem FuncionariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EmpresaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem treinamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem treinoToolStripMenuItem;
    }
}