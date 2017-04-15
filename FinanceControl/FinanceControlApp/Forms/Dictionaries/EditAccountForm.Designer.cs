namespace FinanceControlApp.Forms
{
    partial class EditAccountForm
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
            this.components = new System.ComponentModel.Container();
            ImageComboBox.ImageComboBoxItem imageComboBoxItem1 = new ImageComboBox.ImageComboBoxItem();
            ImageComboBox.ImageComboBoxItem imageComboBoxItem2 = new ImageComboBox.ImageComboBoxItem();
            ImageComboBox.ImageComboBoxItem imageComboBoxItem3 = new ImageComboBox.ImageComboBoxItem();
            ImageComboBox.ImageComboBoxItem imageComboBoxItem4 = new ImageComboBox.ImageComboBoxItem();
            ImageComboBox.ImageComboBoxItem imageComboBoxItem5 = new ImageComboBox.ImageComboBoxItem();
            ImageComboBox.ImageComboBoxItem imageComboBoxItem6 = new ImageComboBox.ImageComboBoxItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditAccountForm));
            this.accountNameBox = new System.Windows.Forms.TextBox();
            this.accountCurrAmountBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.imageComboBox1 = new ImageComboBox.ImageComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // accountNameBox
            // 
            this.accountNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accountNameBox.Location = new System.Drawing.Point(150, 21);
            this.accountNameBox.Name = "accountNameBox";
            this.accountNameBox.Size = new System.Drawing.Size(131, 26);
            this.accountNameBox.TabIndex = 0;
            // 
            // accountCurrAmountBox
            // 
            this.accountCurrAmountBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accountCurrAmountBox.Location = new System.Drawing.Point(150, 65);
            this.accountCurrAmountBox.Name = "accountCurrAmountBox";
            this.accountCurrAmountBox.Size = new System.Drawing.Size(131, 26);
            this.accountCurrAmountBox.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(42, 154);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(97, 29);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Додати";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Назва рахунку:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Баланс:";
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(165, 154);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(97, 29);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Скасувати";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // imageComboBox1
            // 
            this.imageComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.imageComboBox1.ImageList = this.imageList1;
            this.imageComboBox1.Indent = 0;
            this.imageComboBox1.ItemHeight = 40;
            imageComboBoxItem1.Font = null;
            imageComboBoxItem1.Image = "0";
            imageComboBoxItem1.ImageIndex = 0;
            imageComboBoxItem1.IndentLevel = 0;
            imageComboBoxItem1.Item = null;
            imageComboBoxItem1.Text = " ";
            imageComboBoxItem2.Font = null;
            imageComboBoxItem2.Image = "1";
            imageComboBoxItem2.ImageIndex = 1;
            imageComboBoxItem2.IndentLevel = 0;
            imageComboBoxItem2.Item = null;
            imageComboBoxItem2.Text = " ";
            imageComboBoxItem3.Font = null;
            imageComboBoxItem3.Image = "2";
            imageComboBoxItem3.ImageIndex = 2;
            imageComboBoxItem3.IndentLevel = 0;
            imageComboBoxItem3.Item = null;
            imageComboBoxItem3.Text = " ";
            imageComboBoxItem4.Font = null;
            imageComboBoxItem4.Image = "3";
            imageComboBoxItem4.ImageIndex = 3;
            imageComboBoxItem4.IndentLevel = 0;
            imageComboBoxItem4.Item = null;
            imageComboBoxItem4.Text = " ";
            imageComboBoxItem5.Font = null;
            imageComboBoxItem5.Image = "4";
            imageComboBoxItem5.ImageIndex = 4;
            imageComboBoxItem5.IndentLevel = 0;
            imageComboBoxItem5.Item = null;
            imageComboBoxItem5.Text = " ";
            imageComboBoxItem6.Font = null;
            imageComboBoxItem6.Image = "5";
            imageComboBoxItem6.ImageIndex = 5;
            imageComboBoxItem6.IndentLevel = 0;
            imageComboBoxItem6.Item = null;
            imageComboBoxItem6.Text = " ";
            this.imageComboBox1.Items.AddRange(new ImageComboBox.ImageComboBoxItem[] {
            imageComboBoxItem1,
            imageComboBoxItem2,
            imageComboBoxItem3,
            imageComboBoxItem4,
            imageComboBoxItem5,
            imageComboBoxItem6});
            this.imageComboBox1.Location = new System.Drawing.Point(178, 97);
            this.imageComboBox1.MaxDropDownItems = 3;
            this.imageComboBox1.Name = "imageComboBox1";
            this.imageComboBox1.Size = new System.Drawing.Size(67, 46);
            this.imageComboBox1.TabIndex = 7;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1.png");
            this.imageList1.Images.SetKeyName(1, "2.png");
            this.imageList1.Images.SetKeyName(2, "3.png");
            this.imageList1.Images.SetKeyName(3, "4.png");
            this.imageList1.Images.SetKeyName(4, "5.png");
            this.imageList1.Images.SetKeyName(5, "6.png");
            this.imageList1.Images.SetKeyName(6, "7.png");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Зображення:";
            // 
            // EditAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 200);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.imageComboBox1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.accountCurrAmountBox);
            this.Controls.Add(this.accountNameBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EditAccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Додавання рахунку";
            this.Load += new System.EventHandler(this.EditDictionaryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox accountNameBox;
        private System.Windows.Forms.TextBox accountCurrAmountBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancelButton;
        private ImageComboBox.ImageComboBox imageComboBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label3;
    }
}