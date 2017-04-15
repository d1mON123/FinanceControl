namespace FinanceControlApp.Forms
{
    partial class EditPersonForm
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
            this.personAddButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.personCancelButton = new System.Windows.Forms.Button();
            this.personNameBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // personAddButton
            // 
            this.personAddButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.personAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.personAddButton.Location = new System.Drawing.Point(33, 75);
            this.personAddButton.Name = "personAddButton";
            this.personAddButton.Size = new System.Drawing.Size(97, 28);
            this.personAddButton.TabIndex = 11;
            this.personAddButton.Text = "Додати";
            this.personAddButton.UseVisualStyleBackColor = true;
            this.personAddButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(32, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Назва:";
            // 
            // personCancelButton
            // 
            this.personCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.personCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.personCancelButton.Location = new System.Drawing.Point(154, 75);
            this.personCancelButton.Name = "personCancelButton";
            this.personCancelButton.Size = new System.Drawing.Size(97, 28);
            this.personCancelButton.TabIndex = 9;
            this.personCancelButton.Text = "Скасувати";
            this.personCancelButton.UseVisualStyleBackColor = true;
            // 
            // personNameBox
            // 
            this.personNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.personNameBox.Location = new System.Drawing.Point(123, 24);
            this.personNameBox.Name = "personNameBox";
            this.personNameBox.Size = new System.Drawing.Size(131, 26);
            this.personNameBox.TabIndex = 8;
            // 
            // EditPersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 118);
            this.Controls.Add(this.personAddButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.personCancelButton);
            this.Controls.Add(this.personNameBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EditPersonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Додавання особи";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button personAddButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button personCancelButton;
        private System.Windows.Forms.TextBox personNameBox;
    }
}