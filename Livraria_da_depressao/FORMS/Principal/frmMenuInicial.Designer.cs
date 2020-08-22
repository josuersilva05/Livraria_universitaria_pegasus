namespace Livraria_da_depressao.FORMS
{
    partial class frmMenuInicial
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btClientes = new System.Windows.Forms.Button();
            this.btHome = new System.Windows.Forms.Button();
            this.btLogout = new System.Windows.Forms.Button();
            this.btPerfil = new System.Windows.Forms.Button();
            this.btConfiguracoes = new System.Windows.Forms.Button();
            this.btReservas = new System.Windows.Forms.Button();
            this.btMultas = new System.Windows.Forms.Button();
            this.btEmprestimos = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBoaVInda = new System.Windows.Forms.Label();
            this.ucHome1 = new Livraria_da_depressao.FORMS.ucHome();
            this.ucPerfil1 = new Livraria_da_depressao.FORMS.ucPerfil();
            this.ucClientes1 = new Livraria_da_depressao.FORMS.Principal.ucClientes();
            this.ucReservas1 = new Livraria_da_depressao.FORMS.ucReservas();
            this.ucEmprestimos1 = new Livraria_da_depressao.FORMS.UCs.ucEmprestimos();
            this.ucMultas1 = new Livraria_da_depressao.FORMS.ucMultas();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btClientes);
            this.panel1.Controls.Add(this.btHome);
            this.panel1.Controls.Add(this.btLogout);
            this.panel1.Controls.Add(this.btPerfil);
            this.panel1.Controls.Add(this.btConfiguracoes);
            this.panel1.Controls.Add(this.btReservas);
            this.panel1.Controls.Add(this.btMultas);
            this.panel1.Controls.Add(this.btEmprestimos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 602);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Livraria_da_depressao.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(41, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btClientes
            // 
            this.btClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btClientes.FlatAppearance.BorderSize = 0;
            this.btClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClientes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClientes.ForeColor = System.Drawing.Color.White;
            this.btClientes.Image = global::Livraria_da_depressao.Properties.Resources.clientes;
            this.btClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClientes.Location = new System.Drawing.Point(7, 351);
            this.btClientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btClientes.Name = "btClientes";
            this.btClientes.Size = new System.Drawing.Size(192, 42);
            this.btClientes.TabIndex = 4;
            this.btClientes.Text = "Clientes";
            this.btClientes.UseVisualStyleBackColor = false;
            this.btClientes.Click += new System.EventHandler(this.btClientes_Click);
            // 
            // btHome
            // 
            this.btHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btHome.FlatAppearance.BorderSize = 0;
            this.btHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHome.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHome.ForeColor = System.Drawing.Color.White;
            this.btHome.Image = global::Livraria_da_depressao.Properties.Resources.home;
            this.btHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHome.Location = new System.Drawing.Point(7, 151);
            this.btHome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btHome.Name = "btHome";
            this.btHome.Size = new System.Drawing.Size(192, 42);
            this.btHome.TabIndex = 0;
            this.btHome.Text = "Home";
            this.btHome.UseVisualStyleBackColor = false;
            this.btHome.Click += new System.EventHandler(this.btHome_Click);
            // 
            // btLogout
            // 
            this.btLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLogout.FlatAppearance.BorderSize = 0;
            this.btLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogout.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogout.ForeColor = System.Drawing.Color.White;
            this.btLogout.Image = global::Livraria_da_depressao.Properties.Resources.power_icon_electric_power_sign_isolated_on_white_vector_216413581;
            this.btLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLogout.Location = new System.Drawing.Point(29, 537);
            this.btLogout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(141, 31);
            this.btLogout.TabIndex = 7;
            this.btLogout.Text = "Logout";
            this.btLogout.UseVisualStyleBackColor = false;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // btPerfil
            // 
            this.btPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPerfil.FlatAppearance.BorderSize = 0;
            this.btPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPerfil.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPerfil.ForeColor = System.Drawing.Color.White;
            this.btPerfil.Image = global::Livraria_da_depressao.Properties.Resources.perfil;
            this.btPerfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPerfil.Location = new System.Drawing.Point(6, 401);
            this.btPerfil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btPerfil.Name = "btPerfil";
            this.btPerfil.Size = new System.Drawing.Size(192, 42);
            this.btPerfil.TabIndex = 5;
            this.btPerfil.Text = "Perfil";
            this.btPerfil.UseVisualStyleBackColor = false;
            this.btPerfil.Click += new System.EventHandler(this.btPerfil_Click);
            // 
            // btConfiguracoes
            // 
            this.btConfiguracoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btConfiguracoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btConfiguracoes.FlatAppearance.BorderSize = 0;
            this.btConfiguracoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConfiguracoes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfiguracoes.ForeColor = System.Drawing.Color.White;
            this.btConfiguracoes.Image = global::Livraria_da_depressao.Properties.Resources.engrenagem;
            this.btConfiguracoes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btConfiguracoes.Location = new System.Drawing.Point(7, 451);
            this.btConfiguracoes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btConfiguracoes.Name = "btConfiguracoes";
            this.btConfiguracoes.Size = new System.Drawing.Size(192, 42);
            this.btConfiguracoes.TabIndex = 6;
            this.btConfiguracoes.Text = "Configurações";
            this.btConfiguracoes.UseVisualStyleBackColor = false;
            this.btConfiguracoes.Click += new System.EventHandler(this.btConfiguracoes_Click);
            // 
            // btReservas
            // 
            this.btReservas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btReservas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btReservas.FlatAppearance.BorderSize = 0;
            this.btReservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btReservas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReservas.ForeColor = System.Drawing.Color.White;
            this.btReservas.Image = global::Livraria_da_depressao.Properties.Resources.reserva;
            this.btReservas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btReservas.Location = new System.Drawing.Point(7, 251);
            this.btReservas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btReservas.Name = "btReservas";
            this.btReservas.Size = new System.Drawing.Size(192, 42);
            this.btReservas.TabIndex = 2;
            this.btReservas.Text = "Reservas";
            this.btReservas.UseVisualStyleBackColor = false;
            this.btReservas.Click += new System.EventHandler(this.btReservas_Click);
            // 
            // btMultas
            // 
            this.btMultas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btMultas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btMultas.FlatAppearance.BorderSize = 0;
            this.btMultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMultas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMultas.ForeColor = System.Drawing.Color.White;
            this.btMultas.Image = global::Livraria_da_depressao.Properties.Resources.multa;
            this.btMultas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btMultas.Location = new System.Drawing.Point(7, 301);
            this.btMultas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btMultas.Name = "btMultas";
            this.btMultas.Size = new System.Drawing.Size(192, 42);
            this.btMultas.TabIndex = 3;
            this.btMultas.Text = "Multas";
            this.btMultas.UseVisualStyleBackColor = false;
            this.btMultas.Click += new System.EventHandler(this.btMultas_Click);
            // 
            // btEmprestimos
            // 
            this.btEmprestimos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btEmprestimos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEmprestimos.FlatAppearance.BorderSize = 0;
            this.btEmprestimos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEmprestimos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEmprestimos.ForeColor = System.Drawing.Color.White;
            this.btEmprestimos.Image = global::Livraria_da_depressao.Properties.Resources.emprestimo;
            this.btEmprestimos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEmprestimos.Location = new System.Drawing.Point(7, 201);
            this.btEmprestimos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btEmprestimos.Name = "btEmprestimos";
            this.btEmprestimos.Size = new System.Drawing.Size(192, 42);
            this.btEmprestimos.TabIndex = 1;
            this.btEmprestimos.Text = "Empréstimos";
            this.btEmprestimos.UseVisualStyleBackColor = false;
            this.btEmprestimos.Click += new System.EventHandler(this.btEmprestimos_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Aqua;
            this.panel2.BackgroundImage = global::Livraria_da_depressao.Properties.Resources.Untitled_21;
            this.panel2.Controls.Add(this.lblBoaVInda);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(205, 0);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel2.Size = new System.Drawing.Size(771, 57);
            this.panel2.TabIndex = 6;
            // 
            // lblBoaVInda
            // 
            this.lblBoaVInda.AutoSize = true;
            this.lblBoaVInda.BackColor = System.Drawing.Color.Transparent;
            this.lblBoaVInda.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoaVInda.ForeColor = System.Drawing.Color.White;
            this.lblBoaVInda.Location = new System.Drawing.Point(32, 22);
            this.lblBoaVInda.Name = "lblBoaVInda";
            this.lblBoaVInda.Size = new System.Drawing.Size(57, 21);
            this.lblBoaVInda.TabIndex = 0;
            this.lblBoaVInda.Text = "label1";
            // 
            // ucHome1
            // 
            this.ucHome1.BackColor = System.Drawing.Color.White;
            this.ucHome1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucHome1.Location = new System.Drawing.Point(205, 56);
            this.ucHome1.Margin = new System.Windows.Forms.Padding(4);
            this.ucHome1.Name = "ucHome1";
            this.ucHome1.Size = new System.Drawing.Size(772, 545);
            this.ucHome1.TabIndex = 8;
            // 
            // ucPerfil1
            // 
            this.ucPerfil1.BackColor = System.Drawing.Color.White;
            this.ucPerfil1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucPerfil1.Location = new System.Drawing.Point(205, 57);
            this.ucPerfil1.Margin = new System.Windows.Forms.Padding(4);
            this.ucPerfil1.Name = "ucPerfil1";
            this.ucPerfil1.Size = new System.Drawing.Size(772, 545);
            this.ucPerfil1.TabIndex = 9;
            // 
            // ucClientes1
            // 
            this.ucClientes1.BackColor = System.Drawing.Color.White;
            this.ucClientes1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucClientes1.Location = new System.Drawing.Point(205, 56);
            this.ucClientes1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucClientes1.Name = "ucClientes1";
            this.ucClientes1.Size = new System.Drawing.Size(772, 545);
            this.ucClientes1.TabIndex = 12;
            // 
            // ucReservas1
            // 
            this.ucReservas1.BackColor = System.Drawing.Color.White;
            this.ucReservas1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucReservas1.Location = new System.Drawing.Point(205, 56);
            this.ucReservas1.Margin = new System.Windows.Forms.Padding(4);
            this.ucReservas1.Name = "ucReservas1";
            this.ucReservas1.Size = new System.Drawing.Size(772, 545);
            this.ucReservas1.TabIndex = 13;
            // 
            // ucEmprestimos1
            // 
            this.ucEmprestimos1.BackColor = System.Drawing.Color.White;
            this.ucEmprestimos1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucEmprestimos1.Location = new System.Drawing.Point(205, 56);
            this.ucEmprestimos1.Margin = new System.Windows.Forms.Padding(4);
            this.ucEmprestimos1.Name = "ucEmprestimos1";
            this.ucEmprestimos1.Size = new System.Drawing.Size(772, 545);
            this.ucEmprestimos1.TabIndex = 14;
            // 
            // ucMultas1
            // 
            this.ucMultas1.BackColor = System.Drawing.Color.White;
            this.ucMultas1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucMultas1.Location = new System.Drawing.Point(205, 55);
            this.ucMultas1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucMultas1.Name = "ucMultas1";
            this.ucMultas1.Size = new System.Drawing.Size(772, 545);
            this.ucMultas1.TabIndex = 15;
            // 
            // frmMenuInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(976, 602);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucHome1);
            this.Controls.Add(this.ucPerfil1);
            this.Controls.Add(this.ucClientes1);
            this.Controls.Add(this.ucMultas1);
            this.Controls.Add(this.ucEmprestimos1);
            this.Controls.Add(this.ucReservas1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMenuInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Inicial";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenuInicial_FormClosing);
            this.Load += new System.EventHandler(this.frmMenuInicial_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btPerfil;
        private System.Windows.Forms.Button btConfiguracoes;
        private System.Windows.Forms.Button btReservas;
        private System.Windows.Forms.Button btMultas;
        private System.Windows.Forms.Button btEmprestimos;
        private System.Windows.Forms.Button btHome;
        private System.Windows.Forms.Button btClientes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblBoaVInda;
        private ucHome ucHome1;
        private ucPerfil ucPerfil1;
        private Principal.ucClientes ucClientes1;
        private ucReservas ucReservas1;
        private UCs.ucEmprestimos ucEmprestimos1;
        private ucMultas ucMultas1;
    }
}