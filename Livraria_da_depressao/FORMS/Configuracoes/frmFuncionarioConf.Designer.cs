namespace Livraria_da_depressao.FORMS.Configuracoes
{
    partial class frmFuncionarioConf
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
            this.btCancelarFuncionario = new System.Windows.Forms.Button();
            this.btCadastrarFuncionario = new System.Windows.Forms.Button();
            this.btSalvarAlteracoesFuncionario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeFunc = new System.Windows.Forms.TextBox();
            this.txtCargoFunc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboSexoFunc = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btCancelarFuncionario
            // 
            this.btCancelarFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btCancelarFuncionario.FlatAppearance.BorderSize = 0;
            this.btCancelarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelarFuncionario.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelarFuncionario.Location = new System.Drawing.Point(113, 248);
            this.btCancelarFuncionario.Name = "btCancelarFuncionario";
            this.btCancelarFuncionario.Size = new System.Drawing.Size(120, 31);
            this.btCancelarFuncionario.TabIndex = 23;
            this.btCancelarFuncionario.Text = "CANCELAR";
            this.btCancelarFuncionario.UseVisualStyleBackColor = false;
            this.btCancelarFuncionario.Click += new System.EventHandler(this.btCancelarFuncionario_Click);
            // 
            // btCadastrarFuncionario
            // 
            this.btCadastrarFuncionario.BackColor = System.Drawing.Color.RoyalBlue;
            this.btCadastrarFuncionario.FlatAppearance.BorderSize = 0;
            this.btCadastrarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrarFuncionario.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrarFuncionario.ForeColor = System.Drawing.Color.White;
            this.btCadastrarFuncionario.Location = new System.Drawing.Point(253, 248);
            this.btCadastrarFuncionario.Name = "btCadastrarFuncionario";
            this.btCadastrarFuncionario.Size = new System.Drawing.Size(120, 31);
            this.btCadastrarFuncionario.TabIndex = 19;
            this.btCadastrarFuncionario.Text = "CADASTRAR";
            this.btCadastrarFuncionario.UseVisualStyleBackColor = false;
            this.btCadastrarFuncionario.Click += new System.EventHandler(this.btCadastrarFuncionario_Click);
            // 
            // btSalvarAlteracoesFuncionario
            // 
            this.btSalvarAlteracoesFuncionario.BackColor = System.Drawing.Color.RoyalBlue;
            this.btSalvarAlteracoesFuncionario.FlatAppearance.BorderSize = 0;
            this.btSalvarAlteracoesFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalvarAlteracoesFuncionario.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvarAlteracoesFuncionario.ForeColor = System.Drawing.Color.White;
            this.btSalvarAlteracoesFuncionario.Location = new System.Drawing.Point(253, 249);
            this.btSalvarAlteracoesFuncionario.Name = "btSalvarAlteracoesFuncionario";
            this.btSalvarAlteracoesFuncionario.Size = new System.Drawing.Size(120, 31);
            this.btSalvarAlteracoesFuncionario.TabIndex = 24;
            this.btSalvarAlteracoesFuncionario.Text = "SALVAR";
            this.btSalvarAlteracoesFuncionario.UseVisualStyleBackColor = false;
            this.btSalvarAlteracoesFuncionario.Visible = false;
            this.btSalvarAlteracoesFuncionario.Click += new System.EventHandler(this.btSalvarAlteracoesFuncionario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Sexo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Cargo:";
            // 
            // txtNomeFunc
            // 
            this.txtNomeFunc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFunc.Location = new System.Drawing.Point(243, 66);
            this.txtNomeFunc.Name = "txtNomeFunc";
            this.txtNomeFunc.Size = new System.Drawing.Size(225, 26);
            this.txtNomeFunc.TabIndex = 18;
            // 
            // txtCargoFunc
            // 
            this.txtCargoFunc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargoFunc.Location = new System.Drawing.Point(243, 116);
            this.txtCargoFunc.Name = "txtCargoFunc";
            this.txtCargoFunc.Size = new System.Drawing.Size(224, 26);
            this.txtCargoFunc.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nome do funcionario:";
            // 
            // cboSexoFunc
            // 
            this.cboSexoFunc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSexoFunc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSexoFunc.FormattingEnabled = true;
            this.cboSexoFunc.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Indefinido"});
            this.cboSexoFunc.Location = new System.Drawing.Point(243, 166);
            this.cboSexoFunc.Name = "cboSexoFunc";
            this.cboSexoFunc.Size = new System.Drawing.Size(221, 28);
            this.cboSexoFunc.TabIndex = 17;
            // 
            // frmFuncionarioConf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(506, 325);
            this.Controls.Add(this.btSalvarAlteracoesFuncionario);
            this.Controls.Add(this.btCancelarFuncionario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCargoFunc);
            this.Controls.Add(this.btCadastrarFuncionario);
            this.Controls.Add(this.txtNomeFunc);
            this.Controls.Add(this.cboSexoFunc);
            this.Controls.Add(this.label1);
            this.Name = "frmFuncionarioConf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurar Funcionário";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFuncionarioConf_FormClosing);
            this.Load += new System.EventHandler(this.frmFuncionarioConf_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancelarFuncionario;
        private System.Windows.Forms.Button btCadastrarFuncionario;
        private System.Windows.Forms.Button btSalvarAlteracoesFuncionario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeFunc;
        private System.Windows.Forms.TextBox txtCargoFunc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboSexoFunc;
    }
}