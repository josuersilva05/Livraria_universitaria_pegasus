namespace Livraria_da_depressao.FORMS.Configuracoes
{
    partial class frmCategoriaConf
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
            this.btCadastrarCategoria = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btEditarCategoria = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeCategoria = new System.Windows.Forms.TextBox();
            this.txtCodigoCategoria = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btCadastrarCategoria
            // 
            this.btCadastrarCategoria.BackColor = System.Drawing.Color.RoyalBlue;
            this.btCadastrarCategoria.FlatAppearance.BorderSize = 0;
            this.btCadastrarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrarCategoria.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrarCategoria.ForeColor = System.Drawing.Color.White;
            this.btCadastrarCategoria.Location = new System.Drawing.Point(261, 244);
            this.btCadastrarCategoria.Name = "btCadastrarCategoria";
            this.btCadastrarCategoria.Size = new System.Drawing.Size(121, 30);
            this.btCadastrarCategoria.TabIndex = 0;
            this.btCadastrarCategoria.Text = "CADASTRAR";
            this.btCadastrarCategoria.UseVisualStyleBackColor = false;
            this.btCadastrarCategoria.Click += new System.EventHandler(this.btCadastrarCategoria_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btCancelar.FlatAppearance.BorderSize = 0;
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(104, 244);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(121, 30);
            this.btCancelar.TabIndex = 1;
            this.btCancelar.Text = "CANCELAR";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btEditarCategoria
            // 
            this.btEditarCategoria.BackColor = System.Drawing.Color.RoyalBlue;
            this.btEditarCategoria.FlatAppearance.BorderSize = 0;
            this.btEditarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditarCategoria.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditarCategoria.ForeColor = System.Drawing.Color.White;
            this.btEditarCategoria.Location = new System.Drawing.Point(262, 244);
            this.btEditarCategoria.Name = "btEditarCategoria";
            this.btEditarCategoria.Size = new System.Drawing.Size(121, 30);
            this.btEditarCategoria.TabIndex = 2;
            this.btEditarCategoria.Text = "SALVAR";
            this.btEditarCategoria.UseVisualStyleBackColor = false;
            this.btEditarCategoria.Visible = false;
            this.btEditarCategoria.Click += new System.EventHandler(this.btEditarCategoria_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome da Categoria:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Código:";
            // 
            // txtNomeCategoria
            // 
            this.txtNomeCategoria.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCategoria.Location = new System.Drawing.Point(263, 100);
            this.txtNomeCategoria.Name = "txtNomeCategoria";
            this.txtNomeCategoria.Size = new System.Drawing.Size(154, 26);
            this.txtNomeCategoria.TabIndex = 5;
            // 
            // txtCodigoCategoria
            // 
            this.txtCodigoCategoria.Enabled = false;
            this.txtCodigoCategoria.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoCategoria.Location = new System.Drawing.Point(262, 149);
            this.txtCodigoCategoria.Name = "txtCodigoCategoria";
            this.txtCodigoCategoria.Size = new System.Drawing.Size(74, 26);
            this.txtCodigoCategoria.TabIndex = 6;
            // 
            // frmCategoriaConf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(506, 325);
            this.Controls.Add(this.txtCodigoCategoria);
            this.Controls.Add(this.txtNomeCategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btEditarCategoria);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btCadastrarCategoria);
            this.Name = "frmCategoriaConf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categoria";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCategoriaConf_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCadastrarCategoria;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btEditarCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeCategoria;
        private System.Windows.Forms.TextBox txtCodigoCategoria;
    }
}