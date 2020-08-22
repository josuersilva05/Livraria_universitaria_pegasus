namespace Livraria_da_depressao.FORMS.Configuracoes
{
    partial class frmMultaConf
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeTipoMulta = new System.Windows.Forms.TextBox();
            this.txtCodigoMulta = new System.Windows.Forms.TextBox();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btCadastrarMulta = new System.Windows.Forms.Button();
            this.btEditarMulta = new System.Windows.Forms.Button();
            this.txtValorMulta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do tipo de multa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código:";
            // 
            // txtNomeTipoMulta
            // 
            this.txtNomeTipoMulta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeTipoMulta.Location = new System.Drawing.Point(264, 65);
            this.txtNomeTipoMulta.Name = "txtNomeTipoMulta";
            this.txtNomeTipoMulta.Size = new System.Drawing.Size(165, 26);
            this.txtNomeTipoMulta.TabIndex = 2;
            // 
            // txtCodigoMulta
            // 
            this.txtCodigoMulta.Enabled = false;
            this.txtCodigoMulta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoMulta.Location = new System.Drawing.Point(264, 161);
            this.txtCodigoMulta.Name = "txtCodigoMulta";
            this.txtCodigoMulta.Size = new System.Drawing.Size(79, 26);
            this.txtCodigoMulta.TabIndex = 3;
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btCancelar.FlatAppearance.BorderSize = 0;
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(111, 244);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(119, 29);
            this.btCancelar.TabIndex = 4;
            this.btCancelar.Text = "CANCELAR";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btCadastrarMulta
            // 
            this.btCadastrarMulta.BackColor = System.Drawing.Color.RoyalBlue;
            this.btCadastrarMulta.FlatAppearance.BorderSize = 0;
            this.btCadastrarMulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrarMulta.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrarMulta.ForeColor = System.Drawing.Color.White;
            this.btCadastrarMulta.Location = new System.Drawing.Point(264, 244);
            this.btCadastrarMulta.Name = "btCadastrarMulta";
            this.btCadastrarMulta.Size = new System.Drawing.Size(119, 29);
            this.btCadastrarMulta.TabIndex = 5;
            this.btCadastrarMulta.Text = "CADASTRAR";
            this.btCadastrarMulta.UseVisualStyleBackColor = false;
            this.btCadastrarMulta.Click += new System.EventHandler(this.btCadastrarMulta_Click);
            // 
            // btEditarMulta
            // 
            this.btEditarMulta.BackColor = System.Drawing.Color.RoyalBlue;
            this.btEditarMulta.FlatAppearance.BorderSize = 0;
            this.btEditarMulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditarMulta.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditarMulta.ForeColor = System.Drawing.Color.White;
            this.btEditarMulta.Location = new System.Drawing.Point(264, 244);
            this.btEditarMulta.Name = "btEditarMulta";
            this.btEditarMulta.Size = new System.Drawing.Size(119, 29);
            this.btEditarMulta.TabIndex = 6;
            this.btEditarMulta.Text = "SALVAR";
            this.btEditarMulta.UseVisualStyleBackColor = false;
            this.btEditarMulta.Visible = false;
            this.btEditarMulta.Click += new System.EventHandler(this.btEditarMulta_Click);
            // 
            // txtValorMulta
            // 
            this.txtValorMulta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorMulta.Location = new System.Drawing.Point(264, 112);
            this.txtValorMulta.Name = "txtValorMulta";
            this.txtValorMulta.Size = new System.Drawing.Size(165, 26);
            this.txtValorMulta.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Valor:";
            // 
            // frmMultaConf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(506, 325);
            this.Controls.Add(this.txtValorMulta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btEditarMulta);
            this.Controls.Add(this.btCadastrarMulta);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.txtCodigoMulta);
            this.Controls.Add(this.txtNomeTipoMulta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMultaConf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMultaConf_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeTipoMulta;
        private System.Windows.Forms.TextBox txtCodigoMulta;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btCadastrarMulta;
        private System.Windows.Forms.Button btEditarMulta;
        private System.Windows.Forms.TextBox txtValorMulta;
        private System.Windows.Forms.Label label3;
    }
}