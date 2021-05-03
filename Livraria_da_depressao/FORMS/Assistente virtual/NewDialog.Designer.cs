
namespace Livraria_da_depressao.FORMS.Assistente_virtual
{
    partial class NewDialog
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
            this.rtbDialogo = new System.Windows.Forms.RichTextBox();
            this.btFalar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbDialogo
            // 
            this.rtbDialogo.Location = new System.Drawing.Point(-1, 1);
            this.rtbDialogo.Name = "rtbDialogo";
            this.rtbDialogo.Size = new System.Drawing.Size(801, 332);
            this.rtbDialogo.TabIndex = 1;
            this.rtbDialogo.Text = "";
            // 
            // btFalar
            // 
            this.btFalar.Location = new System.Drawing.Point(31, 357);
            this.btFalar.Name = "btFalar";
            this.btFalar.Size = new System.Drawing.Size(110, 38);
            this.btFalar.TabIndex = 2;
            this.btFalar.Text = "Speak";
            this.btFalar.UseVisualStyleBackColor = true;
            // 
            // NewDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btFalar);
            this.Controls.Add(this.rtbDialogo);
            this.Name = "NewDialog";
            this.Text = "NewDialog";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbDialogo;
        private System.Windows.Forms.Button btFalar;
    }
}