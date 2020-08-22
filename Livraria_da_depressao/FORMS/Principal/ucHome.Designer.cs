namespace Livraria_da_depressao.FORMS
{
    partial class ucHome
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
            this.dgvEmprestimosHoje = new System.Windows.Forms.DataGridView();
            this.idEmprestimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeLivro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEmprestimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPrevistaEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeAtendente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.dgvResultadosPesquisa = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disponivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panResultadosPesquisa = new System.Windows.Forms.Panel();
            this.btNovaReserva = new System.Windows.Forms.Button();
            this.btCadastrarCliente = new System.Windows.Forms.Button();
            this.btNovoEmprestimo = new System.Windows.Forms.Button();
            this.btCarregarMais = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboParmPesquisa = new System.Windows.Forms.ComboBox();
            this.panEntregas = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPesquisaLivro = new System.Windows.Forms.TextBox();
            this.lblErroPesquisa = new System.Windows.Forms.Label();
            this.chkPesquisaDigitacao = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestimosHoje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadosPesquisa)).BeginInit();
            this.panResultadosPesquisa.SuspendLayout();
            this.panEntregas.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "PESQUISAR:";
            // 
            // dgvEmprestimosHoje
            // 
            this.dgvEmprestimosHoje.AllowUserToAddRows = false;
            this.dgvEmprestimosHoje.AllowUserToDeleteRows = false;
            this.dgvEmprestimosHoje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEmprestimosHoje.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEmprestimo,
            this.nomeLivro,
            this.nomeCliente,
            this.dataEmprestimo,
            this.dataPrevistaEntrega,
            this.nomeAtendente});
            this.dgvEmprestimosHoje.Location = new System.Drawing.Point(19, 56);
            this.dgvEmprestimosHoje.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEmprestimosHoje.Name = "dgvEmprestimosHoje";
            this.dgvEmprestimosHoje.ReadOnly = true;
            this.dgvEmprestimosHoje.RowHeadersWidth = 15;
            this.dgvEmprestimosHoje.Size = new System.Drawing.Size(649, 257);
            this.dgvEmprestimosHoje.TabIndex = 5;
            // 
            // idEmprestimo
            // 
            this.idEmprestimo.HeaderText = "ID";
            this.idEmprestimo.Name = "idEmprestimo";
            this.idEmprestimo.ReadOnly = true;
            // 
            // nomeLivro
            // 
            this.nomeLivro.HeaderText = "Livro";
            this.nomeLivro.Name = "nomeLivro";
            this.nomeLivro.ReadOnly = true;
            // 
            // nomeCliente
            // 
            this.nomeCliente.HeaderText = "Cliente";
            this.nomeCliente.Name = "nomeCliente";
            this.nomeCliente.ReadOnly = true;
            // 
            // dataEmprestimo
            // 
            this.dataEmprestimo.HeaderText = "Emprestado";
            this.dataEmprestimo.Name = "dataEmprestimo";
            this.dataEmprestimo.ReadOnly = true;
            // 
            // dataPrevistaEntrega
            // 
            this.dataPrevistaEntrega.HeaderText = "Entrega prevista";
            this.dataPrevistaEntrega.Name = "dataPrevistaEntrega";
            this.dataPrevistaEntrega.ReadOnly = true;
            // 
            // nomeAtendente
            // 
            this.nomeAtendente.HeaderText = "Atendente";
            this.nomeAtendente.Name = "nomeAtendente";
            this.nomeAtendente.ReadOnly = true;
            // 
            // btPesquisar
            // 
            this.btPesquisar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPesquisar.FlatAppearance.BorderSize = 0;
            this.btPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPesquisar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesquisar.ForeColor = System.Drawing.Color.White;
            this.btPesquisar.Location = new System.Drawing.Point(520, 40);
            this.btPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(120, 35);
            this.btPesquisar.TabIndex = 7;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = false;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // dgvResultadosPesquisa
            // 
            this.dgvResultadosPesquisa.AllowUserToAddRows = false;
            this.dgvResultadosPesquisa.AllowUserToDeleteRows = false;
            this.dgvResultadosPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvResultadosPesquisa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.livro,
            this.autor,
            this.categoria,
            this.editora,
            this.disponivel});
            this.dgvResultadosPesquisa.Location = new System.Drawing.Point(20, 18);
            this.dgvResultadosPesquisa.Margin = new System.Windows.Forms.Padding(4);
            this.dgvResultadosPesquisa.Name = "dgvResultadosPesquisa";
            this.dgvResultadosPesquisa.ReadOnly = true;
            this.dgvResultadosPesquisa.RowHeadersWidth = 15;
            this.dgvResultadosPesquisa.Size = new System.Drawing.Size(465, 296);
            this.dgvResultadosPesquisa.TabIndex = 9;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // livro
            // 
            this.livro.HeaderText = "Livro";
            this.livro.Name = "livro";
            this.livro.ReadOnly = true;
            // 
            // autor
            // 
            this.autor.HeaderText = "Autor";
            this.autor.Name = "autor";
            this.autor.ReadOnly = true;
            this.autor.Visible = false;
            // 
            // categoria
            // 
            this.categoria.HeaderText = "Categoria";
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            this.categoria.Visible = false;
            // 
            // editora
            // 
            this.editora.HeaderText = "Editora";
            this.editora.Name = "editora";
            this.editora.ReadOnly = true;
            this.editora.Visible = false;
            // 
            // disponivel
            // 
            this.disponivel.HeaderText = "Disponível";
            this.disponivel.Name = "disponivel";
            this.disponivel.ReadOnly = true;
            this.disponivel.Visible = false;
            // 
            // panResultadosPesquisa
            // 
            this.panResultadosPesquisa.Controls.Add(this.btNovaReserva);
            this.panResultadosPesquisa.Controls.Add(this.btCadastrarCliente);
            this.panResultadosPesquisa.Controls.Add(this.btNovoEmprestimo);
            this.panResultadosPesquisa.Controls.Add(this.dgvResultadosPesquisa);
            this.panResultadosPesquisa.Controls.Add(this.btCarregarMais);
            this.panResultadosPesquisa.Location = new System.Drawing.Point(35, 146);
            this.panResultadosPesquisa.Margin = new System.Windows.Forms.Padding(4);
            this.panResultadosPesquisa.Name = "panResultadosPesquisa";
            this.panResultadosPesquisa.Size = new System.Drawing.Size(688, 377);
            this.panResultadosPesquisa.TabIndex = 10;
            this.panResultadosPesquisa.Visible = false;
            // 
            // btNovaReserva
            // 
            this.btNovaReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btNovaReserva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btNovaReserva.FlatAppearance.BorderSize = 0;
            this.btNovaReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNovaReserva.Location = new System.Drawing.Point(520, 135);
            this.btNovaReserva.Margin = new System.Windows.Forms.Padding(4);
            this.btNovaReserva.Name = "btNovaReserva";
            this.btNovaReserva.Size = new System.Drawing.Size(135, 35);
            this.btNovaReserva.TabIndex = 12;
            this.btNovaReserva.Text = "Efetuar reserva";
            this.btNovaReserva.UseVisualStyleBackColor = false;
            this.btNovaReserva.Click += new System.EventHandler(this.btNovaReserva_Click);
            // 
            // btCadastrarCliente
            // 
            this.btCadastrarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btCadastrarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCadastrarCliente.FlatAppearance.BorderSize = 0;
            this.btCadastrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrarCliente.Location = new System.Drawing.Point(520, 81);
            this.btCadastrarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btCadastrarCliente.Name = "btCadastrarCliente";
            this.btCadastrarCliente.Size = new System.Drawing.Size(135, 35);
            this.btCadastrarCliente.TabIndex = 11;
            this.btCadastrarCliente.Text = "Cadastrar cliente";
            this.btCadastrarCliente.UseVisualStyleBackColor = false;
            this.btCadastrarCliente.Click += new System.EventHandler(this.btCadastrarCliente_Click);
            // 
            // btNovoEmprestimo
            // 
            this.btNovoEmprestimo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btNovoEmprestimo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btNovoEmprestimo.FlatAppearance.BorderSize = 0;
            this.btNovoEmprestimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNovoEmprestimo.Location = new System.Drawing.Point(520, 27);
            this.btNovoEmprestimo.Margin = new System.Windows.Forms.Padding(4);
            this.btNovoEmprestimo.Name = "btNovoEmprestimo";
            this.btNovoEmprestimo.Size = new System.Drawing.Size(135, 35);
            this.btNovoEmprestimo.TabIndex = 10;
            this.btNovoEmprestimo.Text = "Novo Emprestimo";
            this.btNovoEmprestimo.UseVisualStyleBackColor = false;
            this.btNovoEmprestimo.Click += new System.EventHandler(this.btNovoEmprestimo_Click);
            // 
            // btCarregarMais
            // 
            this.btCarregarMais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btCarregarMais.FlatAppearance.BorderSize = 0;
            this.btCarregarMais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCarregarMais.Location = new System.Drawing.Point(31, 330);
            this.btCarregarMais.Margin = new System.Windows.Forms.Padding(4);
            this.btCarregarMais.Name = "btCarregarMais";
            this.btCarregarMais.Size = new System.Drawing.Size(140, 30);
            this.btCarregarMais.TabIndex = 13;
            this.btCarregarMais.Text = "[+] Carregar mais";
            this.btCarregarMais.UseVisualStyleBackColor = false;
            this.btCarregarMais.Click += new System.EventHandler(this.btCarregarMais_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "INCLUIR:";
            // 
            // cboParmPesquisa
            // 
            this.cboParmPesquisa.DisplayMember = "TUDO";
            this.cboParmPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboParmPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboParmPesquisa.FormattingEnabled = true;
            this.cboParmPesquisa.Items.AddRange(new object[] {
            "ID",
            "LIVROS",
            "AUTORES",
            "CATEGORIA",
            "EDITORA"});
            this.cboParmPesquisa.Location = new System.Drawing.Point(132, 78);
            this.cboParmPesquisa.Margin = new System.Windows.Forms.Padding(4);
            this.cboParmPesquisa.Name = "cboParmPesquisa";
            this.cboParmPesquisa.Size = new System.Drawing.Size(193, 24);
            this.cboParmPesquisa.TabIndex = 12;
            // 
            // panEntregas
            // 
            this.panEntregas.Controls.Add(this.label3);
            this.panEntregas.Controls.Add(this.dgvEmprestimosHoje);
            this.panEntregas.Location = new System.Drawing.Point(36, 147);
            this.panEntregas.Margin = new System.Windows.Forms.Padding(4);
            this.panEntregas.Name = "panEntregas";
            this.panEntregas.Size = new System.Drawing.Size(687, 376);
            this.panEntregas.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Entregas de hoje:";
            // 
            // txtPesquisaLivro
            // 
            this.txtPesquisaLivro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaLivro.Location = new System.Drawing.Point(132, 45);
            this.txtPesquisaLivro.Name = "txtPesquisaLivro";
            this.txtPesquisaLivro.ShortcutsEnabled = false;
            this.txtPesquisaLivro.Size = new System.Drawing.Size(310, 26);
            this.txtPesquisaLivro.TabIndex = 14;
            this.txtPesquisaLivro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPesquisaLivro_KeyUp);
            // 
            // lblErroPesquisa
            // 
            this.lblErroPesquisa.AutoSize = true;
            this.lblErroPesquisa.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErroPesquisa.ForeColor = System.Drawing.Color.Red;
            this.lblErroPesquisa.Location = new System.Drawing.Point(206, 115);
            this.lblErroPesquisa.Name = "lblErroPesquisa";
            this.lblErroPesquisa.Size = new System.Drawing.Size(0, 16);
            this.lblErroPesquisa.TabIndex = 15;
            // 
            // chkPesquisaDigitacao
            // 
            this.chkPesquisaDigitacao.AutoSize = true;
            this.chkPesquisaDigitacao.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPesquisaDigitacao.Location = new System.Drawing.Point(37, 109);
            this.chkPesquisaDigitacao.Name = "chkPesquisaDigitacao";
            this.chkPesquisaDigitacao.Size = new System.Drawing.Size(132, 20);
            this.chkPesquisaDigitacao.TabIndex = 16;
            this.chkPesquisaDigitacao.Text = "Pesquisar ao digitar";
            this.chkPesquisaDigitacao.UseVisualStyleBackColor = true;
            // 
            // ucHome
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.chkPesquisaDigitacao);
            this.Controls.Add(this.lblErroPesquisa);
            this.Controls.Add(this.txtPesquisaLivro);
            this.Controls.Add(this.cboParmPesquisa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panResultadosPesquisa);
            this.Controls.Add(this.panEntregas);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucHome";
            this.Size = new System.Drawing.Size(772, 545);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestimosHoje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadosPesquisa)).EndInit();
            this.panResultadosPesquisa.ResumeLayout(false);
            this.panEntregas.ResumeLayout(false);
            this.panEntregas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvEmprestimosHoje;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.DataGridView dgvResultadosPesquisa;
        private System.Windows.Forms.Panel panResultadosPesquisa;
        private System.Windows.Forms.Button btNovaReserva;
        private System.Windows.Forms.Button btCadastrarCliente;
        private System.Windows.Forms.Button btNovoEmprestimo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboParmPesquisa;
        private System.Windows.Forms.Button btCarregarMais;
        private System.Windows.Forms.Panel panEntregas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEmprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPrevistaEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeAtendente;
        private System.Windows.Forms.TextBox txtPesquisaLivro;
        private System.Windows.Forms.Label lblErroPesquisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn livro;
        private System.Windows.Forms.DataGridViewTextBoxColumn autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn editora;
        private System.Windows.Forms.DataGridViewTextBoxColumn disponivel;
        private System.Windows.Forms.CheckBox chkPesquisaDigitacao;
    }
}
