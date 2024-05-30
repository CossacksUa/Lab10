namespace Lab10
{
    partial class Form1
    {
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Button buttonHash;
        private System.Windows.Forms.Button buttonStreamCipher;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonHashStop;
        private System.Windows.Forms.Button buttonMaurerStop;
        private System.Windows.Forms.RichTextBox richTextBoxCRABResult;
        private System.Windows.Forms.RichTextBox richTextBoxHashResult;
        private System.Windows.Forms.RichTextBox richTextBoxStreamCipherResult;

        private void InitializeComponent()
        {
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.buttonHash = new System.Windows.Forms.Button();
            this.buttonStreamCipher = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonHashStop = new System.Windows.Forms.Button();
            this.buttonMaurerStop = new System.Windows.Forms.Button();
            this.richTextBoxCRABResult = new System.Windows.Forms.RichTextBox();
            this.richTextBoxHashResult = new System.Windows.Forms.RichTextBox();
            this.richTextBoxStreamCipherResult = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(35, 112);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(150, 50);
            this.buttonEncrypt.TabIndex = 0;
            this.buttonEncrypt.Text = "Encrypt (CRAB)";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // buttonHash
            // 
            this.buttonHash.Location = new System.Drawing.Point(35, 203);
            this.buttonHash.Name = "buttonHash";
            this.buttonHash.Size = new System.Drawing.Size(150, 50);
            this.buttonHash.TabIndex = 1;
            this.buttonHash.Text = "Hash (RIPE-MD)";
            this.buttonHash.UseVisualStyleBackColor = true;
            this.buttonHash.Click += new System.EventHandler(this.buttonHash_Click);
            // 
            // buttonStreamCipher
            // 
            this.buttonStreamCipher.Location = new System.Drawing.Point(35, 295);
            this.buttonStreamCipher.Name = "buttonStreamCipher";
            this.buttonStreamCipher.Size = new System.Drawing.Size(150, 50);
            this.buttonStreamCipher.TabIndex = 2;
            this.buttonStreamCipher.Text = "Stream Cipher (Maurer)";
            this.buttonStreamCipher.UseVisualStyleBackColor = true;
            this.buttonStreamCipher.Click += new System.EventHandler(this.buttonStreamCipher_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(628, 112);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(150, 50);
            this.buttonStop.TabIndex = 3;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonHashStop
            // 
            this.buttonHashStop.Location = new System.Drawing.Point(628, 203);
            this.buttonHashStop.Name = "buttonHashStop";
            this.buttonHashStop.Size = new System.Drawing.Size(150, 50);
            this.buttonHashStop.TabIndex = 4;
            this.buttonHashStop.Text = "Hash (RIPE-MD) Stop";
            this.buttonHashStop.UseVisualStyleBackColor = true;
            this.buttonHashStop.Click += new System.EventHandler(this.buttonHashStop_Click);
            // 
            // buttonMaurerStop
            // 
            this.buttonMaurerStop.Location = new System.Drawing.Point(628, 295);
            this.buttonMaurerStop.Name = "buttonMaurerStop";
            this.buttonMaurerStop.Size = new System.Drawing.Size(150, 50);
            this.buttonMaurerStop.TabIndex = 4;
            this.buttonMaurerStop.Text = "MaurerStop";
            this.buttonMaurerStop.UseVisualStyleBackColor = true;
            this.buttonMaurerStop.Click += new System.EventHandler(this.buttonMaurerStop_Click);
            // 
            // richTextBoxCRABResult
            // 
            this.richTextBoxCRABResult.Location = new System.Drawing.Point(224, 112);
            this.richTextBoxCRABResult.Name = "richTextBoxCRABResult";
            this.richTextBoxCRABResult.Size = new System.Drawing.Size(386, 50);
            this.richTextBoxCRABResult.TabIndex = 5;
            this.richTextBoxCRABResult.Text = "";
            // 
            // richTextBoxHashResult
            // 
            this.richTextBoxHashResult.Location = new System.Drawing.Point(224, 203);
            this.richTextBoxHashResult.Name = "richTextBoxHashResult";
            this.richTextBoxHashResult.Size = new System.Drawing.Size(386, 50);
            this.richTextBoxHashResult.TabIndex = 6;
            this.richTextBoxHashResult.Text = "";
            // 
            // richTextBoxStreamCipherResult
            // 
            this.richTextBoxStreamCipherResult.Location = new System.Drawing.Point(224, 295);
            this.richTextBoxStreamCipherResult.Name = "richTextBoxStreamCipherResult";
            this.richTextBoxStreamCipherResult.Size = new System.Drawing.Size(386, 278);
            this.richTextBoxStreamCipherResult.TabIndex = 7;
            this.richTextBoxStreamCipherResult.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(221, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Шифрування слова: Ukraine";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 688);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxStreamCipherResult);
            this.Controls.Add(this.richTextBoxHashResult);
            this.Controls.Add(this.richTextBoxCRABResult);
            this.Controls.Add(this.buttonHashStop);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonMaurerStop);
            this.Controls.Add(this.buttonStreamCipher);
            this.Controls.Add(this.buttonHash);
            this.Controls.Add(this.buttonEncrypt);
            this.Name = "Form1";
            this.Text = "Cryptography Tasks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
    }
}
