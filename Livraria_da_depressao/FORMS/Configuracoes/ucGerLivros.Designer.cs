namespace Livraria_da_depressao.FORMS.Configuracoes
{
    partial class ucGerLivros
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btExcluirLivro = new System.Windows.Forms.Button();
            this.btEditarLivro = new System.Windows.Forms.Button();
            this.btNovoLivro = new System.Windows.Forms.Button();
            this.dgvLivros = new System.Windows.Forms.DataGridView();
            this.idLivro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeLivro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoUnidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Gerenciar Livros";
            // 
            // btExcluirLivro
            // 
            this.btExcluirLivro.Location = new System.Drawing.Point(495, 192);
            this.btExcluirLivro.Name = "btExcluirLivro";
            this.btExcluirLivro.Size = new System.Drawing.Size(106, 26);
            this.btExcluirLivro.TabIndex = 9;
            this.btExcluirLivro.Text = "Excluir";
            this.btExcluirLivro.UseVisualStyleBackColor = true;
            this.btExcluirLivro.Click += new System.EventHandler(this.btExcluirLivro_Click);
            // 
            // btEditarLivro
            // 
            this.btEditarLivro.Location = new System.Drawing.Point(496, 151);
            this.btEditarLivro.Name = "btEditarLivro";
            this.btEditarLivro.Size = new System.Drawing.Size(106, 26);
            this.btEditarLivro.TabIndex = 8;
            this.btEditarLivro.Text = "Editar";
            this.btEditarLivro.UseVisualStyleBackColor = true;
            this.btEditarLivro.Click += new System.EventHandler(this.btEditarLivro_Click);
            // 
            // btNovoLivro
            // 
            this.btNovoLivro.Location = new System.Drawing.Point(494, 108);
            this.btNovoLivro.Name = "btNovoLivro";
            this.btNovoLivro.Size = new System.Drawing.Size(106, 26);
            this.btNovoLivro.TabIndex = 7;
            this.btNovoLivro.Text = "Novo";
            this.btNovoLivro.UseVisualStyleBackColor = true;
            this.btNovoLivro.Click += new System.EventHandler(this.btNovoLivro_Click);
            // 
            // dgvLivros
            // 
            this.dgvLivros.AllowUserToOrderColumns = true;
            this.dgvLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idLivro,
            this.nomeLivro,
            this.autor,
            this.categoria,
            this.editora,
            this.isbn,
            this.quantidade,
            this.precoUnidade});
            this.dgvLivros.Location = new System.Drawing.Point(24, 100);
            this.dgvLivros.Name = "dgvLivros";
            this.dgvLivros.RowHeadersWidth = 5;
            this.dgvLivros.Size = new System.Drawing.Size(440, 286);
            this.dgvLivros.TabIndex = 10;
            // 
            // idLivro
            // 
            this.idLivro.HeaderText = "ID";
            this.idLivro.Name = "idLivro";
            // 
            // nomeLivro
            // 
            this.nomeLivro.HeaderText = "Titulo";
            this.nomeLivro.Name = "nomeLivro";
            // 
            // autor
            // 
            this.autor.HeaderText = "Autor";
            this.autor.Name = "autor";
            // 
            // categoria
            // 
            this.categoria.HeaderText = "Gênero";
            this.categoria.Name = "categoria";
            // 
            // editora
            // 
            this.editora.HeaderText = "Editora";
            this.editora.Name = "editora";
            // 
            // isbn
            // 
            this.isbn.HeaderText = "ISBN";
            this.isbn.Name = "isbn";
            // 
            // quantidade
            // 
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.Name = "quantidade";
            // 
            // precoUnidade
            // 
            this.precoUnidade.HeaderText = "Preço Unidade";
            this.precoUnidade.Name = "precoUnidade";
            // 
            // ucGerLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvLivros);
            this.Controls.Add(this.btExcluirLivro);
            this.Controls.Add(this.btEditarLivro);
            this.Controls.Add(this.btNovoLivro);
            this.Controls.Add(this.label1);
            this.Name = "ucGerLivros";
            this.Size = new System.Drawing.Size(614, 452);
            this.Load += new System.EventHandler(this.ucGerLivros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btExcluirLivro;
        private System.Windows.Forms.Button btEditarLivro;
        private System.Windows.Forms.Button btNovoLivro;
        private System.Windows.Forms.DataGridView dgvLivros;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn editora;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoUnidade;
    }
}
