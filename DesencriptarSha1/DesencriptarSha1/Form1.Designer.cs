namespace DesencriptarSha1
{
    partial class Form1
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
            this.tbLlave = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Sha1 = new System.Windows.Forms.Label();
            this.tbSha1Llave = new System.Windows.Forms.TextBox();
            this.tbEncriptar = new System.Windows.Forms.TextBox();
            this.lMd5 = new System.Windows.Forms.Label();
            this.tbMd5Llave = new System.Windows.Forms.TextBox();
            this.tbMensaje = new System.Windows.Forms.TextBox();
            this.lLlave = new System.Windows.Forms.Label();
            this.lMensaje = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSha1Mensaje = new System.Windows.Forms.TextBox();
            this.lMd5Mensaje = new System.Windows.Forms.Label();
            this.tbMd5Mensaje = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bDesencriptar = new System.Windows.Forms.Button();
            this.tbDesencriptar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbLlave
            // 
            this.tbLlave.Location = new System.Drawing.Point(26, 34);
            this.tbLlave.Name = "tbLlave";
            this.tbLlave.Size = new System.Drawing.Size(769, 20);
            this.tbLlave.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(376, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Encriptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Sha1
            // 
            this.Sha1.AutoSize = true;
            this.Sha1.Location = new System.Drawing.Point(23, 196);
            this.Sha1.Name = "Sha1";
            this.Sha1.Size = new System.Drawing.Size(61, 13);
            this.Sha1.TabIndex = 2;
            this.Sha1.Text = "Sha1 Llave";
            // 
            // tbSha1Llave
            // 
            this.tbSha1Llave.Location = new System.Drawing.Point(26, 212);
            this.tbSha1Llave.Multiline = true;
            this.tbSha1Llave.Name = "tbSha1Llave";
            this.tbSha1Llave.Size = new System.Drawing.Size(371, 43);
            this.tbSha1Llave.TabIndex = 3;
            // 
            // tbEncriptar
            // 
            this.tbEncriptar.Location = new System.Drawing.Point(26, 374);
            this.tbEncriptar.Multiline = true;
            this.tbEncriptar.Name = "tbEncriptar";
            this.tbEncriptar.Size = new System.Drawing.Size(769, 49);
            this.tbEncriptar.TabIndex = 4;
            // 
            // lMd5
            // 
            this.lMd5.AutoSize = true;
            this.lMd5.Location = new System.Drawing.Point(23, 268);
            this.lMd5.Name = "lMd5";
            this.lMd5.Size = new System.Drawing.Size(59, 13);
            this.lMd5.TabIndex = 5;
            this.lMd5.Text = "MD5 Llave";
            // 
            // tbMd5Llave
            // 
            this.tbMd5Llave.Location = new System.Drawing.Point(26, 284);
            this.tbMd5Llave.Multiline = true;
            this.tbMd5Llave.Name = "tbMd5Llave";
            this.tbMd5Llave.Size = new System.Drawing.Size(371, 51);
            this.tbMd5Llave.TabIndex = 6;
            // 
            // tbMensaje
            // 
            this.tbMensaje.Location = new System.Drawing.Point(26, 103);
            this.tbMensaje.Multiline = true;
            this.tbMensaje.Name = "tbMensaje";
            this.tbMensaje.Size = new System.Drawing.Size(769, 40);
            this.tbMensaje.TabIndex = 7;
            // 
            // lLlave
            // 
            this.lLlave.AutoSize = true;
            this.lLlave.Location = new System.Drawing.Point(23, 18);
            this.lLlave.Name = "lLlave";
            this.lLlave.Size = new System.Drawing.Size(33, 13);
            this.lLlave.TabIndex = 8;
            this.lLlave.Text = "Llave";
            // 
            // lMensaje
            // 
            this.lMensaje.AutoSize = true;
            this.lMensaje.Location = new System.Drawing.Point(23, 77);
            this.lMensaje.Name = "lMensaje";
            this.lMensaje.Size = new System.Drawing.Size(47, 13);
            this.lMensaje.TabIndex = 9;
            this.lMensaje.Text = "Mensaje";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(421, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sha 1 Mensaje";
            // 
            // tbSha1Mensaje
            // 
            this.tbSha1Mensaje.Location = new System.Drawing.Point(424, 212);
            this.tbSha1Mensaje.Multiline = true;
            this.tbSha1Mensaje.Name = "tbSha1Mensaje";
            this.tbSha1Mensaje.Size = new System.Drawing.Size(371, 43);
            this.tbSha1Mensaje.TabIndex = 3;
            // 
            // lMd5Mensaje
            // 
            this.lMd5Mensaje.AutoSize = true;
            this.lMd5Mensaje.Location = new System.Drawing.Point(421, 268);
            this.lMd5Mensaje.Name = "lMd5Mensaje";
            this.lMd5Mensaje.Size = new System.Drawing.Size(30, 13);
            this.lMd5Mensaje.TabIndex = 5;
            this.lMd5Mensaje.Text = "MD5";
            // 
            // tbMd5Mensaje
            // 
            this.tbMd5Mensaje.Location = new System.Drawing.Point(424, 284);
            this.tbMd5Mensaje.Multiline = true;
            this.tbMd5Mensaje.Name = "tbMd5Mensaje";
            this.tbMd5Mensaje.Size = new System.Drawing.Size(371, 51);
            this.tbMd5Mensaje.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(522, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "TripleDESCryptoServiceProvider  (Mode: CipherMode.ECB, Padding: PaddingMode.PKCS7" +
    ", ToBase64String)";
            // 
            // bDesencriptar
            // 
            this.bDesencriptar.Location = new System.Drawing.Point(376, 439);
            this.bDesencriptar.Name = "bDesencriptar";
            this.bDesencriptar.Size = new System.Drawing.Size(75, 23);
            this.bDesencriptar.TabIndex = 12;
            this.bDesencriptar.Text = "Desencriptar";
            this.bDesencriptar.UseVisualStyleBackColor = true;
            this.bDesencriptar.Click += new System.EventHandler(this.bDesencriptar_Click);
            // 
            // tbDesencriptar
            // 
            this.tbDesencriptar.Location = new System.Drawing.Point(26, 488);
            this.tbDesencriptar.Multiline = true;
            this.tbDesencriptar.Name = "tbDesencriptar";
            this.tbDesencriptar.Size = new System.Drawing.Size(769, 49);
            this.tbDesencriptar.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 472);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(522, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "TripleDESCryptoServiceProvider  (Mode: CipherMode.ECB, Padding: PaddingMode.PKCS7" +
    ", ToBase64String)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 568);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDesencriptar);
            this.Controls.Add(this.bDesencriptar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMd5Mensaje);
            this.Controls.Add(this.lMensaje);
            this.Controls.Add(this.lLlave);
            this.Controls.Add(this.tbMensaje);
            this.Controls.Add(this.tbMd5Llave);
            this.Controls.Add(this.lMd5Mensaje);
            this.Controls.Add(this.lMd5);
            this.Controls.Add(this.tbEncriptar);
            this.Controls.Add(this.tbSha1Mensaje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSha1Llave);
            this.Controls.Add(this.Sha1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbLlave);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLlave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Sha1;
        private System.Windows.Forms.TextBox tbSha1Llave;
        private System.Windows.Forms.TextBox tbEncriptar;
        private System.Windows.Forms.Label lMd5;
        private System.Windows.Forms.TextBox tbMd5Llave;
        private System.Windows.Forms.TextBox tbMensaje;
        private System.Windows.Forms.Label lLlave;
        private System.Windows.Forms.Label lMensaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSha1Mensaje;
        private System.Windows.Forms.Label lMd5Mensaje;
        private System.Windows.Forms.TextBox tbMd5Mensaje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bDesencriptar;
        private System.Windows.Forms.TextBox tbDesencriptar;
        private System.Windows.Forms.Label label3;
    }
}

