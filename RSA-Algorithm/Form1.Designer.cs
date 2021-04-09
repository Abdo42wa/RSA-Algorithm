namespace RSA_Algorithm
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
            this.label1 = new System.Windows.Forms.Label();
            this.encryptedTxt = new System.Windows.Forms.TextBox();
            this.encryptTxt = new System.Windows.Forms.TextBox();
            this.decryptedTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.eTxt = new System.Windows.Forms.TextBox();
            this.nTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.qTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pTxt = new System.Windows.Forms.TextBox();
            this.decryptBtn = new System.Windows.Forms.Button();
            this.encryptBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Text to cypher:";
            // 
            // encryptedTxt
            // 
            this.encryptedTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptedTxt.Location = new System.Drawing.Point(406, 56);
            this.encryptedTxt.Multiline = true;
            this.encryptedTxt.Name = "encryptedTxt";
            this.encryptedTxt.ReadOnly = true;
            this.encryptedTxt.Size = new System.Drawing.Size(347, 112);
            this.encryptedTxt.TabIndex = 13;
            // 
            // encryptTxt
            // 
            this.encryptTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptTxt.Location = new System.Drawing.Point(25, 56);
            this.encryptTxt.Multiline = true;
            this.encryptTxt.Name = "encryptTxt";
            this.encryptTxt.Size = new System.Drawing.Size(347, 112);
            this.encryptTxt.TabIndex = 14;
            // 
            // decryptedTxt
            // 
            this.decryptedTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptedTxt.Location = new System.Drawing.Point(774, 56);
            this.decryptedTxt.Multiline = true;
            this.decryptedTxt.Name = "decryptedTxt";
            this.decryptedTxt.ReadOnly = true;
            this.decryptedTxt.Size = new System.Drawing.Size(347, 112);
            this.decryptedTxt.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(519, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Encrypted text:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(882, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Decrypted text:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(668, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 24);
            this.label7.TabIndex = 32;
            this.label7.Text = "e:";
            // 
            // eTxt
            // 
            this.eTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eTxt.Location = new System.Drawing.Point(700, 290);
            this.eTxt.Name = "eTxt";
            this.eTxt.Size = new System.Drawing.Size(95, 26);
            this.eTxt.TabIndex = 31;
            // 
            // nTxt
            // 
            this.nTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nTxt.Location = new System.Drawing.Point(700, 258);
            this.nTxt.Name = "nTxt";
            this.nTxt.Size = new System.Drawing.Size(95, 26);
            this.nTxt.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(668, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 24);
            this.label5.TabIndex = 29;
            this.label5.Text = "n:";
            // 
            // qTxt
            // 
            this.qTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qTxt.Location = new System.Drawing.Point(480, 290);
            this.qTxt.Name = "qTxt";
            this.qTxt.Size = new System.Drawing.Size(95, 26);
            this.qTxt.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(448, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 24);
            this.label3.TabIndex = 27;
            this.label3.Text = "q:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(448, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "p:";
            // 
            // pTxt
            // 
            this.pTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pTxt.Location = new System.Drawing.Point(480, 258);
            this.pTxt.Name = "pTxt";
            this.pTxt.Size = new System.Drawing.Size(95, 26);
            this.pTxt.TabIndex = 25;
            // 
            // decryptBtn
            // 
            this.decryptBtn.Location = new System.Drawing.Point(640, 339);
            this.decryptBtn.Name = "decryptBtn";
            this.decryptBtn.Size = new System.Drawing.Size(90, 32);
            this.decryptBtn.TabIndex = 24;
            this.decryptBtn.Text = "Decrypt";
            this.decryptBtn.UseVisualStyleBackColor = true;
            this.decryptBtn.Click += new System.EventHandler(this.decryptBtn_Click);
            // 
            // encryptBtn
            // 
            this.encryptBtn.Location = new System.Drawing.Point(509, 339);
            this.encryptBtn.Name = "encryptBtn";
            this.encryptBtn.Size = new System.Drawing.Size(90, 32);
            this.encryptBtn.TabIndex = 23;
            this.encryptBtn.Text = "Encrypt";
            this.encryptBtn.UseVisualStyleBackColor = true;
            this.encryptBtn.Click += new System.EventHandler(this.encryptBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 464);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.eTxt);
            this.Controls.Add(this.nTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.qTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pTxt);
            this.Controls.Add(this.decryptBtn);
            this.Controls.Add(this.encryptBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.decryptedTxt);
            this.Controls.Add(this.encryptTxt);
            this.Controls.Add(this.encryptedTxt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox encryptedTxt;
        private System.Windows.Forms.TextBox encryptTxt;
        private System.Windows.Forms.TextBox decryptedTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox eTxt;
        private System.Windows.Forms.TextBox nTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox qTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pTxt;
        private System.Windows.Forms.Button decryptBtn;
        private System.Windows.Forms.Button encryptBtn;
    }
}

