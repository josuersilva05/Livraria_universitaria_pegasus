namespace Livraria_da_depressao.FORMS
{
    partial class ucReservas
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
            this.dgvListaReservas = new System.Windows.Forms.DataGridView();
            this.idReserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsavel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservadoEm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.retiradaPrevista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.retiradoEm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEmprestimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusReserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atendente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btAtualizarReserva = new System.Windows.Forms.Button();
            this.btNovaReserva = new System.Windows.Forms.Button();
            this.cboItemPesquisa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btCarregarMais = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaReservas
            // 
            this.dgvListaReservas.AllowUserToAddRows = false;
            this.dgvListaReservas.AllowUserToDeleteRows = false;
            this.dgvListaReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvListaReservas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idReserva,
            this.livro,
            this.responsavel,
            this.reservadoEm,
            this.retiradaPrevista,
            this.retiradoEm,
            this.idEmprestimo,
            this.statusReserva,
            this.atendente});
            this.dgvListaReservas.Location = new System.Drawing.Point(40, 140);
            this.dgvListaReservas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListaReservas.Name = "dgvListaReservas";
            this.dgvListaReservas.ReadOnly = true;
            this.dgvListaReservas.RowHeadersWidth = 15;
            this.dgvListaReservas.Size = new System.Drawing.Size(560, 320);
            this.dgvListaReservas.TabIndex = 3;
            // 
            // idReserva
            // 
            this.idReserva.HeaderText = "ID";
            this.idReserva.Name = "idReserva";
            this.idReserva.ReadOnly = true;
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
            // reservadoEm
            // 
            this.reservadoEm.HeaderText = "Reservado em";
            this.reservadoEm.Name = "reservadoEm";
            this.reservadoEm.ReadOnly = true;
            // 
            // retiradaPrevista
            // 
            this.retiradaPrevista.HeaderText = "Retirada Prevista";
            this.retiradaPrevista.Name = "retiradaPrevista";
            this.retiradaPrevista.ReadOnly = true;
            // 
            // retiradoEm
            // 
            this.retiradoEm.HeaderText = "Retirado em";
            this.retiradoEm.Name = "retiradoEm";
            this.retiradoEm.ReadOnly = true;
            // 
            // idEmprestimo
            // 
            this.idEmprestimo.HeaderText = "ID Emprestimo";
            this.idEmprestimo.Name = "idEmprestimo";
            this.idEmprestimo.ReadOnly = true;
            // 
            // statusReserva
            // 
            this.statusReserva.HeaderText = "Status";
            this.statusReserva.Name = "statusReserva";
            this.statusReserva.ReadOnly = true;
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
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reservas efetuadas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btAtualizarReserva
            // 
            this.btAtualizarReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btAtualizarReserva.FlatAppearance.BorderSize = 0;
            this.btAtualizarReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAtualizarReserva.Location = new System.Drawing.Point(620, 195);
            this.btAtualizarReserva.Name = "btAtualizarReserva";
            this.btAtualizarReserva.Size = new System.Drawing.Size(135, 35);
            this.btAtualizarReserva.TabIndex = 4;
            this.btAtualizarReserva.Text = "ATUALIZAR";
            this.btAtualizarReserva.UseVisualStyleBackColor = false;
            this.btAtualizarReserva.Click += new System.EventHandler(this.btAtualizarReserva_Click);
            // 
            // btNovaReserva
            // 
            this.btNovaReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btNovaReserva.FlatAppearance.BorderSize = 0;
            this.btNovaReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNovaReserva.Location = new System.Drawing.Point(620, 145);
            this.btNovaReserva.Name = "btNovaReserva";
            this.btNovaReserva.Size = new System.Drawing.Size(135, 35);
            this.btNovaReserva.TabIndex = 6;
            this.btNovaReserva.Text = "NOVO";
            this.btNovaReserva.UseVisualStyleBackColor = false;
            this.btNovaReserva.Click += new System.EventHandler(this.btNovaReserva_Click);
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
            // ucReservas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btCarregarMais);
            this.Controls.Add(this.cboItemPesquisa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.btNovaReserva);
            this.Controls.Add(this.btAtualizarReserva);
            this.Controls.Add(this.dgvListaReservas);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucReservas";
            this.Size = new System.Drawing.Size(772, 545);
            this.Load += new System.EventHandler(this.ucReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaReservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaReservas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAtualizarReserva;
        private System.Windows.Forms.Button btNovaReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn idReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn livro;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsavel;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservadoEm;
        private System.Windows.Forms.DataGridViewTextBoxColumn retiradaPrevista;
        private System.Windows.Forms.DataGridViewTextBoxColumn retiradoEm;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn atendente;
        private System.Windows.Forms.ComboBox cboItemPesquisa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btCarregarMais;
    }
}
