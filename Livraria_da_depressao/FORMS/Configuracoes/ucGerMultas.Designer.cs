namespace Livraria_da_depressao.FORMS.Configuracoes
{
    partial class ucGerMultas
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
            this.dgvMultas = new System.Windows.Forms.DataGridView();
            this.idMulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoMulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btExcluirMulta = new System.Windows.Forms.Button();
            this.btEditarMulta = new System.Windows.Forms.Button();
            this.btNovaMulta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMultas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMultas
            // 
            this.dgvMultas.AllowUserToOrderColumns = true;
            this.dgvMultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMultas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMulta,
            this.tipoMulta,
            this.valor});
            this.dgvMultas.Location = new System.Drawing.Point(18, 113);
            this.dgvMultas.Name = "dgvMultas";
            this.dgvMultas.RowHeadersWidth = 5;
            this.dgvMultas.Size = new System.Drawing.Size(440, 286);
            this.dgvMultas.TabIndex = 15;
            // 
            // idMulta
            // 
            this.idMulta.HeaderText = "ID";
            this.idMulta.Name = "idMulta";
            // 
            // tipoMulta
            // 
            this.tipoMulta.HeaderText = "Tipo de Multa";
            this.tipoMulta.Name = "tipoMulta";
            // 
            // valor
            // 
            this.valor.HeaderText = "Valor da Multa";
            this.valor.Name = "valor";
            // 
            // btExcluirMulta
            // 
            this.btExcluirMulta.Location = new System.Drawing.Point(489, 205);
            this.btExcluirMulta.Name = "btExcluirMulta";
            this.btExcluirMulta.Size = new System.Drawing.Size(106, 26);
            this.btExcluirMulta.TabIndex = 14;
            this.btExcluirMulta.Text = "Excluir";
            this.btExcluirMulta.UseVisualStyleBackColor = true;
            this.btExcluirMulta.Click += new System.EventHandler(this.btExcluirMulta_Click);
            // 
            // btEditarMulta
            // 
            this.btEditarMulta.Location = new System.Drawing.Point(490, 164);
            this.btEditarMulta.Name = "btEditarMulta";
            this.btEditarMulta.Size = new System.Drawing.Size(106, 26);
            this.btEditarMulta.TabIndex = 13;
            this.btEditarMulta.Text = "Editar";
            this.btEditarMulta.UseVisualStyleBackColor = true;
            this.btEditarMulta.Click += new System.EventHandler(this.btEditarMulta_Click);
            // 
            // btNovaMulta
            // 
            this.btNovaMulta.Location = new System.Drawing.Point(488, 121);
            this.btNovaMulta.Name = "btNovaMulta";
            this.btNovaMulta.Size = new System.Drawing.Size(106, 26);
            this.btNovaMulta.TabIndex = 12;
            this.btNovaMulta.Text = "Novo";
            this.btNovaMulta.UseVisualStyleBackColor = true;
            this.btNovaMulta.Click += new System.EventHandler(this.btNovaMulta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Gerenciar Multas";
            // 
            // ucGerMultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvMultas);
            this.Controls.Add(this.btExcluirMulta);
            this.Controls.Add(this.btEditarMulta);
            this.Controls.Add(this.btNovaMulta);
            this.Controls.Add(this.label1);
            this.Name = "ucGerMultas";
            this.Size = new System.Drawing.Size(614, 452);
            this.Load += new System.EventHandler(this.ucGerMultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMultas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMultas;
        private System.Windows.Forms.Button btExcluirMulta;
        private System.Windows.Forms.Button btEditarMulta;
        private System.Windows.Forms.Button btNovaMulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoMulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
    }
}
