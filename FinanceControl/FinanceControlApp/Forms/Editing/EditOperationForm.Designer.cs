namespace FinanceControlApp.Forms
{
    partial class EditOperationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditOperationForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.incomeCancelButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.incomeAccountComboBox = new System.Windows.Forms.ComboBox();
            this.incomeCommentBox = new System.Windows.Forms.TextBox();
            this.incomeValueBox = new System.Windows.Forms.TextBox();
            this.incomePersonComboBox = new System.Windows.Forms.ComboBox();
            this.incomeDatePicker = new System.Windows.Forms.DateTimePicker();
            this.incomeTypeComboBox = new System.Windows.Forms.ComboBox();
            this.incomeAddButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.outlayCancelButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.outlayAccountComboBox = new System.Windows.Forms.ComboBox();
            this.outlayCommentBox = new System.Windows.Forms.TextBox();
            this.outlayValueBox = new System.Windows.Forms.TextBox();
            this.outlayPersonComboBox = new System.Windows.Forms.ComboBox();
            this.outlayDatePicker = new System.Windows.Forms.DateTimePicker();
            this.outlayTypeComboBox = new System.Windows.Forms.ComboBox();
            this.outlayAddButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(553, 220);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.incomeCancelButton);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.incomeAccountComboBox);
            this.tabPage1.Controls.Add(this.incomeCommentBox);
            this.tabPage1.Controls.Add(this.incomeValueBox);
            this.tabPage1.Controls.Add(this.incomePersonComboBox);
            this.tabPage1.Controls.Add(this.incomeDatePicker);
            this.tabPage1.Controls.Add(this.incomeTypeComboBox);
            this.tabPage1.Controls.Add(this.incomeAddButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(545, 194);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Дохід";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // incomeCancelButton
            // 
            this.incomeCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.incomeCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.incomeCancelButton.Location = new System.Drawing.Point(286, 145);
            this.incomeCancelButton.Name = "incomeCancelButton";
            this.incomeCancelButton.Size = new System.Drawing.Size(99, 37);
            this.incomeCancelButton.TabIndex = 13;
            this.incomeCancelButton.Text = "Скасувати";
            this.incomeCancelButton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(293, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Коментар: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(293, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Розмір: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(293, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Член сім\'ї: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(20, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Категорія: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(20, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Дата: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Рахунок: ";
            // 
            // incomeAccountComboBox
            // 
            this.incomeAccountComboBox.FormattingEnabled = true;
            this.incomeAccountComboBox.Location = new System.Drawing.Point(117, 23);
            this.incomeAccountComboBox.Name = "incomeAccountComboBox";
            this.incomeAccountComboBox.Size = new System.Drawing.Size(121, 21);
            this.incomeAccountComboBox.TabIndex = 6;
            // 
            // incomeCommentBox
            // 
            this.incomeCommentBox.Location = new System.Drawing.Point(388, 104);
            this.incomeCommentBox.Name = "incomeCommentBox";
            this.incomeCommentBox.Size = new System.Drawing.Size(121, 20);
            this.incomeCommentBox.TabIndex = 5;
            // 
            // incomeValueBox
            // 
            this.incomeValueBox.Location = new System.Drawing.Point(388, 61);
            this.incomeValueBox.Name = "incomeValueBox";
            this.incomeValueBox.Size = new System.Drawing.Size(121, 20);
            this.incomeValueBox.TabIndex = 4;
            // 
            // incomePersonComboBox
            // 
            this.incomePersonComboBox.FormattingEnabled = true;
            this.incomePersonComboBox.Location = new System.Drawing.Point(388, 23);
            this.incomePersonComboBox.Name = "incomePersonComboBox";
            this.incomePersonComboBox.Size = new System.Drawing.Size(121, 21);
            this.incomePersonComboBox.TabIndex = 3;
            // 
            // incomeDatePicker
            // 
            this.incomeDatePicker.Location = new System.Drawing.Point(117, 60);
            this.incomeDatePicker.Name = "incomeDatePicker";
            this.incomeDatePicker.Size = new System.Drawing.Size(121, 20);
            this.incomeDatePicker.TabIndex = 2;
            this.incomeDatePicker.Value = new System.DateTime(2017, 4, 5, 11, 25, 9, 0);
            // 
            // incomeTypeComboBox
            // 
            this.incomeTypeComboBox.FormattingEnabled = true;
            this.incomeTypeComboBox.Location = new System.Drawing.Point(117, 101);
            this.incomeTypeComboBox.Name = "incomeTypeComboBox";
            this.incomeTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.incomeTypeComboBox.TabIndex = 1;
            // 
            // incomeAddButton
            // 
            this.incomeAddButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.incomeAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.incomeAddButton.Location = new System.Drawing.Point(159, 145);
            this.incomeAddButton.Name = "incomeAddButton";
            this.incomeAddButton.Size = new System.Drawing.Size(100, 37);
            this.incomeAddButton.TabIndex = 0;
            this.incomeAddButton.Text = "Додати";
            this.incomeAddButton.UseVisualStyleBackColor = true;
            this.incomeAddButton.Click += new System.EventHandler(this.incomeAddButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.outlayCancelButton);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.outlayAccountComboBox);
            this.tabPage2.Controls.Add(this.outlayCommentBox);
            this.tabPage2.Controls.Add(this.outlayValueBox);
            this.tabPage2.Controls.Add(this.outlayPersonComboBox);
            this.tabPage2.Controls.Add(this.outlayDatePicker);
            this.tabPage2.Controls.Add(this.outlayTypeComboBox);
            this.tabPage2.Controls.Add(this.outlayAddButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(545, 194);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Витрата";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // outlayCancelButton
            // 
            this.outlayCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.outlayCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outlayCancelButton.Location = new System.Drawing.Point(286, 145);
            this.outlayCancelButton.Name = "outlayCancelButton";
            this.outlayCancelButton.Size = new System.Drawing.Size(99, 37);
            this.outlayCancelButton.TabIndex = 27;
            this.outlayCancelButton.Text = "Скасувати";
            this.outlayCancelButton.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(293, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Коментар: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(293, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "Розмір: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(293, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Член сім\'ї: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(20, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "Категорія: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(20, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Дата: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(20, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 20);
            this.label12.TabIndex = 21;
            this.label12.Text = "Рахунок: ";
            // 
            // outlayAccountComboBox
            // 
            this.outlayAccountComboBox.FormattingEnabled = true;
            this.outlayAccountComboBox.Location = new System.Drawing.Point(117, 23);
            this.outlayAccountComboBox.Name = "outlayAccountComboBox";
            this.outlayAccountComboBox.Size = new System.Drawing.Size(121, 21);
            this.outlayAccountComboBox.TabIndex = 20;
            // 
            // outlayCommentBox
            // 
            this.outlayCommentBox.Location = new System.Drawing.Point(388, 104);
            this.outlayCommentBox.Name = "outlayCommentBox";
            this.outlayCommentBox.Size = new System.Drawing.Size(121, 20);
            this.outlayCommentBox.TabIndex = 19;
            // 
            // outlayValueBox
            // 
            this.outlayValueBox.Location = new System.Drawing.Point(388, 61);
            this.outlayValueBox.Name = "outlayValueBox";
            this.outlayValueBox.Size = new System.Drawing.Size(121, 20);
            this.outlayValueBox.TabIndex = 18;
            // 
            // outlayPersonComboBox
            // 
            this.outlayPersonComboBox.FormattingEnabled = true;
            this.outlayPersonComboBox.Location = new System.Drawing.Point(388, 23);
            this.outlayPersonComboBox.Name = "outlayPersonComboBox";
            this.outlayPersonComboBox.Size = new System.Drawing.Size(121, 21);
            this.outlayPersonComboBox.TabIndex = 17;
            // 
            // outlayDatePicker
            // 
            this.outlayDatePicker.Location = new System.Drawing.Point(117, 60);
            this.outlayDatePicker.Name = "outlayDatePicker";
            this.outlayDatePicker.Size = new System.Drawing.Size(121, 20);
            this.outlayDatePicker.TabIndex = 16;
            this.outlayDatePicker.Value = new System.DateTime(2017, 4, 5, 11, 25, 9, 0);
            // 
            // outlayTypeComboBox
            // 
            this.outlayTypeComboBox.FormattingEnabled = true;
            this.outlayTypeComboBox.Location = new System.Drawing.Point(117, 101);
            this.outlayTypeComboBox.Name = "outlayTypeComboBox";
            this.outlayTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.outlayTypeComboBox.TabIndex = 15;
            // 
            // outlayAddButton
            // 
            this.outlayAddButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.outlayAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outlayAddButton.Location = new System.Drawing.Point(159, 145);
            this.outlayAddButton.Name = "outlayAddButton";
            this.outlayAddButton.Size = new System.Drawing.Size(100, 37);
            this.outlayAddButton.TabIndex = 14;
            this.outlayAddButton.Text = "Додати";
            this.outlayAddButton.UseVisualStyleBackColor = true;
            this.outlayAddButton.Click += new System.EventHandler(this.outlayAddButton_Click);
            // 
            // EditOperationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 235);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditOperationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Додавання операції";
            this.Load += new System.EventHandler(this.Form_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button incomeAddButton;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox incomeTypeComboBox;
        private System.Windows.Forms.DateTimePicker incomeDatePicker;
        private System.Windows.Forms.ComboBox incomePersonComboBox;
        private System.Windows.Forms.TextBox incomeCommentBox;
        private System.Windows.Forms.TextBox incomeValueBox;
        private System.Windows.Forms.ComboBox incomeAccountComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button incomeCancelButton;
        private System.Windows.Forms.Button outlayCancelButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox outlayAccountComboBox;
        private System.Windows.Forms.TextBox outlayCommentBox;
        private System.Windows.Forms.TextBox outlayValueBox;
        private System.Windows.Forms.ComboBox outlayPersonComboBox;
        private System.Windows.Forms.DateTimePicker outlayDatePicker;
        private System.Windows.Forms.ComboBox outlayTypeComboBox;
        private System.Windows.Forms.Button outlayAddButton;
    }
}