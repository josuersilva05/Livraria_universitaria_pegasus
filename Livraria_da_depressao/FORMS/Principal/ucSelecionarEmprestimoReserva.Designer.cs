namespace Livraria_da_depressao.FORMS.Principal
{
    partial class ucSelecionarEmprestimoReserva
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
            this.lstEmprestimosDisponiveis = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btAvancar = new System.Windows.Forms.Button();
            this.btVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstEmprestimosDisponiveis
            // 
            this.lstEmprestimosDisponiveis.FormattingEnabled = true;
            this.lstEmprestimosDisponiveis.Location = new System.Drawing.Point(41, 81);
            this.lstEmprestimosDisponiveis.Name = "lstEmprestimosDisponiveis";
            this.lstEmprestimosDisponiveis.Size = new System.Drawing.Size(288, 251);
            this.lstEmprestimosDisponiveis.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 19);
            this.label7.TabIndex = 42;
            this.label7.Text = "Selecione o empréstimo:";
            // 
            // btAvancar
            // 
            this.btAvancar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btAvancar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAvancar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAvancar.ForeColor = System.Drawing.Color.White;
            this.btAvancar.Location = new System.Drawing.Point(364, 85);
            this.btAvancar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btAvancar.Name = "btAvancar";
            this.btAvancar.Size = new System.Drawing.Size(101, 33);
            this.btAvancar.TabIndex = 43;
            this.btAvancar.Text = "AVANÇAR";
            this.btAvancar.UseVisualStyleBackColor = false;
            this.btAvancar.Click += new System.EventHandler(this.btAvancar_Click);
            // 
            // btVoltar
            // 
            this.btVoltar.BackColor = System.Drawing.Color.Gainsboro;
            this.btVoltar.FlatAppearance.BorderSize = 0;
            this.btVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVoltar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVoltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btVoltar.Location = new System.Drawing.Point(364, 134);
            this.btVoltar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(101, 33);
            this.btVoltar.TabIndex = 44;
            this.btVoltar.Text = "VOLTAR";
            this.btVoltar.UseVisualStyleBackColor = false;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // ucSelecionarEmprestimoReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.btAvancar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lstEmprestimosDisponiveis);
            this.Name = "ucSelecionarEmprestimoReserva";
            this.Size = new System.Drawing.Size(488, 415);
            this.Load += new System.EventHandler(this.ucSelecionarEmprestimoReserva_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstEmprestimosDisponiveis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btAvancar;
        private System.Windows.Forms.Button btVoltar;
    }
}
