namespace ProjetoSistemaTI18N
{
    partial class Menu
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
            this.excluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cadastrar = new System.Windows.Forms.Button();
            this.consultar = new System.Windows.Forms.Button();
            this.atualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // excluir
            // 
            this.excluir.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excluir.Location = new System.Drawing.Point(46, 305);
            this.excluir.Name = "excluir";
            this.excluir.Size = new System.Drawing.Size(215, 60);
            this.excluir.TabIndex = 3;
            this.excluir.Text = "Excluir";
            this.excluir.UseVisualStyleBackColor = true;
            this.excluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Escolha uma das opções abaixo: ";
            // 
            // cadastrar
            // 
            this.cadastrar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrar.Location = new System.Drawing.Point(46, 107);
            this.cadastrar.Name = "cadastrar";
            this.cadastrar.Size = new System.Drawing.Size(214, 60);
            this.cadastrar.TabIndex = 5;
            this.cadastrar.Text = "Cadastrar";
            this.cadastrar.UseVisualStyleBackColor = true;
            this.cadastrar.Click += new System.EventHandler(this.Cadastrar_Click);
            // 
            // consultar
            // 
            this.consultar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultar.Location = new System.Drawing.Point(46, 173);
            this.consultar.Name = "consultar";
            this.consultar.Size = new System.Drawing.Size(215, 60);
            this.consultar.TabIndex = 6;
            this.consultar.Text = "Consultar";
            this.consultar.UseVisualStyleBackColor = true;
            this.consultar.Click += new System.EventHandler(this.Consultar_Click);
            // 
            // atualizar
            // 
            this.atualizar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atualizar.Location = new System.Drawing.Point(46, 239);
            this.atualizar.Name = "atualizar";
            this.atualizar.Size = new System.Drawing.Size(215, 60);
            this.atualizar.TabIndex = 7;
            this.atualizar.Text = "Atualizar";
            this.atualizar.UseVisualStyleBackColor = true;
            this.atualizar.Click += new System.EventHandler(this.Atualizar_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(300, 450);
            this.Controls.Add(this.atualizar);
            this.Controls.Add(this.consultar);
            this.Controls.Add(this.cadastrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.excluir);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button excluir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cadastrar;
        private System.Windows.Forms.Button consultar;
        private System.Windows.Forms.Button atualizar;
    }
}

