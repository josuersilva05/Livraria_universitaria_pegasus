namespace Livraria_da_depressao.FORMS.Configuracoes
{
    partial class ucGerCategorias
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
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.idCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btEditarCategoria = new System.Windows.Forms.Button();
            this.btNovaCategoria = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.AllowUserToOrderColumns = true;
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCategoria,
            this.categoria});
            this.dgvCategorias.Location = new System.Drawing.Point(18, 113);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.RowHeadersWidth = 5;
            this.dgvCategorias.Size = new System.Drawing.Size(440, 286);
            this.dgvCategorias.TabIndex = 15;
            // 
            // idCategoria
            // 
            this.idCategoria.HeaderText = "ID";
            this.idCategoria.Name = "idCategoria";
            // 
            // categoria
            // 
            this.categoria.HeaderText = "Categoria";
            this.categoria.Name = "categoria";
            // 
            // btEditarCategoria
            // 
            this.btEditarCategoria.Location = new System.Drawing.Point(490, 164);
            this.btEditarCategoria.Name = "btEditarCategoria";
            this.btEditarCategoria.Size = new System.Drawing.Size(106, 26);
            this.btEditarCategoria.TabIndex = 13;
            this.btEditarCategoria.Text = "Editar";
            this.btEditarCategoria.UseVisualStyleBackColor = true;
            this.btEditarCategoria.Click += new System.EventHandler(this.btEditarCategoria_Click);
            // 
            // btNovaCategoria
            // 
            this.btNovaCategoria.Location = new System.Drawing.Point(488, 121);
            this.btNovaCategoria.Name = "btNovaCategoria";
            this.btNovaCategoria.Size = new System.Drawing.Size(106, 26);
            this.btNovaCategoria.TabIndex = 12;
            this.btNovaCategoria.Text = "Novo";
            this.btNovaCategoria.UseVisualStyleBackColor = true;
            this.btNovaCategoria.Click += new System.EventHandler(this.btNovaCategoria_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Gerenciar Categorias";
            // 
            // ucGerCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvCategorias);
            this.Controls.Add(this.btEditarCategoria);
            this.Controls.Add(this.btNovaCategoria);
            this.Controls.Add(this.label1);
            this.Name = "ucGerCategorias";
            this.Size = new System.Drawing.Size(614, 452);
            this.Load += new System.EventHandler(this.ucGerCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.Button btEditarCategoria;
        private System.Windows.Forms.Button btNovaCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
    }
}
