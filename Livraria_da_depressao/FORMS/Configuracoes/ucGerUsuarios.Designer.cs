namespace Livraria_da_depressao.FORMS.Configuracoes
{
    partial class ucGerUsuarios
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
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.idUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btNovoUsuario = new System.Windows.Forms.Button();
            this.btEditarUsuario = new System.Windows.Forms.Button();
            this.btExcluirUsuario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToOrderColumns = true;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUsuario,
            this.nomeFuncionario,
            this.usuario,
            this.cargo,
            this.permissao});
            this.dgvUsuarios.Location = new System.Drawing.Point(18, 101);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowHeadersWidth = 5;
            this.dgvUsuarios.Size = new System.Drawing.Size(440, 286);
            this.dgvUsuarios.TabIndex = 0;
            // 
            // idUsuario
            // 
            this.idUsuario.HeaderText = "ID";
            this.idUsuario.Name = "idUsuario";
            // 
            // nomeFuncionario
            // 
            this.nomeFuncionario.HeaderText = "Nome";
            this.nomeFuncionario.Name = "nomeFuncionario";
            // 
            // usuario
            // 
            this.usuario.HeaderText = "Usuario";
            this.usuario.Name = "usuario";
            // 
            // cargo
            // 
            this.cargo.HeaderText = "Cargo";
            this.cargo.Name = "cargo";
            // 
            // permissao
            // 
            this.permissao.HeaderText = "Permissão";
            this.permissao.Name = "permissao";
            // 
            // btNovoUsuario
            // 
            this.btNovoUsuario.Location = new System.Drawing.Point(483, 106);
            this.btNovoUsuario.Name = "btNovoUsuario";
            this.btNovoUsuario.Size = new System.Drawing.Size(106, 26);
            this.btNovoUsuario.TabIndex = 1;
            this.btNovoUsuario.Text = "Novo";
            this.btNovoUsuario.UseVisualStyleBackColor = true;
            this.btNovoUsuario.Click += new System.EventHandler(this.btNovoUsuario_Click);
            // 
            // btEditarUsuario
            // 
            this.btEditarUsuario.Location = new System.Drawing.Point(485, 149);
            this.btEditarUsuario.Name = "btEditarUsuario";
            this.btEditarUsuario.Size = new System.Drawing.Size(106, 26);
            this.btEditarUsuario.TabIndex = 2;
            this.btEditarUsuario.Text = "Editar";
            this.btEditarUsuario.UseVisualStyleBackColor = true;
            this.btEditarUsuario.Click += new System.EventHandler(this.btEditarUsuario_Click);
            // 
            // btExcluirUsuario
            // 
            this.btExcluirUsuario.Location = new System.Drawing.Point(484, 190);
            this.btExcluirUsuario.Name = "btExcluirUsuario";
            this.btExcluirUsuario.Size = new System.Drawing.Size(106, 26);
            this.btExcluirUsuario.TabIndex = 3;
            this.btExcluirUsuario.Text = "Excluir";
            this.btExcluirUsuario.UseVisualStyleBackColor = true;
            this.btExcluirUsuario.Click += new System.EventHandler(this.btExcluirUsuario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gerenciar usuários";
            // 
            // ucGerUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btExcluirUsuario);
            this.Controls.Add(this.btEditarUsuario);
            this.Controls.Add(this.btNovoUsuario);
            this.Controls.Add(this.dgvUsuarios);
            this.Name = "ucGerUsuarios";
            this.Size = new System.Drawing.Size(614, 452);
            this.Load += new System.EventHandler(this.ucGerUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Button btNovoUsuario;
        private System.Windows.Forms.Button btEditarUsuario;
        private System.Windows.Forms.Button btExcluirUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn permissao;
        private System.Windows.Forms.Label label1;
    }
}
