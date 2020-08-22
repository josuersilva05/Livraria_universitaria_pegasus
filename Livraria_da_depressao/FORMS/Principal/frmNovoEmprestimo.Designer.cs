namespace Livraria_da_depressao.FORMS.Principal
{
    partial class frmNovoEmprestimo
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
            this.dtpEntregaPrevista = new System.Windows.Forms.DateTimePicker();
            this.btConfirmarEmprestimo = new System.Windows.Forms.Button();
            this.dtpHorarioDevolucao = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboLivroEmprestimo = new System.Windows.Forms.ComboBox();
            this.cboClienteEmprestimo = new System.Windows.Forms.ComboBox();
            this.btCancelarEmprestimo = new System.Windows.Forms.Button();
            this.txtValorEmprestimo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblErroBuscaLivro = new System.Windows.Forms.Label();
            this.lblErroBuscaCliente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpEntregaPrevista
            // 
            this.dtpEntregaPrevista.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEntregaPrevista.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEntregaPrevista.Location = new System.Drawing.Point(222, 225);
            this.dtpEntregaPrevista.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpEntregaPrevista.Name = "dtpEntregaPrevista";
            this.dtpEntregaPrevista.Size = new System.Drawing.Size(186, 23);
            this.dtpEntregaPrevista.TabIndex = 1;
            this.dtpEntregaPrevista.ValueChanged += new System.EventHandler(this.dtpEntregaPrevista_ValueChanged);
            // 
            // btConfirmarEmprestimo
            // 
            this.btConfirmarEmprestimo.BackColor = System.Drawing.Color.RoyalBlue;
            this.btConfirmarEmprestimo.FlatAppearance.BorderSize = 0;
            this.btConfirmarEmprestimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConfirmarEmprestimo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfirmarEmprestimo.ForeColor = System.Drawing.Color.White;
            this.btConfirmarEmprestimo.Location = new System.Drawing.Point(251, 422);
            this.btConfirmarEmprestimo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btConfirmarEmprestimo.Name = "btConfirmarEmprestimo";
            this.btConfirmarEmprestimo.Size = new System.Drawing.Size(128, 36);
            this.btConfirmarEmprestimo.TabIndex = 3;
            this.btConfirmarEmprestimo.Text = "CONFIRMAR";
            this.btConfirmarEmprestimo.UseVisualStyleBackColor = false;
            this.btConfirmarEmprestimo.Click += new System.EventHandler(this.btConfirmarEmprestimo_Click);
            // 
            // dtpHorarioDevolucao
            // 
            this.dtpHorarioDevolucao.CustomFormat = "HH:mm:ss";
            this.dtpHorarioDevolucao.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHorarioDevolucao.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHorarioDevolucao.Location = new System.Drawing.Point(222, 278);
            this.dtpHorarioDevolucao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpHorarioDevolucao.Name = "dtpHorarioDevolucao";
            this.dtpHorarioDevolucao.ShowUpDown = true;
            this.dtpHorarioDevolucao.Size = new System.Drawing.Size(186, 23);
            this.dtpHorarioDevolucao.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Exemplar livro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Entrega prevista:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Horário:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cliente:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(110, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(224, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "Cadastrar novo empréstimo";
            // 
            // cboLivroEmprestimo
            // 
            this.cboLivroEmprestimo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLivroEmprestimo.FormattingEnabled = true;
            this.cboLivroEmprestimo.Location = new System.Drawing.Point(222, 124);
            this.cboLivroEmprestimo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboLivroEmprestimo.Name = "cboLivroEmprestimo";
            this.cboLivroEmprestimo.Size = new System.Drawing.Size(186, 25);
            this.cboLivroEmprestimo.TabIndex = 14;
            this.cboLivroEmprestimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboLivroEmprestimo_KeyPress);
            // 
            // cboClienteEmprestimo
            // 
            this.cboClienteEmprestimo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboClienteEmprestimo.FormattingEnabled = true;
            this.cboClienteEmprestimo.Location = new System.Drawing.Point(222, 174);
            this.cboClienteEmprestimo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboClienteEmprestimo.Name = "cboClienteEmprestimo";
            this.cboClienteEmprestimo.Size = new System.Drawing.Size(186, 25);
            this.cboClienteEmprestimo.TabIndex = 15;
            this.cboClienteEmprestimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboClienteEmprestimo_KeyPress);
            // 
            // btCancelarEmprestimo
            // 
            this.btCancelarEmprestimo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btCancelarEmprestimo.FlatAppearance.BorderSize = 0;
            this.btCancelarEmprestimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelarEmprestimo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelarEmprestimo.Location = new System.Drawing.Point(85, 422);
            this.btCancelarEmprestimo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btCancelarEmprestimo.Name = "btCancelarEmprestimo";
            this.btCancelarEmprestimo.Size = new System.Drawing.Size(128, 36);
            this.btCancelarEmprestimo.TabIndex = 16;
            this.btCancelarEmprestimo.Text = "CANCELAR";
            this.btCancelarEmprestimo.UseVisualStyleBackColor = false;
            this.btCancelarEmprestimo.Click += new System.EventHandler(this.btCancelarEmprestimo_Click);
            // 
            // txtValorEmprestimo
            // 
            this.txtValorEmprestimo.Enabled = false;
            this.txtValorEmprestimo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorEmprestimo.Location = new System.Drawing.Point(222, 338);
            this.txtValorEmprestimo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtValorEmprestimo.Name = "txtValorEmprestimo";
            this.txtValorEmprestimo.Size = new System.Drawing.Size(186, 23);
            this.txtValorEmprestimo.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Valor:";
            // 
            // lblErroBuscaLivro
            // 
            this.lblErroBuscaLivro.AutoSize = true;
            this.lblErroBuscaLivro.ForeColor = System.Drawing.Color.Red;
            this.lblErroBuscaLivro.Location = new System.Drawing.Point(65, 147);
            this.lblErroBuscaLivro.Name = "lblErroBuscaLivro";
            this.lblErroBuscaLivro.Size = new System.Drawing.Size(0, 16);
            this.lblErroBuscaLivro.TabIndex = 19;
            // 
            // lblErroBuscaCliente
            // 
            this.lblErroBuscaCliente.AutoSize = true;
            this.lblErroBuscaCliente.ForeColor = System.Drawing.Color.Red;
            this.lblErroBuscaCliente.Location = new System.Drawing.Point(64, 199);
            this.lblErroBuscaCliente.Name = "lblErroBuscaCliente";
            this.lblErroBuscaCliente.Size = new System.Drawing.Size(0, 16);
            this.lblErroBuscaCliente.TabIndex = 20;
            // 
            // frmNovoEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(460, 511);
            this.Controls.Add(this.lblErroBuscaCliente);
            this.Controls.Add(this.lblErroBuscaLivro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtValorEmprestimo);
            this.Controls.Add(this.btCancelarEmprestimo);
            this.Controls.Add(this.cboClienteEmprestimo);
            this.Controls.Add(this.cboLivroEmprestimo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpHorarioDevolucao);
            this.Controls.Add(this.btConfirmarEmprestimo);
            this.Controls.Add(this.dtpEntregaPrevista);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmNovoEmprestimo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emprestimo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNovoEmprestimo_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpEntregaPrevista;
        private System.Windows.Forms.Button btConfirmarEmprestimo;
        private System.Windows.Forms.DateTimePicker dtpHorarioDevolucao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboLivroEmprestimo;
        private System.Windows.Forms.ComboBox cboClienteEmprestimo;
        private System.Windows.Forms.Button btCancelarEmprestimo;
        private System.Windows.Forms.TextBox txtValorEmprestimo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblErroBuscaLivro;
        private System.Windows.Forms.Label lblErroBuscaCliente;
    }
}