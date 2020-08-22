namespace Livraria_da_depressao.FORMS.Configuracoes
{
    partial class frmAutorConf
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
            this.txtNomeAutor = new System.Windows.Forms.TextBox();
            this.txtCodigoAutor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btCadastrarAutor = new System.Windows.Forms.Button();
            this.btCancelarAutor = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNomeAutor
            // 
            this.txtNomeAutor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeAutor.Location = new System.Drawing.Point(199, 88);
            this.txtNomeAutor.Name = "txtNomeAutor";
            this.txtNomeAutor.Size = new System.Drawing.Size(201, 26);
            this.txtNomeAutor.TabIndex = 0;
            // 
            // txtCodigoAutor
            // 
            this.txtCodigoAutor.Enabled = false;
            this.txtCodigoAutor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoAutor.Location = new System.Drawing.Point(200, 132);
            this.txtCodigoAutor.Name = "txtCodigoAutor";
            this.txtCodigoAutor.Size = new System.Drawing.Size(83, 26);
            this.txtCodigoAutor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Autor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Codigo:";
            // 
            // btCadastrarAutor
            // 
            this.btCadastrarAutor.BackColor = System.Drawing.Color.RoyalBlue;
            this.btCadastrarAutor.FlatAppearance.BorderSize = 0;
            this.btCadastrarAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrarAutor.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrarAutor.ForeColor = System.Drawing.Color.White;
            this.btCadastrarAutor.Location = new System.Drawing.Point(263, 226);
            this.btCadastrarAutor.Name = "btCadastrarAutor";
            this.btCadastrarAutor.Size = new System.Drawing.Size(121, 29);
            this.btCadastrarAutor.TabIndex = 4;
            this.btCadastrarAutor.Text = "CADASTRAR";
            this.btCadastrarAutor.UseVisualStyleBackColor = false;
            this.btCadastrarAutor.Click += new System.EventHandler(this.btCadastrarAutor_Click);
            // 
            // btCancelarAutor
            // 
            this.btCancelarAutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btCancelarAutor.FlatAppearance.BorderSize = 0;
            this.btCancelarAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelarAutor.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelarAutor.Location = new System.Drawing.Point(114, 226);
            this.btCancelarAutor.Name = "btCancelarAutor";
            this.btCancelarAutor.Size = new System.Drawing.Size(121, 29);
            this.btCancelarAutor.TabIndex = 5;
            this.btCancelarAutor.Text = "CANCELAR";
            this.btCancelarAutor.UseVisualStyleBackColor = false;
            this.btCancelarAutor.Click += new System.EventHandler(this.btCancelarAutor_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btSalvar.FlatAppearance.BorderSize = 0;
            this.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalvar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvar.ForeColor = System.Drawing.Color.White;
            this.btSalvar.Location = new System.Drawing.Point(263, 227);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(121, 29);
            this.btSalvar.TabIndex = 6;
            this.btSalvar.Text = "SALVAR";
            this.btSalvar.UseVisualStyleBackColor = false;
            this.btSalvar.Visible = false;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // frmAutorConf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(506, 325);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.btCancelarAutor);
            this.Controls.Add(this.btCadastrarAutor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigoAutor);
            this.Controls.Add(this.txtNomeAutor);
            this.Name = "frmAutorConf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAutorConf_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeAutor;
        private System.Windows.Forms.TextBox txtCodigoAutor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btCadastrarAutor;
        private System.Windows.Forms.Button btCancelarAutor;
        private System.Windows.Forms.Button btSalvar;
    }
}