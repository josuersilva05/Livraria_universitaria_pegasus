namespace Livraria_da_depressao.FORMS.Principal
{
    partial class frmAlterarSenha
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
            this.txtNovaSenha = new System.Windows.Forms.TextBox();
            this.btAlterarSenha = new System.Windows.Forms.Button();
            this.lblErroSenha = new System.Windows.Forms.Label();
            this.txtConfirmarSenha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucConfirmacaoTrocaSenha1 = new Livraria_da_depressao.FORMS.Principal.ucConfirmacaoTrocaSenha();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nova senha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Confirmar senha:";
            // 
            // txtNovaSenha
            // 
            this.txtNovaSenha.Location = new System.Drawing.Point(75, 124);
            this.txtNovaSenha.Name = "txtNovaSenha";
            this.txtNovaSenha.Size = new System.Drawing.Size(208, 20);
            this.txtNovaSenha.TabIndex = 2;
            // 
            // btAlterarSenha
            // 
            this.btAlterarSenha.BackColor = System.Drawing.Color.RoyalBlue;
            this.btAlterarSenha.FlatAppearance.BorderSize = 0;
            this.btAlterarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAlterarSenha.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlterarSenha.ForeColor = System.Drawing.Color.White;
            this.btAlterarSenha.Location = new System.Drawing.Point(85, 307);
            this.btAlterarSenha.Name = "btAlterarSenha";
            this.btAlterarSenha.Size = new System.Drawing.Size(196, 36);
            this.btAlterarSenha.TabIndex = 3;
            this.btAlterarSenha.Text = "ALTERAR SENHA";
            this.btAlterarSenha.UseVisualStyleBackColor = false;
            this.btAlterarSenha.Click += new System.EventHandler(this.btAlterarSenha_Click);
            // 
            // lblErroSenha
            // 
            this.lblErroSenha.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErroSenha.ForeColor = System.Drawing.Color.Red;
            this.lblErroSenha.Location = new System.Drawing.Point(72, 231);
            this.lblErroSenha.Name = "lblErroSenha";
            this.lblErroSenha.Size = new System.Drawing.Size(281, 32);
            this.lblErroSenha.TabIndex = 4;
            this.lblErroSenha.Text = "Senhas correspondentes";
            this.lblErroSenha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblErroSenha.Visible = false;
            // 
            // txtConfirmarSenha
            // 
            this.txtConfirmarSenha.Location = new System.Drawing.Point(78, 208);
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.Size = new System.Drawing.Size(208, 20);
            this.txtConfirmarSenha.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Por favor informe a nova senha:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucConfirmacaoTrocaSenha1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtConfirmarSenha);
            this.panel1.Controls.Add(this.txtNovaSenha);
            this.panel1.Controls.Add(this.lblErroSenha);
            this.panel1.Controls.Add(this.btAlterarSenha);
            this.panel1.Location = new System.Drawing.Point(109, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 360);
            this.panel1.TabIndex = 8;
            // 
            // ucConfirmacaoTrocaSenha1
            // 
            this.ucConfirmacaoTrocaSenha1.BackColor = System.Drawing.Color.White;
            this.ucConfirmacaoTrocaSenha1.Location = new System.Drawing.Point(-13, -1);
            this.ucConfirmacaoTrocaSenha1.Name = "ucConfirmacaoTrocaSenha1";
            this.ucConfirmacaoTrocaSenha1.Size = new System.Drawing.Size(412, 363);
            this.ucConfirmacaoTrocaSenha1.TabIndex = 7;
            // 
            // frmAlterarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(601, 387);
            this.Controls.Add(this.panel1);
            this.Name = "frmAlterarSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Senha";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAlterarSenha_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNovaSenha;
        private System.Windows.Forms.Button btAlterarSenha;
        private System.Windows.Forms.Label lblErroSenha;
        private System.Windows.Forms.TextBox txtConfirmarSenha;
        private System.Windows.Forms.Label label4;
        private ucConfirmacaoTrocaSenha ucConfirmacaoTrocaSenha1;
        private System.Windows.Forms.Panel panel1;
    }
}