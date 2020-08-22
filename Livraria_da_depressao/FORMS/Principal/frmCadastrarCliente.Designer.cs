namespace Livraria_da_depressao.FORMS.Principal
{
    partial class frmCadastrarCliente
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
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.txtCelularCliente = new System.Windows.Forms.TextBox();
            this.txtEmailCliente = new System.Windows.Forms.TextBox();
            this.cboSexoCliente = new System.Windows.Forms.ComboBox();
            this.cboClienteRegularizado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btConfirmarCadastro = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCpfCliente = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.Location = new System.Drawing.Point(218, 98);
            this.txtNomeCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(242, 23);
            this.txtNomeCliente.TabIndex = 0;
            // 
            // txtCelularCliente
            // 
            this.txtCelularCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelularCliente.Location = new System.Drawing.Point(218, 254);
            this.txtCelularCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCelularCliente.Name = "txtCelularCliente";
            this.txtCelularCliente.Size = new System.Drawing.Size(242, 23);
            this.txtCelularCliente.TabIndex = 1;
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailCliente.Location = new System.Drawing.Point(218, 203);
            this.txtEmailCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.Size = new System.Drawing.Size(242, 23);
            this.txtEmailCliente.TabIndex = 2;
            // 
            // cboSexoCliente
            // 
            this.cboSexoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSexoCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSexoCliente.FormattingEnabled = true;
            this.cboSexoCliente.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Indefinido"});
            this.cboSexoCliente.Location = new System.Drawing.Point(218, 311);
            this.cboSexoCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboSexoCliente.Name = "cboSexoCliente";
            this.cboSexoCliente.Size = new System.Drawing.Size(238, 25);
            this.cboSexoCliente.TabIndex = 18;
            // 
            // cboClienteRegularizado
            // 
            this.cboClienteRegularizado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClienteRegularizado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboClienteRegularizado.FormattingEnabled = true;
            this.cboClienteRegularizado.Items.AddRange(new object[] {
            "Regularizado",
            "Não Regularizado"});
            this.cboClienteRegularizado.Location = new System.Drawing.Point(216, 368);
            this.cboClienteRegularizado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboClienteRegularizado.Name = "cboClienteRegularizado";
            this.cboClienteRegularizado.Size = new System.Drawing.Size(238, 25);
            this.cboClienteRegularizado.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Celular:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Sexo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Regularização:";
            // 
            // btConfirmarCadastro
            // 
            this.btConfirmarCadastro.BackColor = System.Drawing.Color.RoyalBlue;
            this.btConfirmarCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConfirmarCadastro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfirmarCadastro.ForeColor = System.Drawing.Color.White;
            this.btConfirmarCadastro.Location = new System.Drawing.Point(290, 429);
            this.btConfirmarCadastro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btConfirmarCadastro.Name = "btConfirmarCadastro";
            this.btConfirmarCadastro.Size = new System.Drawing.Size(164, 32);
            this.btConfirmarCadastro.TabIndex = 25;
            this.btConfirmarCadastro.Text = "CONFIRMAR";
            this.btConfirmarCadastro.UseVisualStyleBackColor = false;
            this.btConfirmarCadastro.Click += new System.EventHandler(this.btConfirmarCadastro_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(226, 19);
            this.label7.TabIndex = 27;
            this.label7.Text = "Informe os dados do cliente:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(51, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 20);
            this.label8.TabIndex = 29;
            this.label8.Text = "CPF:";
            // 
            // txtCpfCliente
            // 
            this.txtCpfCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpfCliente.Location = new System.Drawing.Point(218, 151);
            this.txtCpfCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCpfCliente.Name = "txtCpfCliente";
            this.txtCpfCliente.Size = new System.Drawing.Size(242, 23);
            this.txtCpfCliente.TabIndex = 28;
            // 
            // frmCadastrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(514, 501);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCpfCliente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btConfirmarCadastro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboClienteRegularizado);
            this.Controls.Add(this.cboSexoCliente);
            this.Controls.Add(this.txtEmailCliente);
            this.Controls.Add(this.txtCelularCliente);
            this.Controls.Add(this.txtNomeCliente);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCadastrarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Cliente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCadastrarCliente_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.TextBox txtCelularCliente;
        private System.Windows.Forms.TextBox txtEmailCliente;
        private System.Windows.Forms.ComboBox cboSexoCliente;
        private System.Windows.Forms.ComboBox cboClienteRegularizado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btConfirmarCadastro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCpfCliente;
    }
}