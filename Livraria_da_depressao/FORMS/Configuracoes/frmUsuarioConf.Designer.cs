namespace Livraria_da_depressao.FORMS.Configuracoes
{
    partial class frmUsuarioConf
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
            this.btCadastrarUsuario = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cboNovaPermissao = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNovaSenha = new System.Windows.Forms.TextBox();
            this.txtNovoUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btCancelarUsuario = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cboFuncionario = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboCodigoFuncionario = new System.Windows.Forms.ComboBox();
            this.btEditarUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btCadastrarUsuario
            // 
            this.btCadastrarUsuario.BackColor = System.Drawing.Color.RoyalBlue;
            this.btCadastrarUsuario.FlatAppearance.BorderSize = 0;
            this.btCadastrarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrarUsuario.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrarUsuario.ForeColor = System.Drawing.Color.White;
            this.btCadastrarUsuario.Location = new System.Drawing.Point(264, 337);
            this.btCadastrarUsuario.Name = "btCadastrarUsuario";
            this.btCadastrarUsuario.Size = new System.Drawing.Size(133, 31);
            this.btCadastrarUsuario.TabIndex = 13;
            this.btCadastrarUsuario.Text = "CADASTRAR";
            this.btCadastrarUsuario.UseVisualStyleBackColor = false;
            this.btCadastrarUsuario.Click += new System.EventHandler(this.btCadastrarUsuario_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Permissão";
            // 
            // cboNovaPermissao
            // 
            this.cboNovaPermissao.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNovaPermissao.FormattingEnabled = true;
            this.cboNovaPermissao.Items.AddRange(new object[] {
            "Admin",
            "Comum"});
            this.cboNovaPermissao.Location = new System.Drawing.Point(212, 216);
            this.cboNovaPermissao.Name = "cboNovaPermissao";
            this.cboNovaPermissao.Size = new System.Drawing.Size(233, 28);
            this.cboNovaPermissao.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Senha:";
            // 
            // txtNovaSenha
            // 
            this.txtNovaSenha.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNovaSenha.Location = new System.Drawing.Point(212, 168);
            this.txtNovaSenha.Name = "txtNovaSenha";
            this.txtNovaSenha.Size = new System.Drawing.Size(232, 26);
            this.txtNovaSenha.TabIndex = 9;
            // 
            // txtNovoUsuario
            // 
            this.txtNovoUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNovoUsuario.Location = new System.Drawing.Point(213, 119);
            this.txtNovoUsuario.Name = "txtNovoUsuario";
            this.txtNovoUsuario.Size = new System.Drawing.Size(232, 26);
            this.txtNovoUsuario.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Usuario:";
            // 
            // btCancelarUsuario
            // 
            this.btCancelarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btCancelarUsuario.FlatAppearance.BorderSize = 0;
            this.btCancelarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelarUsuario.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelarUsuario.Location = new System.Drawing.Point(108, 337);
            this.btCancelarUsuario.Name = "btCancelarUsuario";
            this.btCancelarUsuario.Size = new System.Drawing.Size(133, 31);
            this.btCancelarUsuario.TabIndex = 14;
            this.btCancelarUsuario.Text = "CANCELAR";
            this.btCancelarUsuario.UseVisualStyleBackColor = false;
            this.btCancelarUsuario.Click += new System.EventHandler(this.btCancelarUsuario_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Funcionário:";
            // 
            // cboFuncionario
            // 
            this.cboFuncionario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFuncionario.FormattingEnabled = true;
            this.cboFuncionario.Location = new System.Drawing.Point(214, 72);
            this.cboFuncionario.Name = "cboFuncionario";
            this.cboFuncionario.Size = new System.Drawing.Size(233, 28);
            this.cboFuncionario.TabIndex = 16;
            this.cboFuncionario.TextChanged += new System.EventHandler(this.cboFuncionario_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Codigo:";
            this.label5.Visible = false;
            // 
            // cboCodigoFuncionario
            // 
            this.cboCodigoFuncionario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCodigoFuncionario.FormattingEnabled = true;
            this.cboCodigoFuncionario.Location = new System.Drawing.Point(213, 263);
            this.cboCodigoFuncionario.Name = "cboCodigoFuncionario";
            this.cboCodigoFuncionario.Size = new System.Drawing.Size(233, 28);
            this.cboCodigoFuncionario.TabIndex = 19;
            this.cboCodigoFuncionario.Visible = false;
            // 
            // btEditarUsuario
            // 
            this.btEditarUsuario.BackColor = System.Drawing.Color.RoyalBlue;
            this.btEditarUsuario.FlatAppearance.BorderSize = 0;
            this.btEditarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditarUsuario.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditarUsuario.ForeColor = System.Drawing.Color.White;
            this.btEditarUsuario.Location = new System.Drawing.Point(263, 338);
            this.btEditarUsuario.Name = "btEditarUsuario";
            this.btEditarUsuario.Size = new System.Drawing.Size(133, 31);
            this.btEditarUsuario.TabIndex = 20;
            this.btEditarUsuario.Text = "SALVAR";
            this.btEditarUsuario.UseVisualStyleBackColor = false;
            this.btEditarUsuario.Click += new System.EventHandler(this.btEditarUsuario_Click);
            // 
            // frmUsuarioConf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(511, 404);
            this.Controls.Add(this.btEditarUsuario);
            this.Controls.Add(this.cboCodigoFuncionario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboFuncionario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btCancelarUsuario);
            this.Controls.Add(this.btCadastrarUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboNovaPermissao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNovaSenha);
            this.Controls.Add(this.txtNovoUsuario);
            this.Controls.Add(this.label1);
            this.Name = "frmUsuarioConf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuário";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUsuarioConf_FormClosing);
            this.Load += new System.EventHandler(this.frmUsuarioConf_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCadastrarUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboNovaPermissao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNovaSenha;
        private System.Windows.Forms.TextBox txtNovoUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCancelarUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboFuncionario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboCodigoFuncionario;
        private System.Windows.Forms.Button btEditarUsuario;
    }
}