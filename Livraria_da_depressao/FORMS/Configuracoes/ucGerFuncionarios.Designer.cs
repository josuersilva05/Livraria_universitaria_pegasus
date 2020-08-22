namespace Livraria_da_depressao.FORMS.Configuracoes
{
    partial class ucGerFuncionarios
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
            this.dgvFuncionarios = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btNovoFuncionario = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFuncionarios
            // 
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nomeFuncionario,
            this.cargoFuncionario,
            this.sexoFuncionario});
            this.dgvFuncionarios.Location = new System.Drawing.Point(34, 99);
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.RowHeadersWidth = 5;
            this.dgvFuncionarios.Size = new System.Drawing.Size(410, 276);
            this.dgvFuncionarios.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // nomeFuncionario
            // 
            this.nomeFuncionario.HeaderText = "Nome";
            this.nomeFuncionario.Name = "nomeFuncionario";
            // 
            // cargoFuncionario
            // 
            this.cargoFuncionario.HeaderText = "Cargo";
            this.cargoFuncionario.Name = "cargoFuncionario";
            // 
            // sexoFuncionario
            // 
            this.sexoFuncionario.HeaderText = "Sexo";
            this.sexoFuncionario.Name = "sexoFuncionario";
            // 
            // btNovoFuncionario
            // 
            this.btNovoFuncionario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovoFuncionario.Location = new System.Drawing.Point(469, 104);
            this.btNovoFuncionario.Name = "btNovoFuncionario";
            this.btNovoFuncionario.Size = new System.Drawing.Size(111, 34);
            this.btNovoFuncionario.TabIndex = 1;
            this.btNovoFuncionario.Text = "Novo";
            this.btNovoFuncionario.UseVisualStyleBackColor = true;
            this.btNovoFuncionario.Click += new System.EventHandler(this.btNovoFuncionario_Click);
            // 
            // btEditar
            // 
            this.btEditar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditar.Location = new System.Drawing.Point(469, 161);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(111, 34);
            this.btEditar.TabIndex = 2;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.Location = new System.Drawing.Point(470, 217);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(111, 34);
            this.btExcluir.TabIndex = 3;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gerenciar funcionarios";
            // 
            // ucGerFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btNovoFuncionario);
            this.Controls.Add(this.dgvFuncionarios);
            this.Name = "ucGerFuncionarios";
            this.Size = new System.Drawing.Size(614, 452);
            this.Load += new System.EventHandler(this.ucGerFuncionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFuncionarios;
        private System.Windows.Forms.Button btNovoFuncionario;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoFuncionario;
        private System.Windows.Forms.Label label1;
    }
}
