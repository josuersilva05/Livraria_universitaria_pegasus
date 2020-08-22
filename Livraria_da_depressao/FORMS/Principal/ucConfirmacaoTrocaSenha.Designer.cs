namespace Livraria_da_depressao.FORMS.Principal
{
    partial class ucConfirmacaoTrocaSenha
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtVerificaSenha = new System.Windows.Forms.TextBox();
            this.btVerificaSenha = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "Por favor, confirme que é realmente você:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtVerificaSenha
            // 
            this.txtVerificaSenha.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerificaSenha.Location = new System.Drawing.Point(116, 180);
            this.txtVerificaSenha.Name = "txtVerificaSenha";
            this.txtVerificaSenha.PasswordChar = '*';
            this.txtVerificaSenha.Size = new System.Drawing.Size(171, 23);
            this.txtVerificaSenha.TabIndex = 1;
            // 
            // btVerificaSenha
            // 
            this.btVerificaSenha.BackColor = System.Drawing.Color.RoyalBlue;
            this.btVerificaSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVerificaSenha.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVerificaSenha.ForeColor = System.Drawing.Color.White;
            this.btVerificaSenha.Location = new System.Drawing.Point(114, 230);
            this.btVerificaSenha.Name = "btVerificaSenha";
            this.btVerificaSenha.Size = new System.Drawing.Size(178, 32);
            this.btVerificaSenha.TabIndex = 2;
            this.btVerificaSenha.Text = "ENVIAR";
            this.btVerificaSenha.UseVisualStyleBackColor = false;
            this.btVerificaSenha.Click += new System.EventHandler(this.btVerificaSenha_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(158, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha atual:";
            // 
            // ucConfirmacaoTrocaSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btVerificaSenha);
            this.Controls.Add(this.txtVerificaSenha);
            this.Controls.Add(this.label1);
            this.Name = "ucConfirmacaoTrocaSenha";
            this.Size = new System.Drawing.Size(412, 347);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVerificaSenha;
        private System.Windows.Forms.Button btVerificaSenha;
        private System.Windows.Forms.Label label2;
    }
}
