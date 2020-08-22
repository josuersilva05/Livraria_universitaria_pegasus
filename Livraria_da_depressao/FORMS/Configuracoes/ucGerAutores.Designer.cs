namespace Livraria_da_depressao.FORMS.Configuracoes
{
    partial class ucGerAutores
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
            this.dgvAutores = new System.Windows.Forms.DataGridView();
            this.idAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btEditarAutor = new System.Windows.Forms.Button();
            this.btNovoAutor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAutores
            // 
            this.dgvAutores.AllowUserToOrderColumns = true;
            this.dgvAutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAutor,
            this.nomeAutor});
            this.dgvAutores.Location = new System.Drawing.Point(30, 113);
            this.dgvAutores.Name = "dgvAutores";
            this.dgvAutores.RowHeadersWidth = 5;
            this.dgvAutores.Size = new System.Drawing.Size(440, 286);
            this.dgvAutores.TabIndex = 15;
            // 
            // idAutor
            // 
            this.idAutor.HeaderText = "ID";
            this.idAutor.Name = "idAutor";
            // 
            // nomeAutor
            // 
            this.nomeAutor.HeaderText = "Nome do Autor";
            this.nomeAutor.Name = "nomeAutor";
            // 
            // btEditarAutor
            // 
            this.btEditarAutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btEditarAutor.FlatAppearance.BorderSize = 0;
            this.btEditarAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditarAutor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditarAutor.Location = new System.Drawing.Point(490, 164);
            this.btEditarAutor.Name = "btEditarAutor";
            this.btEditarAutor.Size = new System.Drawing.Size(106, 28);
            this.btEditarAutor.TabIndex = 13;
            this.btEditarAutor.Text = "Editar";
            this.btEditarAutor.UseVisualStyleBackColor = false;
            this.btEditarAutor.Click += new System.EventHandler(this.btEditarAutor_Click);
            // 
            // btNovoAutor
            // 
            this.btNovoAutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btNovoAutor.FlatAppearance.BorderSize = 0;
            this.btNovoAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNovoAutor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovoAutor.ForeColor = System.Drawing.Color.Black;
            this.btNovoAutor.Location = new System.Drawing.Point(488, 121);
            this.btNovoAutor.Name = "btNovoAutor";
            this.btNovoAutor.Size = new System.Drawing.Size(106, 28);
            this.btNovoAutor.TabIndex = 12;
            this.btNovoAutor.Text = "Novo";
            this.btNovoAutor.UseVisualStyleBackColor = false;
            this.btNovoAutor.Click += new System.EventHandler(this.btNovoAutor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Gerenciar Autores";
            // 
            // ucGerAutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvAutores);
            this.Controls.Add(this.btEditarAutor);
            this.Controls.Add(this.btNovoAutor);
            this.Controls.Add(this.label1);
            this.Name = "ucGerAutores";
            this.Size = new System.Drawing.Size(614, 452);
            this.Load += new System.EventHandler(this.ucGerAutores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAutores;
        private System.Windows.Forms.Button btEditarAutor;
        private System.Windows.Forms.Button btNovoAutor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeAutor;
    }
}
