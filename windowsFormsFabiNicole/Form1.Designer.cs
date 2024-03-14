
namespace windowsFormsFabiNicole
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOK = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.richTextLogin = new System.Windows.Forms.RichTextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.richTextSenha = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnOK.Location = new System.Drawing.Point(64, 164);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(127, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnClickThis_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(61, 44);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(33, 13);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Login";
            this.lblLogin.Click += new System.EventHandler(this.label1_Click);
            // 
            // richTextLogin
            // 
            this.richTextLogin.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.richTextLogin.Location = new System.Drawing.Point(64, 60);
            this.richTextLogin.Name = "richTextLogin";
            this.richTextLogin.Size = new System.Drawing.Size(127, 22);
            this.richTextLogin.TabIndex = 2;
            this.richTextLogin.Text = "";
            this.richTextLogin.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(61, 102);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "Senha";
            this.lblSenha.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // richTextSenha
            // 
            this.richTextSenha.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.richTextSenha.ForeColor = System.Drawing.SystemColors.WindowText;
            this.richTextSenha.Location = new System.Drawing.Point(64, 118);
            this.richTextSenha.Name = "richTextSenha";
            this.richTextSenha.Size = new System.Drawing.Size(127, 21);
            this.richTextSenha.TabIndex = 4;
            this.richTextSenha.Text = "";
            this.richTextSenha.TextChanged += new System.EventHandler(this.richTextSenha_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(259, 219);
            this.Controls.Add(this.richTextSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.richTextLogin);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.btnOK);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.RichTextBox richTextLogin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.RichTextBox richTextSenha;
    }
}

