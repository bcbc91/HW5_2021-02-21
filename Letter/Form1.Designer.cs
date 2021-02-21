
namespace Letter
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
            this.tbWord = new System.Windows.Forms.TextBox();
            this.tbVowel = new System.Windows.Forms.TextBox();
            this.tbSurd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bDetect = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(39, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kelime Yazınız:";
            // 
            // tbWord
            // 
            this.tbWord.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbWord.Location = new System.Drawing.Point(204, 40);
            this.tbWord.Name = "tbWord";
            this.tbWord.Size = new System.Drawing.Size(129, 33);
            this.tbWord.TabIndex = 1;
            // 
            // tbVowel
            // 
            this.tbVowel.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbVowel.Location = new System.Drawing.Point(204, 94);
            this.tbVowel.Name = "tbVowel";
            this.tbVowel.ReadOnly = true;
            this.tbVowel.Size = new System.Drawing.Size(129, 33);
            this.tbVowel.TabIndex = 2;
            // 
            // tbSurd
            // 
            this.tbSurd.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbSurd.Location = new System.Drawing.Point(204, 140);
            this.tbSurd.Name = "tbSurd";
            this.tbSurd.ReadOnly = true;
            this.tbSurd.Size = new System.Drawing.Size(129, 33);
            this.tbSurd.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(39, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sesli Harfler:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(39, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sessiz Harfler:";
            // 
            // bDetect
            // 
            this.bDetect.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bDetect.Location = new System.Drawing.Point(44, 199);
            this.bDetect.Name = "bDetect";
            this.bDetect.Size = new System.Drawing.Size(123, 47);
            this.bDetect.TabIndex = 3;
            this.bDetect.Text = "Tespit Et";
            this.bDetect.UseVisualStyleBackColor = true;
            this.bDetect.Click += new System.EventHandler(this.bDetect_Click);
            // 
            // bClear
            // 
            this.bClear.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bClear.Location = new System.Drawing.Point(204, 199);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(129, 47);
            this.bClear.TabIndex = 3;
            this.bClear.Text = "Temizle";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 304);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.bDetect);
            this.Controls.Add(this.tbSurd);
            this.Controls.Add(this.tbVowel);
            this.Controls.Add(this.tbWord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Harf Tespit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbWord;
        private System.Windows.Forms.TextBox tbVowel;
        private System.Windows.Forms.TextBox tbSurd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bDetect;
        private System.Windows.Forms.Button bClear;
    }
}

