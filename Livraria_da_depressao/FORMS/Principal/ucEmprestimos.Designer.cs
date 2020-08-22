namespace Livraria_da_depressao.FORMS.UCs
{
    partial class ucEmprestimos
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
            this.dgvListaEmprestimos = new System.Windows.Forms.DataGridView();
            this.idEmprestimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsavel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEmprestimos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEntregaPrevista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.multa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atendente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorEmprestimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btAtualizarEmprestimo = new System.Windows.Forms.Button();
            this.btDetalhesEmprestimo = new System.Windows.Forms.Button();
            this.btNovoEmprestimo = new System.Windows.Forms.Button();
            this.cboItemPesquisa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btCarregarMais = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEmprestimos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de Empréstimos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvListaEmprestimos
            // 
            this.dgvListaEmprestimos.AllowUserToAddRows = false;
            this.dgvListaEmprestimos.AllowUserToDeleteRows = false;
            this.dgvListaEmprestimos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvListaEmprestimos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEmprestimo,
            this.livro,
            this.responsavel,
            this.dataEmprestimos,
            this.dataEntregaPrevista,
            this.dataEntrega,
            this.status,
            this.multa,
            this.atendente,
            this.valorEmprestimo});
            this.dgvListaEmprestimos.Location = new System.Drawing.Point(40, 140);
            this.dgvListaEmprestimos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListaEmprestimos.Name = "dgvListaEmprestimos";
            this.dgvListaEmprestimos.ReadOnly = true;
            this.dgvListaEmprestimos.RowHeadersWidth = 15;
            this.dgvListaEmprestimos.Size = new System.Drawing.Size(560, 320);
            this.dgvListaEmprestimos.TabIndex = 1;
            // 
            // idEmprestimo
            // 
            this.idEmprestimo.HeaderText = "ID";
            this.idEmprestimo.Name = "idEmprestimo";
            this.idEmprestimo.ReadOnly = true;
            // 
            // livro
            // 
            this.livro.HeaderText = "Livro";
            this.livro.Name = "livro";
            this.livro.ReadOnly = true;
            // 
            // responsavel
            // 
            this.responsavel.HeaderText = "Responsável";
            this.responsavel.Name = "responsavel";
            this.responsavel.ReadOnly = true;
            // 
            // dataEmprestimos
            // 
            this.dataEmprestimos.HeaderText = "Emprestado em";
            this.dataEmprestimos.Name = "dataEmprestimos";
            this.dataEmprestimos.ReadOnly = true;
            // 
            // dataEntregaPrevista
            // 
            this.dataEntregaPrevista.HeaderText = "Entrega Prevista";
            this.dataEntregaPrevista.Name = "dataEntregaPrevista";
            this.dataEntregaPrevista.ReadOnly = true;
            // 
            // dataEntrega
            // 
            this.dataEntrega.HeaderText = "Entregue em";
            this.dataEntrega.Name = "dataEntrega";
            this.dataEntrega.ReadOnly = true;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // multa
            // 
            this.multa.HeaderText = "Multa";
            this.multa.Name = "multa";
            this.multa.ReadOnly = true;
            // 
            // atendente
            // 
            this.atendente.HeaderText = "Atendente";
            this.atendente.Name = "atendente";
            this.atendente.ReadOnly = true;
            // 
            // valorEmprestimo
            // 
            this.valorEmprestimo.HeaderText = "Valor Emprestimo";
            this.valorEmprestimo.Name = "valorEmprestimo";
            this.valorEmprestimo.ReadOnly = true;
            // 
            // btAtualizarEmprestimo
            // 
            this.btAtualizarEmprestimo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btAtualizarEmprestimo.FlatAppearance.BorderSize = 0;
            this.btAtualizarEmprestimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAtualizarEmprestimo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAtualizarEmprestimo.ForeColor = System.Drawing.Color.Black;
            this.btAtualizarEmprestimo.Location = new System.Drawing.Point(620, 195);
            this.btAtualizarEmprestimo.Margin = new System.Windows.Forms.Padding(4);
            this.btAtualizarEmprestimo.Name = "btAtualizarEmprestimo";
            this.btAtualizarEmprestimo.Size = new System.Drawing.Size(135, 35);
            this.btAtualizarEmprestimo.TabIndex = 2;
            this.btAtualizarEmprestimo.Text = "ATUALIZAR";
            this.btAtualizarEmprestimo.UseVisualStyleBackColor = false;
            this.btAtualizarEmprestimo.Click += new System.EventHandler(this.btAtualizarEmprestimo_Click);
            // 
            // btDetalhesEmprestimo
            // 
            this.btDetalhesEmprestimo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btDetalhesEmprestimo.FlatAppearance.BorderSize = 0;
            this.btDetalhesEmprestimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDetalhesEmprestimo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDetalhesEmprestimo.ForeColor = System.Drawing.Color.Black;
            this.btDetalhesEmprestimo.Location = new System.Drawing.Point(620, 245);
            this.btDetalhesEmprestimo.Margin = new System.Windows.Forms.Padding(4);
            this.btDetalhesEmprestimo.Name = "btDetalhesEmprestimo";
            this.btDetalhesEmprestimo.Size = new System.Drawing.Size(135, 35);
            this.btDetalhesEmprestimo.TabIndex = 3;
            this.btDetalhesEmprestimo.Text = "[+] DETALHES";
            this.btDetalhesEmprestimo.UseVisualStyleBackColor = false;
            this.btDetalhesEmprestimo.Click += new System.EventHandler(this.btDetalhesEmprestimo_Click);
            // 
            // btNovoEmprestimo
            // 
            this.btNovoEmprestimo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btNovoEmprestimo.FlatAppearance.BorderSize = 0;
            this.btNovoEmprestimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNovoEmprestimo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovoEmprestimo.ForeColor = System.Drawing.Color.Black;
            this.btNovoEmprestimo.Location = new System.Drawing.Point(620, 145);
            this.btNovoEmprestimo.Margin = new System.Windows.Forms.Padding(4);
            this.btNovoEmprestimo.Name = "btNovoEmprestimo";
            this.btNovoEmprestimo.Size = new System.Drawing.Size(135, 35);
            this.btNovoEmprestimo.TabIndex = 4;
            this.btNovoEmprestimo.Text = "NOVO";
            this.btNovoEmprestimo.UseVisualStyleBackColor = false;
            this.btNovoEmprestimo.Click += new System.EventHandler(this.btNovoEmprestimo_Click);
            // 
            // cboItemPesquisa
            // 
            this.cboItemPesquisa.BackColor = System.Drawing.Color.White;
            this.cboItemPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboItemPesquisa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboItemPesquisa.FormattingEnabled = true;
            this.cboItemPesquisa.Items.AddRange(new object[] {
            "NOME",
            "CPF"});
            this.cboItemPesquisa.Location = new System.Drawing.Point(455, 95);
            this.cboItemPesquisa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboItemPesquisa.Name = "cboItemPesquisa";
            this.cboItemPesquisa.Size = new System.Drawing.Size(126, 25);
            this.cboItemPesquisa.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(335, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Pesquisar por:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Pesquisar:";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(130, 95);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(174, 23);
            this.txtPesquisa.TabIndex = 14;
            // 
            // btCarregarMais
            // 
            this.btCarregarMais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btCarregarMais.FlatAppearance.BorderSize = 0;
            this.btCarregarMais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCarregarMais.Location = new System.Drawing.Point(45, 480);
            this.btCarregarMais.Margin = new System.Windows.Forms.Padding(4);
            this.btCarregarMais.Name = "btCarregarMais";
            this.btCarregarMais.Size = new System.Drawing.Size(140, 30);
            this.btCarregarMais.TabIndex = 18;
            this.btCarregarMais.Text = "[+] Carregar mais";
            this.btCarregarMais.UseVisualStyleBackColor = false;
            // 
            // ucEmprestimos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btCarregarMais);
            this.Controls.Add(this.cboItemPesquisa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.btNovoEmprestimo);
            this.Controls.Add(this.btDetalhesEmprestimo);
            this.Controls.Add(this.btAtualizarEmprestimo);
            this.Controls.Add(this.dgvListaEmprestimos);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucEmprestimos";
            this.Size = new System.Drawing.Size(772, 545);
            this.Load += new System.EventHandler(this.ucEmprestimos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEmprestimos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListaEmprestimos;
        private System.Windows.Forms.Button btAtualizarEmprestimo;
        private System.Windows.Forms.Button btDetalhesEmprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn livro;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsavel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEmprestimos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEntregaPrevista;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn multa;
        private System.Windows.Forms.DataGridViewTextBoxColumn atendente;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorEmprestimo;
        private System.Windows.Forms.Button btNovoEmprestimo;
        private System.Windows.Forms.ComboBox cboItemPesquisa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btCarregarMais;
    }
}
