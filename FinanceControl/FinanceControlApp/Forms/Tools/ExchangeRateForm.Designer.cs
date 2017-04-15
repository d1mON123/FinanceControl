namespace FinanceControlApp.Forms
{
    partial class ExchangeRateForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.firstCurrencyBox = new System.Windows.Forms.ComboBox();
            this.secondCurrencyBox = new System.Windows.Forms.ComboBox();
            this.ValueBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.performButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 150);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(338, 183);
            this.textBox1.TabIndex = 1;
            // 
            // firstCurrencyBox
            // 
            this.firstCurrencyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstCurrencyBox.FormattingEnabled = true;
            this.firstCurrencyBox.Location = new System.Drawing.Point(115, 33);
            this.firstCurrencyBox.Name = "firstCurrencyBox";
            this.firstCurrencyBox.Size = new System.Drawing.Size(54, 21);
            this.firstCurrencyBox.TabIndex = 2;
            // 
            // secondCurrencyBox
            // 
            this.secondCurrencyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondCurrencyBox.FormattingEnabled = true;
            this.secondCurrencyBox.Location = new System.Drawing.Point(264, 34);
            this.secondCurrencyBox.Name = "secondCurrencyBox";
            this.secondCurrencyBox.Size = new System.Drawing.Size(54, 21);
            this.secondCurrencyBox.TabIndex = 3;
            // 
            // ValueBox
            // 
            this.ValueBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ValueBox.Location = new System.Drawing.Point(43, 34);
            this.ValueBox.Name = "ValueBox";
            this.ValueBox.Size = new System.Drawing.Size(66, 20);
            this.ValueBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(175, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = ">>>>";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Результат:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultBox
            // 
            this.resultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultBox.Location = new System.Drawing.Point(113, 95);
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(66, 20);
            this.resultBox.TabIndex = 8;
            // 
            // performButton
            // 
            this.performButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.performButton.Location = new System.Drawing.Point(224, 87);
            this.performButton.Name = "performButton";
            this.performButton.Size = new System.Drawing.Size(108, 30);
            this.performButton.TabIndex = 9;
            this.performButton.Text = "Обрахувати";
            this.performButton.UseVisualStyleBackColor = true;
            this.performButton.Click += new System.EventHandler(this.PerformButton_Click);
            // 
            // ExchangeRateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 345);
            this.Controls.Add(this.performButton);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ValueBox);
            this.Controls.Add(this.secondCurrencyBox);
            this.Controls.Add(this.firstCurrencyBox);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ExchangeRateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Конвертер валют";
            this.Load += new System.EventHandler(this.ExchangeRateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox firstCurrencyBox;
        private System.Windows.Forms.ComboBox secondCurrencyBox;
        private System.Windows.Forms.TextBox ValueBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Button performButton;
    }
}