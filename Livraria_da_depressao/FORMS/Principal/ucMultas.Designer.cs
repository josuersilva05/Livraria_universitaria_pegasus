namespace Livraria_da_depressao.FORMS
{
    partial class ucMultas
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
            this.dgvListaMultas = new System.Windows.Forms.DataGridView();
            this.idMulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsavel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEmprestimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoMulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diasAtraso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atendente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btAtualizarMulta = new System.Windows.Forms.Button();
            this.btNovaMulta = new System.Windows.Forms.Button();
            this.cboItemPesquisa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btCarregarMais = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaMultas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaMultas
            // 
            this.dgvListaMultas.AllowUserToAddRows = false;
            this.dgvListaMultas.AllowUserToDeleteRows = false;
            this.dgvListaMultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvListaMultas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMulta,
            this.livro,
            this.responsavel,
            this.idEmprestimo,
            this.status,
            this.tipoMulta,
            this.valor,
            this.diasAtraso,
            this.total,
            this.atendente});
            this.dgvListaMultas.Location = new System.Drawing.Point(40, 140);
            this.dgvListaMultas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvListaMultas.Name = "dgvListaMultas";
            this.dgvListaMultas.ReadOnly = true;
            this.dgvListaMultas.RowHeadersWidth = 15;
            this.dgvListaMultas.Size = new System.Drawing.Size(560, 320);
            this.dgvListaMultas.TabIndex = 5;
            // 
            // idMulta
            // 
            this.idMulta.HeaderText = "ID";
            this.idMulta.Name = "idMulta";
            this.idMulta.ReadOnly = true;
            this.idMulta.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idMulta.Width = 60;
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
            // idEmprestimo
            // 
            this.idEmprestimo.HeaderText = "ID Emprestimo";
            this.idEmprestimo.Name = "idEmprestimo";
            this.idEmprestimo.ReadOnly = true;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // tipoMulta
            // 
            this.tipoMulta.HeaderText = "Tipo de Multa";
            this.tipoMulta.Name = "tipoMulta";
            this.tipoMulta.ReadOnly = true;
            // 
            // valor
            // 
            this.valor.HeaderText = "Valor da Multa";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            // 
            // diasAtraso
            // 
            this.diasAtraso.HeaderText = "Dias Atraso";
            this.diasAtraso.Name = "diasAtraso";
            this.diasAtraso.ReadOnly = true;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // atendente
            // 
            this.atendente.HeaderText = "Atendente";
            this.atendente.Name = "atendente";
            this.atendente.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Quadro de Multas";
            // 
            // btAtualizarMulta
            // 
            this.btAtualizarMulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btAtualizarMulta.FlatAppearance.BorderSize = 0;
            this.btAtualizarMulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAtualizarMulta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAtualizarMulta.ForeColor = System.Drawing.Color.Black;
            this.btAtualizarMulta.Location = new System.Drawing.Point(620, 195);
            this.btAtualizarMulta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btAtualizarMulta.Name = "btAtualizarMulta";
            this.btAtualizarMulta.Size = new System.Drawing.Size(135, 35);
            this.btAtualizarMulta.TabIndex = 6;
            this.btAtualizarMulta.Text = "ATUALIZAR";
            this.btAtualizarMulta.UseVisualStyleBackColor = false;
            this.btAtualizarMulta.Click += new System.EventHandler(this.btAtualizarMulta_Click);
            // 
            // btNovaMulta
            // 
            this.btNovaMulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btNovaMulta.FlatAppearance.BorderSize = 0;
            this.btNovaMulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNovaMulta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovaMulta.ForeColor = System.Drawing.Color.Black;
            this.btNovaMulta.Location = new System.Drawing.Point(620, 145);
            this.btNovaMulta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btNovaMulta.Name = "btNovaMulta";
            this.btNovaMulta.Size = new System.Drawing.Size(135, 35);
            this.btNovaMulta.TabIndex = 7;
            this.btNovaMulta.Text = "NOVA";
            this.btNovaMulta.UseVisualStyleBackColor = false;
            this.btNovaMulta.Click += new System.EventHandler(this.btNovaMulta_Click);
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
            // ucMultas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btCarregarMais);
            this.Controls.Add(this.cboItemPesquisa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.btNovaMulta);
            this.Controls.Add(this.btAtualizarMulta);
            this.Controls.Add(this.dgvListaMultas);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucMultas";
            this.Size = new System.Drawing.Size(772, 545);
            this.Load += new System.EventHandler(this.ucMultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaMultas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaMultas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAtualizarMulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn livro;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsavel;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoMulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn diasAtraso;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn atendente;
        private System.Windows.Forms.Button btNovaMulta;
        private System.Windows.Forms.ComboBox cboItemPesquisa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btCarregarMais;
    }
}
