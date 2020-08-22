namespace Livraria_da_depressao.FORMS.Configuracoes
{
    partial class frmEditoraConf
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
            this.btCadastrarEditora = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btEditarEditora = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeEditora = new System.Windows.Forms.TextBox();
            this.txtCodigoEditora = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btCadastrarEditora
            // 
            this.btCadastrarEditora.BackColor = System.Drawing.Color.RoyalBlue;
            this.btCadastrarEditora.FlatAppearance.BorderSize = 0;
            this.btCadastrarEditora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrarEditora.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrarEditora.ForeColor = System.Drawing.Color.White;
            this.btCadastrarEditora.Location = new System.Drawing.Point(261, 240);
            this.btCadastrarEditora.Name = "btCadastrarEditora";
            this.btCadastrarEditora.Size = new System.Drawing.Size(123, 29);
            this.btCadastrarEditora.TabIndex = 0;
            this.btCadastrarEditora.Text = "CADASTRAR";
            this.btCadastrarEditora.UseVisualStyleBackColor = false;
            this.btCadastrarEditora.Click += new System.EventHandler(this.btCadastrarEditora_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btCancelar.FlatAppearance.BorderSize = 0;
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(104, 240);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(123, 29);
            this.btCancelar.TabIndex = 1;
            this.btCancelar.Text = "CANCELAR";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btEditarEditora
            // 
            this.btEditarEditora.BackColor = System.Drawing.Color.RoyalBlue;
            this.btEditarEditora.FlatAppearance.BorderSize = 0;
            this.btEditarEditora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditarEditora.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditarEditora.ForeColor = System.Drawing.Color.White;
            this.btEditarEditora.Location = new System.Drawing.Point(260, 239);
            this.btEditarEditora.Name = "btEditarEditora";
            this.btEditarEditora.Size = new System.Drawing.Size(123, 29);
            this.btEditarEditora.TabIndex = 2;
            this.btEditarEditora.Text = "SALVAR";
            this.btEditarEditora.UseVisualStyleBackColor = false;
            this.btEditarEditora.Visible = false;
            this.btEditarEditora.Click += new System.EventHandler(this.btEditarEditora_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome da Editora:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Código:";
            // 
            // txtNomeEditora
            // 
            this.txtNomeEditora.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeEditora.Location = new System.Drawing.Point(260, 98);
            this.txtNomeEditora.Name = "txtNomeEditora";
            this.txtNomeEditora.Size = new System.Drawing.Size(177, 26);
            this.txtNomeEditora.TabIndex = 5;
            // 
            // txtCodigoEditora
            // 
            this.txtCodigoEditora.Enabled = false;
            this.txtCodigoEditora.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoEditora.Location = new System.Drawing.Point(260, 152);
            this.txtCodigoEditora.Name = "txtCodigoEditora";
            this.txtCodigoEditora.Size = new System.Drawing.Size(85, 26);
            this.txtCodigoEditora.TabIndex = 6;
            // 
            // frmEditoraConf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(506, 325);
            this.Controls.Add(this.txtCodigoEditora);
            this.Controls.Add(this.txtNomeEditora);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btEditarEditora);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btCadastrarEditora);
            this.Name = "frmEditoraConf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editora";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEditoraConf_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCadastrarEditora;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btEditarEditora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeEditora;
        private System.Windows.Forms.TextBox txtCodigoEditora;
    }
}