namespace Livraria_da_depressao.FORMS.Configuracoes
{
    partial class frmLivroConf
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
            this.cboAutor = new System.Windows.Forms.ComboBox();
            this.cboEditora = new System.Windows.Forms.ComboBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtNomeLivro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btCadastrarLivro = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btEditarLivro = new System.Windows.Forms.Button();
            this.cboCodigoAutor = new System.Windows.Forms.ComboBox();
            this.cboCodigoEditora = new System.Windows.Forms.ComboBox();
            this.cboCodigoCategoria = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtValorLivro = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cboAutor
            // 
            this.cboAutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAutor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAutor.FormattingEnabled = true;
            this.cboAutor.Location = new System.Drawing.Point(269, 107);
            this.cboAutor.Name = "cboAutor";
            this.cboAutor.Size = new System.Drawing.Size(202, 28);
            this.cboAutor.TabIndex = 0;
            this.cboAutor.SelectedIndexChanged += new System.EventHandler(this.cboAutor_SelectedIndexChanged);
            // 
            // cboEditora
            // 
            this.cboEditora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEditora.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEditora.FormattingEnabled = true;
            this.cboEditora.Location = new System.Drawing.Point(269, 151);
            this.cboEditora.Name = "cboEditora";
            this.cboEditora.Size = new System.Drawing.Size(202, 28);
            this.cboEditora.TabIndex = 1;
            this.cboEditora.SelectedIndexChanged += new System.EventHandler(this.cboEditora_SelectedIndexChanged);
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(271, 196);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(202, 28);
            this.cboCategoria.TabIndex = 2;
            this.cboCategoria.SelectedIndexChanged += new System.EventHandler(this.cboCategoria_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Autor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Categoria:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Editora:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(272, 243);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(196, 26);
            this.txtQuantidade.TabIndex = 6;
            // 
            // txtNomeLivro
            // 
            this.txtNomeLivro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeLivro.Location = new System.Drawing.Point(270, 62);
            this.txtNomeLivro.Name = "txtNomeLivro";
            this.txtNomeLivro.Size = new System.Drawing.Size(201, 26);
            this.txtNomeLivro.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Quantidade:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(70, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nome do livro:";
            // 
            // btCadastrarLivro
            // 
            this.btCadastrarLivro.BackColor = System.Drawing.Color.RoyalBlue;
            this.btCadastrarLivro.FlatAppearance.BorderSize = 0;
            this.btCadastrarLivro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrarLivro.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrarLivro.ForeColor = System.Drawing.Color.White;
            this.btCadastrarLivro.Location = new System.Drawing.Point(275, 399);
            this.btCadastrarLivro.Name = "btCadastrarLivro";
            this.btCadastrarLivro.Size = new System.Drawing.Size(127, 32);
            this.btCadastrarLivro.TabIndex = 12;
            this.btCadastrarLivro.Text = "CADASTRAR";
            this.btCadastrarLivro.UseVisualStyleBackColor = false;
            this.btCadastrarLivro.Click += new System.EventHandler(this.btCadastrarLivro_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btCancelar.FlatAppearance.BorderSize = 0;
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(130, 399);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(127, 32);
            this.btCancelar.TabIndex = 13;
            this.btCancelar.Text = "CANCELAR";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btEditarLivro
            // 
            this.btEditarLivro.BackColor = System.Drawing.Color.RoyalBlue;
            this.btEditarLivro.FlatAppearance.BorderSize = 0;
            this.btEditarLivro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditarLivro.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditarLivro.ForeColor = System.Drawing.Color.White;
            this.btEditarLivro.Location = new System.Drawing.Point(274, 400);
            this.btEditarLivro.Name = "btEditarLivro";
            this.btEditarLivro.Size = new System.Drawing.Size(127, 32);
            this.btEditarLivro.TabIndex = 14;
            this.btEditarLivro.Text = "SALVAR";
            this.btEditarLivro.UseVisualStyleBackColor = false;
            this.btEditarLivro.Visible = false;
            this.btEditarLivro.Click += new System.EventHandler(this.btEditarLivro_Click);
            // 
            // cboCodigoAutor
            // 
            this.cboCodigoAutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCodigoAutor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCodigoAutor.FormattingEnabled = true;
            this.cboCodigoAutor.Location = new System.Drawing.Point(484, 108);
            this.cboCodigoAutor.Name = "cboCodigoAutor";
            this.cboCodigoAutor.Size = new System.Drawing.Size(49, 28);
            this.cboCodigoAutor.TabIndex = 15;
            this.cboCodigoAutor.Visible = false;
            // 
            // cboCodigoEditora
            // 
            this.cboCodigoEditora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCodigoEditora.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCodigoEditora.FormattingEnabled = true;
            this.cboCodigoEditora.Location = new System.Drawing.Point(483, 151);
            this.cboCodigoEditora.Name = "cboCodigoEditora";
            this.cboCodigoEditora.Size = new System.Drawing.Size(49, 28);
            this.cboCodigoEditora.TabIndex = 16;
            this.cboCodigoEditora.Visible = false;
            // 
            // cboCodigoCategoria
            // 
            this.cboCodigoCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCodigoCategoria.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCodigoCategoria.FormattingEnabled = true;
            this.cboCodigoCategoria.Location = new System.Drawing.Point(484, 196);
            this.cboCodigoCategoria.Name = "cboCodigoCategoria";
            this.cboCodigoCategoria.Size = new System.Drawing.Size(49, 28);
            this.cboCodigoCategoria.TabIndex = 17;
            this.cboCodigoCategoria.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(76, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "ISBN:";
            // 
            // txtIsbn
            // 
            this.txtIsbn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIsbn.Location = new System.Drawing.Point(274, 290);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(196, 26);
            this.txtIsbn.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(75, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Valor Unidade:";
            // 
            // txtValorLivro
            // 
            this.txtValorLivro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorLivro.Location = new System.Drawing.Point(273, 337);
            this.txtValorLivro.Name = "txtValorLivro";
            this.txtValorLivro.Size = new System.Drawing.Size(196, 26);
            this.txtValorLivro.TabIndex = 20;
            // 
            // frmLivroConf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(567, 463);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtValorLivro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIsbn);
            this.Controls.Add(this.cboCodigoCategoria);
            this.Controls.Add(this.cboCodigoEditora);
            this.Controls.Add(this.cboCodigoAutor);
            this.Controls.Add(this.btEditarLivro);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btCadastrarLivro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNomeLivro);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.cboEditora);
            this.Controls.Add(this.cboAutor);
            this.Name = "frmLivroConf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Livro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLivroConf_FormClosing);
            this.Load += new System.EventHandler(this.frmLivroConf_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboAutor;
        private System.Windows.Forms.ComboBox cboEditora;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtNomeLivro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btCadastrarLivro;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btEditarLivro;
        private System.Windows.Forms.ComboBox cboCodigoAutor;
        private System.Windows.Forms.ComboBox cboCodigoEditora;
        private System.Windows.Forms.ComboBox cboCodigoCategoria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtValorLivro;
    }
}