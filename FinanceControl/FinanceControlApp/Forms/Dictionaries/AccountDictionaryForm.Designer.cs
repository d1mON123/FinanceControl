namespace FinanceControlApp.Forms
{
    partial class AccountDictionaryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountDictionaryForm));
            this.accountDataGrid = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.accountDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // accountDataGrid
            // 
            this.accountDataGrid.AutoGenerateColumns = false;
            this.accountDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.currentAmountDataGridViewTextBoxColumn});
            this.accountDataGrid.DataSource = this.accountBindingSource;
            this.accountDataGrid.Location = new System.Drawing.Point(12, 12);
            this.accountDataGrid.Name = "accountDataGrid";
            this.accountDataGrid.ReadOnly = true;
            this.accountDataGrid.Size = new System.Drawing.Size(346, 226);
            this.accountDataGrid.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Назва";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // currentAmountDataGridViewTextBoxColumn
            // 
            this.currentAmountDataGridViewTextBoxColumn.DataPropertyName = "CurrentAmount";
            this.currentAmountDataGridViewTextBoxColumn.HeaderText = "Баланс";
            this.currentAmountDataGridViewTextBoxColumn.Name = "currentAmountDataGridViewTextBoxColumn";
            this.currentAmountDataGridViewTextBoxColumn.ReadOnly = true;
            this.currentAmountDataGridViewTextBoxColumn.Width = 150;
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataSource = typeof(FinanceControlDAL.Models.Account);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(377, 12);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(106, 27);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Додати";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(377, 58);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(106, 27);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Редагувати";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // delButton
            // 
            this.delButton.Location = new System.Drawing.Point(377, 104);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(106, 27);
            this.delButton.TabIndex = 3;
            this.delButton.Text = "Видалити";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // AccountDictionaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 250);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.accountDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AccountDictionaryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список рахунків";
            this.Load += new System.EventHandler(this.AccountDictionaryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView accountDataGrid;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button delButton;
    }
}