namespace _3form
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.result2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите начальное значение:";
            // 
            // textBoxA
            // 
            this.textBoxA.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBoxA.Location = new System.Drawing.Point(18, 56);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 32);
            this.textBoxA.TabIndex = 1;
            // 
            // textBoxB
            // 
            this.textBoxB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBoxB.Location = new System.Drawing.Point(18, 157);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(100, 32);
            this.textBoxB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(13, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите конечное значение:";
            // 
            // textBoxH
            // 
            this.textBoxH.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBoxH.Location = new System.Drawing.Point(18, 264);
            this.textBoxH.Name = "textBoxH";
            this.textBoxH.Size = new System.Drawing.Size(100, 32);
            this.textBoxH.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(13, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Введите шаг:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(198, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Результат";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.result.Location = new System.Drawing.Point(495, 13);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(124, 26);
            this.result.TabIndex = 7;
            this.result.Text = "Результат:";
            // 
            // result2
            // 
            this.result2.AutoSize = true;
            this.result2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.result2.Location = new System.Drawing.Point(978, 13);
            this.result2.Name = "result2";
            this.result2.Size = new System.Drawing.Size(212, 26);
            this.result2.TabIndex = 7;
            this.result2.Text = "Результат (перегр):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1455, 450);
            this.Controls.Add(this.result2);
            this.Controls.Add(this.result);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label result2;
    }
}

