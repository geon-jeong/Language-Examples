namespace RSA
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
            this.textBox_key = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox_PrivateKey = new System.Windows.Forms.RichTextBox();
            this.button_keygen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox_PublicKey = new System.Windows.Forms.RichTextBox();
            this.button_Decryption = new System.Windows.Forms.Button();
            this.richTextBox_Decryption = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // textBox_key
            // 
            this.textBox_key.Location = new System.Drawing.Point(101, 26);
            this.textBox_key.Name = "textBox_key";
            this.textBox_key.Size = new System.Drawing.Size(507, 35);
            this.textBox_key.TabIndex = 0;
            this.textBox_key.Text = "Test";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(38, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Text";
            // 
            // richTextBox_PrivateKey
            // 
            this.richTextBox_PrivateKey.Location = new System.Drawing.Point(30, 135);
            this.richTextBox_PrivateKey.Name = "richTextBox_PrivateKey";
            this.richTextBox_PrivateKey.ReadOnly = true;
            this.richTextBox_PrivateKey.Size = new System.Drawing.Size(658, 866);
            this.richTextBox_PrivateKey.TabIndex = 2;
            this.richTextBox_PrivateKey.Text = "";
            // 
            // button_keygen
            // 
            this.button_keygen.Location = new System.Drawing.Point(624, 25);
            this.button_keygen.Name = "button_keygen";
            this.button_keygen.Size = new System.Drawing.Size(280, 44);
            this.button_keygen.TabIndex = 4;
            this.button_keygen.Text = "Generate Key";
            this.button_keygen.UseVisualStyleBackColor = true;
            this.button_keygen.Click += new System.EventHandler(this.Button_keygen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(38, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Private Key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(713, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Public Key";
            // 
            // richTextBox_PublicKey
            // 
            this.richTextBox_PublicKey.Location = new System.Drawing.Point(717, 135);
            this.richTextBox_PublicKey.Name = "richTextBox_PublicKey";
            this.richTextBox_PublicKey.ReadOnly = true;
            this.richTextBox_PublicKey.Size = new System.Drawing.Size(658, 420);
            this.richTextBox_PublicKey.TabIndex = 7;
            this.richTextBox_PublicKey.Text = "";
            // 
            // button_Decryption
            // 
            this.button_Decryption.Location = new System.Drawing.Point(717, 587);
            this.button_Decryption.Name = "button_Decryption";
            this.button_Decryption.Size = new System.Drawing.Size(658, 48);
            this.button_Decryption.TabIndex = 8;
            this.button_Decryption.Text = "Decryption";
            this.button_Decryption.UseVisualStyleBackColor = true;
            this.button_Decryption.Click += new System.EventHandler(this.Button_Decryption_Click);
            // 
            // richTextBox_Decryption
            // 
            this.richTextBox_Decryption.Location = new System.Drawing.Point(717, 648);
            this.richTextBox_Decryption.Name = "richTextBox_Decryption";
            this.richTextBox_Decryption.ReadOnly = true;
            this.richTextBox_Decryption.Size = new System.Drawing.Size(658, 45);
            this.richTextBox_Decryption.TabIndex = 9;
            this.richTextBox_Decryption.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1458, 1104);
            this.Controls.Add(this.richTextBox_Decryption);
            this.Controls.Add(this.button_Decryption);
            this.Controls.Add(this.richTextBox_PublicKey);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_keygen);
            this.Controls.Add(this.richTextBox_PrivateKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_key);
            this.Name = "Form1";
            this.Text = "RSA - https://github.com/geon-jeong/Language-Examples.git";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_key;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox_PrivateKey;
        private System.Windows.Forms.Button button_keygen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox_PublicKey;
        private System.Windows.Forms.Button button_Decryption;
        private System.Windows.Forms.RichTextBox richTextBox_Decryption;
    }
}

