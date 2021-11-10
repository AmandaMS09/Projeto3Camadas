namespace Projeto3Camadas
{
    partial class FrmCadastro
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
            this.pic_entrar = new System.Windows.Forms.PictureBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.lnklbl_esqueci = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pic_entrar)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_entrar
            // 
            this.pic_entrar.Location = new System.Drawing.Point(47, 56);
            this.pic_entrar.Name = "pic_entrar";
            this.pic_entrar.Size = new System.Drawing.Size(213, 205);
            this.pic_entrar.TabIndex = 0;
            this.pic_entrar.TabStop = false;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(325, 62);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(35, 13);
            this.lbl_email.TabIndex = 1;
            this.lbl_email.Text = "Email:";
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Location = new System.Drawing.Point(325, 119);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(41, 13);
            this.lbl_senha.TabIndex = 2;
            this.lbl_senha.Text = "Senha:";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(328, 87);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(152, 20);
            this.txt_email.TabIndex = 3;
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(328, 146);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(152, 20);
            this.txt_senha.TabIndex = 4;
            // 
            // btn_entrar
            // 
            this.btn_entrar.Location = new System.Drawing.Point(345, 185);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(124, 28);
            this.btn_entrar.TabIndex = 5;
            this.btn_entrar.Text = "Entrar";
            this.btn_entrar.UseVisualStyleBackColor = true;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // lnklbl_esqueci
            // 
            this.lnklbl_esqueci.AutoSize = true;
            this.lnklbl_esqueci.Location = new System.Drawing.Point(352, 248);
            this.lnklbl_esqueci.Name = "lnklbl_esqueci";
            this.lnklbl_esqueci.Size = new System.Drawing.Size(108, 13);
            this.lnklbl_esqueci.TabIndex = 6;
            this.lnklbl_esqueci.TabStop = true;
            this.lnklbl_esqueci.Text = "Esqueci minha senha";
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 322);
            this.Controls.Add(this.lnklbl_esqueci);
            this.Controls.Add(this.btn_entrar);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.pic_entrar);
            this.Name = "FrmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            ((System.ComponentModel.ISupportInitialize)(this.pic_entrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_entrar;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Button btn_entrar;
        private System.Windows.Forms.LinkLabel lnklbl_esqueci;
    }
}

