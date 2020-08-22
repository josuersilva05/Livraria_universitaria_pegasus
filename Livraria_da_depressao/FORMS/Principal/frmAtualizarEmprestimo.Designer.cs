namespace Livraria_da_depressao.FORMS.Principal
{
    partial class frmAtualizarEmprestimo
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
            this.txtClienteEmprestimo = new System.Windows.Forms.TextBox();
            this.txtIdEmprestimo = new System.Windows.Forms.TextBox();
            this.ckbMultaPaga = new System.Windows.Forms.CheckBox();
            this.ckbLivroEntregue = new System.Windows.Forms.CheckBox();
            this.cboStatusEmprestimo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btSalvarEmprestimo = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTemMulta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtClienteEmprestimo
            // 
            this.txtClienteEmprestimo.Enabled = false;
            this.txtClienteEmprestimo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClienteEmprestimo.Location = new System.Drawing.Point(259, 125);
            this.txtClienteEmprestimo.Name = "txtClienteEmprestimo";
            this.txtClienteEmprestimo.Size = new System.Drawing.Size(135, 23);
            this.txtClienteEmprestimo.TabIndex = 21;
            // 
            // txtIdEmprestimo
            // 
            this.txtIdEmprestimo.Enabled = false;
            this.txtIdEmprestimo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdEmprestimo.Location = new System.Drawing.Point(259, 88);
            this.txtIdEmprestimo.Name = "txtIdEmprestimo";
            this.txtIdEmprestimo.Size = new System.Drawing.Size(135, 23);
            this.txtIdEmprestimo.TabIndex = 20;
            // 
            // ckbMultaPaga
            // 
            this.ckbMultaPaga.AutoSize = true;
            this.ckbMultaPaga.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbMultaPaga.Location = new System.Drawing.Point(257, 269);
            this.ckbMultaPaga.Name = "ckbMultaPaga";
            this.ckbMultaPaga.Size = new System.Drawing.Size(31, 21);
            this.ckbMultaPaga.TabIndex = 19;
            this.ckbMultaPaga.Text = " ";
            this.ckbMultaPaga.UseVisualStyleBackColor = true;
            // 
            // ckbLivroEntregue
            // 
            this.ckbLivroEntregue.AutoSize = true;
            this.ckbLivroEntregue.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbLivroEntregue.Location = new System.Drawing.Point(257, 207);
            this.ckbLivroEntregue.Name = "ckbLivroEntregue";
            this.ckbLivroEntregue.Size = new System.Drawing.Size(31, 21);
            this.ckbLivroEntregue.TabIndex = 18;
            this.ckbLivroEntregue.Text = " ";
            this.ckbLivroEntregue.UseVisualStyleBackColor = true;
            // 
            // cboStatusEmprestimo
            // 
            this.cboStatusEmprestimo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatusEmprestimo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatusEmprestimo.FormattingEnabled = true;
            this.cboStatusEmprestimo.Items.AddRange(new object[] {
            "Pontual",
            "Atraso",
            "Danificado",
            "Perca"});
            this.cboStatusEmprestimo.Location = new System.Drawing.Point(257, 163);
            this.cboStatusEmprestimo.Name = "cboStatusEmprestimo";
            this.cboStatusEmprestimo.Size = new System.Drawing.Size(135, 25);
            this.cboStatusEmprestimo.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(79, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Pagou multa(s):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(81, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(79, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Entregue:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Status:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Atualizar empréstimo:";
            // 
            // btSalvarEmprestimo
            // 
            this.btSalvarEmprestimo.BackColor = System.Drawing.Color.RoyalBlue;
            this.btSalvarEmprestimo.FlatAppearance.BorderSize = 0;
            this.btSalvarEmprestimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalvarEmprestimo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvarEmprestimo.ForeColor = System.Drawing.Color.White;
            this.btSalvarEmprestimo.Location = new System.Drawing.Point(257, 339);
            this.btSalvarEmprestimo.Name = "btSalvarEmprestimo";
            this.btSalvarEmprestimo.Size = new System.Drawing.Size(99, 28);
            this.btSalvarEmprestimo.TabIndex = 22;
            this.btSalvarEmprestimo.Text = "SALVAR";
            this.btSalvarEmprestimo.UseVisualStyleBackColor = false;
            this.btSalvarEmprestimo.Click += new System.EventHandler(this.btSalvarEmprestimo_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btCancelar.FlatAppearance.BorderSize = 0;
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(128, 339);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(99, 28);
            this.btCancelar.TabIndex = 23;
            this.btCancelar.Text = "CANCELAR";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(80, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Multa(s):";
            // 
            // lblTemMulta
            // 
            this.lblTemMulta.AutoSize = true;
            this.lblTemMulta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemMulta.Location = new System.Drawing.Point(254, 238);
            this.lblTemMulta.Name = "lblTemMulta";
            this.lblTemMulta.Size = new System.Drawing.Size(0, 17);
            this.lblTemMulta.TabIndex = 25;
            // 
            // frmAtualizarEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(483, 400);
            this.Controls.Add(this.lblTemMulta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btSalvarEmprestimo);
            this.Controls.Add(this.txtClienteEmprestimo);
            this.Controls.Add(this.txtIdEmprestimo);
            this.Controls.Add(this.ckbMultaPaga);
            this.Controls.Add(this.ckbLivroEntregue);
            this.Controls.Add(this.cboStatusEmprestimo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAtualizarEmprestimo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualizar Empréstimo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAtualizarEmprestimo_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtClienteEmprestimo;
        private System.Windows.Forms.TextBox txtIdEmprestimo;
        private System.Windows.Forms.CheckBox ckbMultaPaga;
        private System.Windows.Forms.CheckBox ckbLivroEntregue;
        private System.Windows.Forms.ComboBox cboStatusEmprestimo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSalvarEmprestimo;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTemMulta;
    }
}