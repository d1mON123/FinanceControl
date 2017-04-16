namespace FinanceControlApp.Forms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.incomeDataGridView = new System.Windows.Forms.DataGridView();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outlayDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.редагуванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.додатиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редагуватиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видалитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.довідникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.члениСіміToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рахункиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статистикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поКатегоріяхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дохідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.витратиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поЧленахСімїToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поКатегоріяхToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.поРахункахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поКатегоріяхToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.поЧленахСімїToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.інструментиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.конвертерВалютToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.експортБазиДаннихToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.prevMonthButton = new System.Windows.Forms.Button();
            this.nextMonthButton = new System.Windows.Forms.Button();
            this.currMonthLabel = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outlayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incomeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.incomeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outlayDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outlayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // incomeDataGridView
            // 
            this.incomeDataGridView.AllowUserToAddRows = false;
            this.incomeDataGridView.AllowUserToDeleteRows = false;
            this.incomeDataGridView.AutoGenerateColumns = false;
            this.incomeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.incomeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dayDataGridViewTextBoxColumn,
            this.monthDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.Value,
            this.commentDataGridViewTextBoxColumn});
            this.incomeDataGridView.DataSource = this.incomeBindingSource;
            this.incomeDataGridView.Location = new System.Drawing.Point(283, 118);
            this.incomeDataGridView.Name = "incomeDataGridView";
            this.incomeDataGridView.ReadOnly = true;
            this.incomeDataGridView.Size = new System.Drawing.Size(515, 200);
            this.incomeDataGridView.TabIndex = 0;
            this.incomeDataGridView.Click += new System.EventHandler(this.IncomeDataGridView_Click);
            this.incomeDataGridView.DoubleClick += new System.EventHandler(this.IncomeDataGridView_DoubleClick);
            // 
            // Value
            // 
            this.Value.DataPropertyName = "Value";
            this.Value.HeaderText = "Вартість";
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            // 
            // outlayDataGridView
            // 
            this.outlayDataGridView.AllowUserToAddRows = false;
            this.outlayDataGridView.AllowUserToDeleteRows = false;
            this.outlayDataGridView.AutoGenerateColumns = false;
            this.outlayDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outlayDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn8});
            this.outlayDataGridView.DataSource = this.outlayBindingSource;
            this.outlayDataGridView.Location = new System.Drawing.Point(283, 324);
            this.outlayDataGridView.Name = "outlayDataGridView";
            this.outlayDataGridView.ReadOnly = true;
            this.outlayDataGridView.Size = new System.Drawing.Size(515, 200);
            this.outlayDataGridView.TabIndex = 1;
            this.outlayDataGridView.Click += new System.EventHandler(this.OutlayDataGridView_Click);
            this.outlayDataGridView.DoubleClick += new System.EventHandler(this.OutlayDataGridView_DoubleClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Value";
            this.dataGridViewTextBoxColumn2.HeaderText = "Вартість";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.редагуванняToolStripMenuItem,
            this.довідникиToolStripMenuItem,
            this.статистикаToolStripMenuItem,
            this.інструментиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(806, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // редагуванняToolStripMenuItem
            // 
            this.редагуванняToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.додатиToolStripMenuItem,
            this.редагуватиToolStripMenuItem,
            this.видалитиToolStripMenuItem});
            this.редагуванняToolStripMenuItem.Name = "редагуванняToolStripMenuItem";
            this.редагуванняToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.редагуванняToolStripMenuItem.Text = "Редагування";
            // 
            // додатиToolStripMenuItem
            // 
            this.додатиToolStripMenuItem.Name = "додатиToolStripMenuItem";
            this.додатиToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.додатиToolStripMenuItem.Text = "Додати";
            this.додатиToolStripMenuItem.Click += new System.EventHandler(this.AddOperation);
            // 
            // редагуватиToolStripMenuItem
            // 
            this.редагуватиToolStripMenuItem.Name = "редагуватиToolStripMenuItem";
            this.редагуватиToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.редагуватиToolStripMenuItem.Text = "Редагувати";
            this.редагуватиToolStripMenuItem.Click += new System.EventHandler(this.EditOperation);
            // 
            // видалитиToolStripMenuItem
            // 
            this.видалитиToolStripMenuItem.Name = "видалитиToolStripMenuItem";
            this.видалитиToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.видалитиToolStripMenuItem.Text = "Видалити";
            this.видалитиToolStripMenuItem.Click += new System.EventHandler(this.DeleteOperation);
            // 
            // довідникиToolStripMenuItem
            // 
            this.довідникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.типToolStripMenuItem,
            this.члениСіміToolStripMenuItem,
            this.рахункиToolStripMenuItem});
            this.довідникиToolStripMenuItem.Name = "довідникиToolStripMenuItem";
            this.довідникиToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.довідникиToolStripMenuItem.Text = "Довідники";
            // 
            // типToolStripMenuItem
            // 
            this.типToolStripMenuItem.Name = "типToolStripMenuItem";
            this.типToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.типToolStripMenuItem.Text = "Категорії";
            this.типToolStripMenuItem.Click += new System.EventHandler(this.OpenTypeDictionary);
            // 
            // члениСіміToolStripMenuItem
            // 
            this.члениСіміToolStripMenuItem.Name = "члениСіміToolStripMenuItem";
            this.члениСіміToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.члениСіміToolStripMenuItem.Text = "Члени сім\'і";
            this.члениСіміToolStripMenuItem.Click += new System.EventHandler(this.OpenPersonDictionary);
            // 
            // рахункиToolStripMenuItem
            // 
            this.рахункиToolStripMenuItem.Name = "рахункиToolStripMenuItem";
            this.рахункиToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.рахункиToolStripMenuItem.Text = "Рахунки";
            this.рахункиToolStripMenuItem.Click += new System.EventHandler(this.OpenAccountDictionary);
            // 
            // статистикаToolStripMenuItem
            // 
            this.статистикаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поКатегоріяхToolStripMenuItem,
            this.поКатегоріяхToolStripMenuItem1});
            this.статистикаToolStripMenuItem.Name = "статистикаToolStripMenuItem";
            this.статистикаToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.статистикаToolStripMenuItem.Text = "Статистика";
            // 
            // поКатегоріяхToolStripMenuItem
            // 
            this.поКатегоріяхToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.дохідToolStripMenuItem,
            this.витратиToolStripMenuItem,
            this.поЧленахСімїToolStripMenuItem});
            this.поКатегоріяхToolStripMenuItem.Name = "поКатегоріяхToolStripMenuItem";
            this.поКатегоріяхToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.поКатегоріяхToolStripMenuItem.Text = "Дохід";
            // 
            // дохідToolStripMenuItem
            // 
            this.дохідToolStripMenuItem.Name = "дохідToolStripMenuItem";
            this.дохідToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.дохідToolStripMenuItem.Text = "По рахунках";
            this.дохідToolStripMenuItem.Click += new System.EventHandler(this.ShowIncomeStatsByAccount);
            // 
            // витратиToolStripMenuItem
            // 
            this.витратиToolStripMenuItem.Name = "витратиToolStripMenuItem";
            this.витратиToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.витратиToolStripMenuItem.Text = "По категоріях";
            this.витратиToolStripMenuItem.Click += new System.EventHandler(this.ShowIncomeStatsByType);
            // 
            // поЧленахСімїToolStripMenuItem
            // 
            this.поЧленахСімїToolStripMenuItem.Name = "поЧленахСімїToolStripMenuItem";
            this.поЧленахСімїToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.поЧленахСімїToolStripMenuItem.Text = "По членах сім\'ї";
            this.поЧленахСімїToolStripMenuItem.Click += new System.EventHandler(this.ShowIncomeStatsByPerson);
            // 
            // поКатегоріяхToolStripMenuItem1
            // 
            this.поКатегоріяхToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поРахункахToolStripMenuItem,
            this.поКатегоріяхToolStripMenuItem2,
            this.поЧленахСімїToolStripMenuItem1});
            this.поКатегоріяхToolStripMenuItem1.Name = "поКатегоріяхToolStripMenuItem1";
            this.поКатегоріяхToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.поКатегоріяхToolStripMenuItem1.Text = "Витрати";
            // 
            // поРахункахToolStripMenuItem
            // 
            this.поРахункахToolStripMenuItem.Name = "поРахункахToolStripMenuItem";
            this.поРахункахToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.поРахункахToolStripMenuItem.Text = "По рахунках";
            this.поРахункахToolStripMenuItem.Click += new System.EventHandler(this.ShowOutlayStatsByAccount);
            // 
            // поКатегоріяхToolStripMenuItem2
            // 
            this.поКатегоріяхToolStripMenuItem2.Name = "поКатегоріяхToolStripMenuItem2";
            this.поКатегоріяхToolStripMenuItem2.Size = new System.Drawing.Size(158, 22);
            this.поКатегоріяхToolStripMenuItem2.Text = "По категоріях";
            this.поКатегоріяхToolStripMenuItem2.Click += new System.EventHandler(this.ShowOutlayStatsByType);
            // 
            // поЧленахСімїToolStripMenuItem1
            // 
            this.поЧленахСімїToolStripMenuItem1.Name = "поЧленахСімїToolStripMenuItem1";
            this.поЧленахСімїToolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.поЧленахСімїToolStripMenuItem1.Text = "По членах сім\'ї";
            this.поЧленахСімїToolStripMenuItem1.Click += new System.EventHandler(this.ShowOutlayStatsByPerson);
            // 
            // інструментиToolStripMenuItem
            // 
            this.інструментиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.конвертерВалютToolStripMenuItem,
            this.експортБазиДаннихToolStripMenuItem});
            this.інструментиToolStripMenuItem.Name = "інструментиToolStripMenuItem";
            this.інструментиToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.інструментиToolStripMenuItem.Text = "Інструменти";
            // 
            // конвертерВалютToolStripMenuItem
            // 
            this.конвертерВалютToolStripMenuItem.Name = "конвертерВалютToolStripMenuItem";
            this.конвертерВалютToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.конвертерВалютToolStripMenuItem.Text = "Конвертер валют";
            this.конвертерВалютToolStripMenuItem.Click += new System.EventHandler(this.ShowCurrencyConverter);
            // 
            // експортБазиДаннихToolStripMenuItem
            // 
            this.експортБазиДаннихToolStripMenuItem.Name = "експортБазиДаннихToolStripMenuItem";
            this.експортБазиДаннихToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.експортБазиДаннихToolStripMenuItem.Text = "Експорт бази данних";
            this.експортБазиДаннихToolStripMenuItem.Click += new System.EventHandler(this.ExportDatabase);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripSeparator1,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(806, 47);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMargin = new System.Drawing.Size(5, 5);
            this.panel1.AutoScrollMinSize = new System.Drawing.Size(5, 5);
            this.panel1.Controls.Add(this.toolStrip2);
            this.panel1.Location = new System.Drawing.Point(12, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 450);
            this.panel1.TabIndex = 5;
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(248, 450);
            this.toolStrip2.Stretch = true;
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // prevMonthButton
            // 
            this.prevMonthButton.Location = new System.Drawing.Point(409, 74);
            this.prevMonthButton.Name = "prevMonthButton";
            this.prevMonthButton.Size = new System.Drawing.Size(44, 38);
            this.prevMonthButton.TabIndex = 6;
            this.prevMonthButton.Text = "<<";
            this.prevMonthButton.UseVisualStyleBackColor = true;
            this.prevMonthButton.Click += new System.EventHandler(this.PrevMonthButton_Click);
            // 
            // nextMonthButton
            // 
            this.nextMonthButton.Location = new System.Drawing.Point(638, 74);
            this.nextMonthButton.Name = "nextMonthButton";
            this.nextMonthButton.Size = new System.Drawing.Size(44, 38);
            this.nextMonthButton.TabIndex = 7;
            this.nextMonthButton.Text = ">>";
            this.nextMonthButton.UseVisualStyleBackColor = true;
            this.nextMonthButton.Click += new System.EventHandler(this.NextMonthButton_Click);
            // 
            // currMonthLabel
            // 
            this.currMonthLabel.Location = new System.Drawing.Point(460, 74);
            this.currMonthLabel.Name = "currMonthLabel";
            this.currMonthLabel.Size = new System.Drawing.Size(172, 38);
            this.currMonthLabel.TabIndex = 8;
            this.currMonthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.вихідToolStripMenuItem.Text = "Вихід";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вихідToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "004-plus.png");
            this.imageList2.Images.SetKeyName(1, "003-error.png");
            this.imageList2.Images.SetKeyName(2, "002-edit.png");
            this.imageList2.Images.SetKeyName(3, "001-share.png");
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 47);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::FinanceControlApp.Properties.Resources._004_plus;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(44, 44);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::FinanceControlApp.Properties.Resources._003_error;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(44, 44);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::FinanceControlApp.Properties.Resources._002_edit;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(44, 44);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::FinanceControlApp.Properties.Resources._001_share;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(44, 44);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Day";
            this.dataGridViewTextBoxColumn3.HeaderText = "День";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 50;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Month";
            this.dataGridViewTextBoxColumn4.HeaderText = "Місяць";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 50;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Year";
            this.dataGridViewTextBoxColumn5.HeaderText = "Рік";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 70;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Comment";
            this.dataGridViewTextBoxColumn8.HeaderText = "Коментар";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 200;
            // 
            // outlayBindingSource
            // 
            this.outlayBindingSource.DataSource = typeof(FinanceControlDAL.Models.Outlay);
            // 
            // dayDataGridViewTextBoxColumn
            // 
            this.dayDataGridViewTextBoxColumn.DataPropertyName = "Day";
            this.dayDataGridViewTextBoxColumn.HeaderText = "День";
            this.dayDataGridViewTextBoxColumn.Name = "dayDataGridViewTextBoxColumn";
            this.dayDataGridViewTextBoxColumn.ReadOnly = true;
            this.dayDataGridViewTextBoxColumn.Width = 50;
            // 
            // monthDataGridViewTextBoxColumn
            // 
            this.monthDataGridViewTextBoxColumn.DataPropertyName = "Month";
            this.monthDataGridViewTextBoxColumn.HeaderText = "Місяць";
            this.monthDataGridViewTextBoxColumn.Name = "monthDataGridViewTextBoxColumn";
            this.monthDataGridViewTextBoxColumn.ReadOnly = true;
            this.monthDataGridViewTextBoxColumn.Width = 50;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Рік";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.ReadOnly = true;
            this.yearDataGridViewTextBoxColumn.Width = 70;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Коментар";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.ReadOnly = true;
            this.commentDataGridViewTextBoxColumn.Width = 200;
            // 
            // incomeBindingSource
            // 
            this.incomeBindingSource.DataSource = typeof(FinanceControlDAL.Models.Income);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 529);
            this.Controls.Add(this.currMonthLabel);
            this.Controls.Add(this.nextMonthButton);
            this.Controls.Add(this.prevMonthButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.outlayDataGridView);
            this.Controls.Add(this.incomeDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Контроллер фінансів";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.incomeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outlayDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.outlayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView incomeDataGridView;
        private System.Windows.Forms.BindingSource incomeBindingSource;
        private System.Windows.Forms.DataGridView outlayDataGridView;
        private System.Windows.Forms.BindingSource outlayBindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.Button prevMonthButton;
        private System.Windows.Forms.Button nextMonthButton;
        private System.Windows.Forms.Label currMonthLabel;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.ToolStripMenuItem редагуванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem додатиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редагуватиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видалитиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem довідникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem члениСіміToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рахункиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem статистикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поКатегоріяхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дохідToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem витратиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поЧленахСімїToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поКатегоріяхToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem поРахункахToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поКатегоріяхToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem поЧленахСімїToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem інструментиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem конвертерВалютToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem експортБазиДаннихToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
    }
}

