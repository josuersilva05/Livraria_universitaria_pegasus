namespace Livraria_da_depressao.FORMS.Configuracoes
{
    partial class ucGerEditoras
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
            this.dgvEditoras = new System.Windows.Forms.DataGridView();
            this.idEditora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeEditora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btEditarEditora = new System.Windows.Forms.Button();
            this.btNovaEditora = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditoras)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEditoras
            // 
            this.dgvEditoras.AllowUserToOrderColumns = true;
            this.dgvEditoras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditoras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEditora,
            this.nomeEditora});
            this.dgvEditoras.Location = new System.Drawing.Point(18, 113);
            this.dgvEditoras.Name = "dgvEditoras";
            this.dgvEditoras.RowHeadersWidth = 5;
            this.dgvEditoras.Size = new System.Drawing.Size(440, 286);
            this.dgvEditoras.TabIndex = 15;
            // 
            // idEditora
            // 
            this.idEditora.HeaderText = "ID";
            this.idEditora.Name = "idEditora";
            // 
            // nomeEditora
            // 
            this.nomeEditora.HeaderText = "Editora";
            this.nomeEditora.Name = "nomeEditora";
            // 
            // btEditarEditora
            // 
            this.btEditarEditora.Location = new System.Drawing.Point(490, 164);
            this.btEditarEditora.Name = "btEditarEditora";
            this.btEditarEditora.Size = new System.Drawing.Size(106, 26);
            this.btEditarEditora.TabIndex = 13;
            this.btEditarEditora.Text = "Editar";
            this.btEditarEditora.UseVisualStyleBackColor = true;
            this.btEditarEditora.Click += new System.EventHandler(this.btEditarEditora_Click);
            // 
            // btNovaEditora
            // 
            this.btNovaEditora.Location = new System.Drawing.Point(488, 121);
            this.btNovaEditora.Name = "btNovaEditora";
            this.btNovaEditora.Size = new System.Drawing.Size(106, 26);
            this.btNovaEditora.TabIndex = 12;
            this.btNovaEditora.Text = "Novo";
            this.btNovaEditora.UseVisualStyleBackColor = true;
            this.btNovaEditora.Click += new System.EventHandler(this.btNovaEditora_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Gerenciar Editoras";
            // 
            // ucGerEditoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvEditoras);
            this.Controls.Add(this.btEditarEditora);
            this.Controls.Add(this.btNovaEditora);
            this.Controls.Add(this.label1);
            this.Name = "ucGerEditoras";
            this.Size = new System.Drawing.Size(614, 452);
            this.Load += new System.EventHandler(this.ucGerEditoras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditoras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEditoras;
        private System.Windows.Forms.Button btEditarEditora;
        private System.Windows.Forms.Button btNovaEditora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEditora;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeEditora;
    }
}
