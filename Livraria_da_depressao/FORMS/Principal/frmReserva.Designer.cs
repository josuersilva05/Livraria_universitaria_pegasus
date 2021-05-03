namespace Livraria_da_depressao.FORMS.Principal
{
    partial class frmReserva
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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btConfirmarReserva = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboLivroReserva = new System.Windows.Forms.ComboBox();
            this.cboClienteReserva = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboStatusReserva = new System.Windows.Forms.ComboBox();
            this.dtpRetiradaPrevista = new System.Windows.Forms.DateTimePicker();
            this.dtpRetirada = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panRetiradaPrevista = new System.Windows.Forms.Panel();
            this.dtpHoraRetiradaPrevista = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.panRetirada = new System.Windows.Forms.Panel();
            this.lblErroBuscaLivro = new System.Windows.Forms.Label();
            this.lblErroBuscaCliente = new System.Windows.Forms.Label();
            this.txtCodigoEmprestimo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btRealizarEmprestimo = new System.Windows.Forms.Button();
            this.ucSelecionarEmprestimoReserva1 = new Livraria_da_depressao.FORMS.Principal.ucSelecionarEmprestimoReserva();
            this.panRetiradaPrevista.SuspendLayout();
            this.panRetirada.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(51, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 43;
            this.label8.Text = "Livro:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(231, 19);
            this.label7.TabIndex = 41;
            this.label7.Text = "Informe os dados da reserva:";
            // 
            // btConfirmarReserva
            // 
            this.btConfirmarReserva.BackColor = System.Drawing.Color.RoyalBlue;
            this.btConfirmarReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConfirmarReserva.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfirmarReserva.ForeColor = System.Drawing.Color.White;
            this.btConfirmarReserva.Location = new System.Drawing.Point(345, 401);
            this.btConfirmarReserva.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btConfirmarReserva.Name = "btConfirmarReserva";
            this.btConfirmarReserva.Size = new System.Drawing.Size(116, 33);
            this.btConfirmarReserva.TabIndex = 40;
            this.btConfirmarReserva.Text = "CONFIRMAR";
            this.btConfirmarReserva.UseVisualStyleBackColor = false;
            this.btConfirmarReserva.Click += new System.EventHandler(this.btConfirmarReserva_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Cliente:";
            // 
            // cboLivroReserva
            // 
            this.cboLivroReserva.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLivroReserva.FormattingEnabled = true;
            this.cboLivroReserva.Location = new System.Drawing.Point(214, 204);
            this.cboLivroReserva.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboLivroReserva.Name = "cboLivroReserva";
            this.cboLivroReserva.Size = new System.Drawing.Size(247, 25);
            this.cboLivroReserva.TabIndex = 34;
            this.cboLivroReserva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboLivroReserva_KeyPress);
            // 
            // cboClienteReserva
            // 
            this.cboClienteReserva.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboClienteReserva.FormattingEnabled = true;
            this.cboClienteReserva.Location = new System.Drawing.Point(214, 155);
            this.cboClienteReserva.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboClienteReserva.Name = "cboClienteReserva";
            this.cboClienteReserva.Size = new System.Drawing.Size(247, 25);
            this.cboClienteReserva.TabIndex = 33;
            this.cboClienteReserva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboClienteReserva_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 45;
            this.label5.Text = "Status:";
            // 
            // cboStatusReserva
            // 
            this.cboStatusReserva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatusReserva.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatusReserva.FormattingEnabled = true;
            this.cboStatusReserva.Items.AddRange(new object[] {
            "Espera",
            "Adiado",
            "Cancelado",
            "Concluida"});
            this.cboStatusReserva.Location = new System.Drawing.Point(215, 249);
            this.cboStatusReserva.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboStatusReserva.Name = "cboStatusReserva";
            this.cboStatusReserva.Size = new System.Drawing.Size(247, 25);
            this.cboStatusReserva.TabIndex = 46;
            this.cboStatusReserva.SelectedIndexChanged += new System.EventHandler(this.cboStatusReserva_SelectedIndexChanged);
            // 
            // dtpRetiradaPrevista
            // 
            this.dtpRetiradaPrevista.CustomFormat = "";
            this.dtpRetiradaPrevista.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRetiradaPrevista.Location = new System.Drawing.Point(170, 10);
            this.dtpRetiradaPrevista.Name = "dtpRetiradaPrevista";
            this.dtpRetiradaPrevista.Size = new System.Drawing.Size(248, 20);
            this.dtpRetiradaPrevista.TabIndex = 47;
            // 
            // dtpRetirada
            // 
            this.dtpRetirada.CustomFormat = "dd-MM-yyyy";
            this.dtpRetirada.Location = new System.Drawing.Point(170, 13);
            this.dtpRetirada.Name = "dtpRetirada";
            this.dtpRetirada.Size = new System.Drawing.Size(248, 20);
            this.dtpRetirada.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "Retirada prevista:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 50;
            this.label3.Text = "Retirada:";
            // 
            // panRetiradaPrevista
            // 
            this.panRetiradaPrevista.Controls.Add(this.dtpHoraRetiradaPrevista);
            this.panRetiradaPrevista.Controls.Add(this.label4);
            this.panRetiradaPrevista.Controls.Add(this.dtpRetiradaPrevista);
            this.panRetiradaPrevista.Controls.Add(this.label2);
            this.panRetiradaPrevista.Controls.Add(this.panRetirada);
            this.panRetiradaPrevista.Location = new System.Drawing.Point(44, 288);
            this.panRetiradaPrevista.Name = "panRetiradaPrevista";
            this.panRetiradaPrevista.Size = new System.Drawing.Size(427, 100);
            this.panRetiradaPrevista.TabIndex = 51;
            // 
            // dtpHoraRetiradaPrevista
            // 
            this.dtpHoraRetiradaPrevista.CustomFormat = "HH:mm:ss";
            this.dtpHoraRetiradaPrevista.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraRetiradaPrevista.Location = new System.Drawing.Point(170, 44);
            this.dtpHoraRetiradaPrevista.Name = "dtpHoraRetiradaPrevista";
            this.dtpHoraRetiradaPrevista.ShowUpDown = true;
            this.dtpHoraRetiradaPrevista.Size = new System.Drawing.Size(248, 20);
            this.dtpHoraRetiradaPrevista.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 50;
            this.label4.Text = "Hora:";
            // 
            // panRetirada
            // 
            this.panRetirada.Controls.Add(this.dtpRetirada);
            this.panRetirada.Controls.Add(this.label3);
            this.panRetirada.Location = new System.Drawing.Point(0, 0);
            this.panRetirada.Name = "panRetirada";
            this.panRetirada.Size = new System.Drawing.Size(427, 100);
            this.panRetirada.TabIndex = 52;
            // 
            // lblErroBuscaLivro
            // 
            this.lblErroBuscaLivro.AutoSize = true;
            this.lblErroBuscaLivro.ForeColor = System.Drawing.Color.Red;
            this.lblErroBuscaLivro.Location = new System.Drawing.Point(60, 233);
            this.lblErroBuscaLivro.Name = "lblErroBuscaLivro";
            this.lblErroBuscaLivro.Size = new System.Drawing.Size(0, 13);
            this.lblErroBuscaLivro.TabIndex = 52;
            // 
            // lblErroBuscaCliente
            // 
            this.lblErroBuscaCliente.AutoSize = true;
            this.lblErroBuscaCliente.ForeColor = System.Drawing.Color.Red;
            this.lblErroBuscaCliente.Location = new System.Drawing.Point(61, 182);
            this.lblErroBuscaCliente.Name = "lblErroBuscaCliente";
            this.lblErroBuscaCliente.Size = new System.Drawing.Size(0, 13);
            this.lblErroBuscaCliente.TabIndex = 53;
            // 
            // txtCodigoEmprestimo
            // 
            this.txtCodigoEmprestimo.Enabled = false;
            this.txtCodigoEmprestimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoEmprestimo.Location = new System.Drawing.Point(213, 106);
            this.txtCodigoEmprestimo.Name = "txtCodigoEmprestimo";
            this.txtCodigoEmprestimo.Size = new System.Drawing.Size(248, 24);
            this.txtCodigoEmprestimo.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(52, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 20);
            this.label6.TabIndex = 56;
            this.label6.Text = "ID do Empréstimo:";
            // 
            // btRealizarEmprestimo
            // 
            this.btRealizarEmprestimo.BackColor = System.Drawing.Color.RoyalBlue;
            this.btRealizarEmprestimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRealizarEmprestimo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRealizarEmprestimo.ForeColor = System.Drawing.Color.White;
            this.btRealizarEmprestimo.Location = new System.Drawing.Point(151, 401);
            this.btRealizarEmprestimo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btRealizarEmprestimo.Name = "btRealizarEmprestimo";
            this.btRealizarEmprestimo.Size = new System.Drawing.Size(181, 33);
            this.btRealizarEmprestimo.TabIndex = 57;
            this.btRealizarEmprestimo.Text = "REALIZAR EMPRÉSTIMO";
            this.btRealizarEmprestimo.UseVisualStyleBackColor = false;
            this.btRealizarEmprestimo.Visible = false;
            this.btRealizarEmprestimo.Click += new System.EventHandler(this.btRealizarEmprestimo_Click);
            // 
            // ucSelecionarEmprestimoReserva1
            // 
            this.ucSelecionarEmprestimoReserva1.BackColor = System.Drawing.Color.White;
            this.ucSelecionarEmprestimoReserva1.Location = new System.Drawing.Point(8, 31);
            this.ucSelecionarEmprestimoReserva1.Name = "ucSelecionarEmprestimoReserva1";
            this.ucSelecionarEmprestimoReserva1.Size = new System.Drawing.Size(488, 415);
            this.ucSelecionarEmprestimoReserva1.TabIndex = 54;
            // 
            // frmReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(505, 461);
            this.Controls.Add(this.ucSelecionarEmprestimoReserva1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCodigoEmprestimo);
            this.Controls.Add(this.lblErroBuscaCliente);
            this.Controls.Add(this.lblErroBuscaLivro);
            this.Controls.Add(this.panRetiradaPrevista);
            this.Controls.Add(this.cboStatusReserva);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btConfirmarReserva);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboLivroReserva);
            this.Controls.Add(this.cboClienteReserva);
            this.Controls.Add(this.btRealizarEmprestimo);
            this.Name = "frmReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reserva";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmReserva_FormClosing);
            this.panRetiradaPrevista.ResumeLayout(false);
            this.panRetiradaPrevista.PerformLayout();
            this.panRetirada.ResumeLayout(false);
            this.panRetirada.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btConfirmarReserva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboLivroReserva;
        private System.Windows.Forms.ComboBox cboClienteReserva;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboStatusReserva;
        private System.Windows.Forms.DateTimePicker dtpRetiradaPrevista;
        private System.Windows.Forms.DateTimePicker dtpRetirada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panRetiradaPrevista;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panRetirada;
        private System.Windows.Forms.DateTimePicker dtpHoraRetiradaPrevista;
        private System.Windows.Forms.Label lblErroBuscaLivro;
        private System.Windows.Forms.Label lblErroBuscaCliente;
        private ucSelecionarEmprestimoReserva ucSelecionarEmprestimoReserva1;
        private System.Windows.Forms.TextBox txtCodigoEmprestimo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btRealizarEmprestimo;
    }
}