namespace Livraria_da_depressao.FORMS.Principal
{
    partial class ucClientes
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
            this.dgvListaClientes = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboItemPesquisa = new System.Windows.Forms.ComboBox();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btAtualizarCliente = new System.Windows.Forms.Button();
            this.btNovoCliente = new System.Windows.Forms.Button();
            this.btCarregarMais = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaClientes
            // 
            this.dgvListaClientes.AllowUserToAddRows = false;
            this.dgvListaClientes.AllowUserToDeleteRows = false;
            this.dgvListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvListaClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.cliente,
            this.cpf,
            this.email,
            this.status,
            this.celular,
            this.sexo});
            this.dgvListaClientes.Location = new System.Drawing.Point(40, 140);
            this.dgvListaClientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvListaClientes.Name = "dgvListaClientes";
            this.dgvListaClientes.ReadOnly = true;
            this.dgvListaClientes.RowHeadersWidth = 15;
            this.dgvListaClientes.Size = new System.Drawing.Size(560, 320);
            this.dgvListaClientes.TabIndex = 8;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // cliente
            // 
            this.cliente.HeaderText = "Cliente";
            this.cliente.Name = "cliente";
            this.cliente.ReadOnly = true;
            // 
            // cpf
            // 
            this.cpf.HeaderText = "CPF";
            this.cpf.Name = "cpf";
            this.cpf.ReadOnly = true;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // status
            // 
            this.status.HeaderText = "Status Cliente";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // celular
            // 
            this.celular.HeaderText = "Celular";
            this.celular.Name = "celular";
            this.celular.ReadOnly = true;
            // 
            // sexo
            // 
            this.sexo.HeaderText = "Sexo";
            this.sexo.Name = "sexo";
            this.sexo.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Clientes";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(130, 95);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(174, 23);
            this.txtPesquisa.TabIndex = 10;
            this.txtPesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisa_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Pesquisar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(335, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Pesquisar por:";
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
            this.cboItemPesquisa.TabIndex = 13;
            // 
            // btExcluir
            // 
            this.btExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExcluir.FlatAppearance.BorderSize = 0;
            this.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExcluir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.Location = new System.Drawing.Point(620, 245);
            this.btExcluir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(135, 35);
            this.btExcluir.TabIndex = 14;
            this.btExcluir.Text = "EXCLUIR";
            this.btExcluir.UseVisualStyleBackColor = false;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btAtualizarCliente
            // 
            this.btAtualizarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btAtualizarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAtualizarCliente.FlatAppearance.BorderSize = 0;
            this.btAtualizarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAtualizarCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAtualizarCliente.ForeColor = System.Drawing.Color.Black;
            this.btAtualizarCliente.Location = new System.Drawing.Point(620, 195);
            this.btAtualizarCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btAtualizarCliente.Name = "btAtualizarCliente";
            this.btAtualizarCliente.Size = new System.Drawing.Size(135, 35);
            this.btAtualizarCliente.TabIndex = 9;
            this.btAtualizarCliente.Text = "ATUALIZAR";
            this.btAtualizarCliente.UseVisualStyleBackColor = false;
            this.btAtualizarCliente.Click += new System.EventHandler(this.btAtualizarCliente_Click);
            // 
            // btNovoCliente
            // 
            this.btNovoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btNovoCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btNovoCliente.FlatAppearance.BorderSize = 0;
            this.btNovoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNovoCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovoCliente.ForeColor = System.Drawing.Color.Black;
            this.btNovoCliente.Location = new System.Drawing.Point(620, 145);
            this.btNovoCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btNovoCliente.Name = "btNovoCliente";
            this.btNovoCliente.Size = new System.Drawing.Size(135, 35);
            this.btNovoCliente.TabIndex = 15;
            this.btNovoCliente.Text = "NOVO";
            this.btNovoCliente.UseVisualStyleBackColor = false;
            this.btNovoCliente.Click += new System.EventHandler(this.btNovoCliente_Click);
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
            this.btCarregarMais.TabIndex = 16;
            this.btCarregarMais.Text = "[+] Carregar mais";
            this.btCarregarMais.UseVisualStyleBackColor = false;
            // 
            // ucClientes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btCarregarMais);
            this.Controls.Add(this.btNovoCliente);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.cboItemPesquisa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.btAtualizarCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvListaClientes);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucClientes";
            this.Size = new System.Drawing.Size(772, 545);
            this.Load += new System.EventHandler(this.ucClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvListaClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboItemPesquisa;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btAtualizarCliente;
        private System.Windows.Forms.Button btNovoCliente;
        private System.Windows.Forms.Button btCarregarMais;
    }
}
