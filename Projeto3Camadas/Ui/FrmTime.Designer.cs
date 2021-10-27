namespace Projeto3Camadas.Ui
{
    partial class FrmTime
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
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_presidente = new System.Windows.Forms.Label();
            this.lbl_dataFundacao = new System.Windows.Forms.Label();
            this.lbl_historia = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_presidente = new System.Windows.Forms.TextBox();
            this.dtp_dataFundacao = new System.Windows.Forms.DateTimePicker();
            this.txt_historia = new System.Windows.Forms.TextBox();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.dgv_listaTimes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaTimes)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(12, 9);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(35, 13);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome";
            // 
            // lbl_presidente
            // 
            this.lbl_presidente.AutoSize = true;
            this.lbl_presidente.Location = new System.Drawing.Point(184, 9);
            this.lbl_presidente.Name = "lbl_presidente";
            this.lbl_presidente.Size = new System.Drawing.Size(57, 13);
            this.lbl_presidente.TabIndex = 1;
            this.lbl_presidente.Text = "Presidente";
            // 
            // lbl_dataFundacao
            // 
            this.lbl_dataFundacao.AutoSize = true;
            this.lbl_dataFundacao.Location = new System.Drawing.Point(354, 9);
            this.lbl_dataFundacao.Name = "lbl_dataFundacao";
            this.lbl_dataFundacao.Size = new System.Drawing.Size(55, 13);
            this.lbl_dataFundacao.TabIndex = 2;
            this.lbl_dataFundacao.Text = "Fundação";
            // 
            // lbl_historia
            // 
            this.lbl_historia.AutoSize = true;
            this.lbl_historia.Location = new System.Drawing.Point(12, 81);
            this.lbl_historia.Name = "lbl_historia";
            this.lbl_historia.Size = new System.Drawing.Size(42, 13);
            this.lbl_historia.TabIndex = 3;
            this.lbl_historia.Text = "História";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(15, 37);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(143, 20);
            this.txt_nome.TabIndex = 4;
            // 
            // txt_presidente
            // 
            this.txt_presidente.Location = new System.Drawing.Point(187, 37);
            this.txt_presidente.Name = "txt_presidente";
            this.txt_presidente.Size = new System.Drawing.Size(143, 20);
            this.txt_presidente.TabIndex = 5;
            // 
            // dtp_dataFundacao
            // 
            this.dtp_dataFundacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dataFundacao.Location = new System.Drawing.Point(355, 37);
            this.dtp_dataFundacao.Name = "dtp_dataFundacao";
            this.dtp_dataFundacao.Size = new System.Drawing.Size(109, 20);
            this.dtp_dataFundacao.TabIndex = 6;
            // 
            // txt_historia
            // 
            this.txt_historia.Location = new System.Drawing.Point(15, 108);
            this.txt_historia.Multiline = true;
            this.txt_historia.Name = "txt_historia";
            this.txt_historia.Size = new System.Drawing.Size(449, 80);
            this.txt_historia.TabIndex = 7;
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(77, 204);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cadastrar.TabIndex = 8;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(202, 204);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(75, 23);
            this.btn_editar.TabIndex = 9;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(328, 204);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_excluir.TabIndex = 10;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            // 
            // dgv_listaTimes
            // 
            this.dgv_listaTimes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listaTimes.Location = new System.Drawing.Point(12, 247);
            this.dgv_listaTimes.Name = "dgv_listaTimes";
            this.dgv_listaTimes.Size = new System.Drawing.Size(451, 154);
            this.dgv_listaTimes.TabIndex = 11;
            // 
            // FrmTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 413);
            this.Controls.Add(this.dgv_listaTimes);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.txt_historia);
            this.Controls.Add(this.dtp_dataFundacao);
            this.Controls.Add(this.txt_presidente);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_historia);
            this.Controls.Add(this.lbl_dataFundacao);
            this.Controls.Add(this.lbl_presidente);
            this.Controls.Add(this.lbl_nome);
            this.Name = "FrmTime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento de Times";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaTimes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_presidente;
        private System.Windows.Forms.Label lbl_dataFundacao;
        private System.Windows.Forms.Label lbl_historia;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_presidente;
        private System.Windows.Forms.DateTimePicker dtp_dataFundacao;
        private System.Windows.Forms.TextBox txt_historia;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.DataGridView dgv_listaTimes;
    }
}