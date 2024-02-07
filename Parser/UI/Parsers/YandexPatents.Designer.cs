namespace Parser.UI.Parsers
{
    partial class YandexPatents
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
            this.tlpParserName = new System.Windows.Forms.TableLayoutPanel();
            this.lblParserName = new System.Windows.Forms.Label();
            this.tlpButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tlpAttributes = new System.Windows.Forms.TableLayoutPanel();
            this.lblApplicationNum = new System.Windows.Forms.Label();
            this.tlbDate = new System.Windows.Forms.TableLayoutPanel();
            this.mtbEnd = new System.Windows.Forms.MaskedTextBox();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.mtbStart = new System.Windows.Forms.MaskedTextBox();
            this.tbPatentee = new System.Windows.Forms.TextBox();
            this.tbAuthor = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbApplication = new System.Windows.Forms.TextBox();
            this.lblDocument = new System.Windows.Forms.Label();
            this.tbKeysName = new System.Windows.Forms.TextBox();
            this.lblKeys = new System.Windows.Forms.Label();
            this.tbDocument = new System.Windows.Forms.TextBox();
            this.lblApplication = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblPatentee = new System.Windows.Forms.Label();
            this.cbDate = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.tlpType = new System.Windows.Forms.TableLayoutPanel();
            this.chbPatent = new System.Windows.Forms.CheckBox();
            this.chbApplication = new System.Windows.Forms.CheckBox();
            this.tlpParserName.SuspendLayout();
            this.tlpButton.SuspendLayout();
            this.tlpAttributes.SuspendLayout();
            this.tlbDate.SuspendLayout();
            this.tlpType.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpParserName
            // 
            this.tlpParserName.ColumnCount = 1;
            this.tlpParserName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpParserName.Controls.Add(this.lblParserName, 0, 0);
            this.tlpParserName.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpParserName.Location = new System.Drawing.Point(0, 0);
            this.tlpParserName.Name = "tlpParserName";
            this.tlpParserName.RowCount = 1;
            this.tlpParserName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpParserName.Size = new System.Drawing.Size(740, 40);
            this.tlpParserName.TabIndex = 1;
            // 
            // lblParserName
            // 
            this.lblParserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblParserName.AutoSize = true;
            this.lblParserName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblParserName.Location = new System.Drawing.Point(3, 0);
            this.lblParserName.Name = "lblParserName";
            this.lblParserName.Size = new System.Drawing.Size(734, 37);
            this.lblParserName.TabIndex = 1;
            this.lblParserName.Text = "Поиск по сайту Яндекс.Патенты";
            this.lblParserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpButton
            // 
            this.tlpButton.ColumnCount = 2;
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88F));
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tlpButton.Controls.Add(this.btnClear, 0, 0);
            this.tlpButton.Controls.Add(this.btnSearch, 1, 0);
            this.tlpButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpButton.Location = new System.Drawing.Point(0, 855);
            this.tlpButton.Name = "tlpButton";
            this.tlpButton.RowCount = 1;
            this.tlpButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButton.Size = new System.Drawing.Size(740, 45);
            this.tlpButton.TabIndex = 2;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.Location = new System.Drawing.Point(488, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(160, 39);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Очистить форму";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearch.Location = new System.Drawing.Point(657, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 39);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // tlpAttributes
            // 
            this.tlpAttributes.AutoScroll = true;
            this.tlpAttributes.ColumnCount = 2;
            this.tlpAttributes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpAttributes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpAttributes.Controls.Add(this.lblApplicationNum, 0, 3);
            this.tlpAttributes.Controls.Add(this.tlbDate, 1, 4);
            this.tlpAttributes.Controls.Add(this.tbPatentee, 1, 7);
            this.tlpAttributes.Controls.Add(this.tbAuthor, 1, 6);
            this.tlpAttributes.Controls.Add(this.tbName, 1, 5);
            this.tlpAttributes.Controls.Add(this.tbApplication, 1, 2);
            this.tlpAttributes.Controls.Add(this.lblDocument, 0, 1);
            this.tlpAttributes.Controls.Add(this.tbKeysName, 1, 0);
            this.tlpAttributes.Controls.Add(this.lblKeys, 0, 0);
            this.tlpAttributes.Controls.Add(this.tbDocument, 1, 1);
            this.tlpAttributes.Controls.Add(this.lblApplication, 0, 2);
            this.tlpAttributes.Controls.Add(this.lblName, 0, 5);
            this.tlpAttributes.Controls.Add(this.lblAuthor, 0, 6);
            this.tlpAttributes.Controls.Add(this.lblPatentee, 0, 7);
            this.tlpAttributes.Controls.Add(this.cbDate, 1, 3);
            this.tlpAttributes.Controls.Add(this.lblType, 0, 9);
            this.tlpAttributes.Controls.Add(this.tlpType, 1, 9);
            this.tlpAttributes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAttributes.Location = new System.Drawing.Point(0, 40);
            this.tlpAttributes.Name = "tlpAttributes";
            this.tlpAttributes.RowCount = 10;
            this.tlpAttributes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.45589F));
            this.tlpAttributes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.043854F));
            this.tlpAttributes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.535937F));
            this.tlpAttributes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.030675F));
            this.tlpAttributes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.92025F));
            this.tlpAttributes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.153374F));
            this.tlpAttributes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.030675F));
            this.tlpAttributes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.785276F));
            this.tlpAttributes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.14724F));
            this.tlpAttributes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.815951F));
            this.tlpAttributes.Size = new System.Drawing.Size(740, 815);
            this.tlpAttributes.TabIndex = 4;
            // 
            // lblApplicationNum
            // 
            this.lblApplicationNum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApplicationNum.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblApplicationNum.Location = new System.Drawing.Point(3, 220);
            this.lblApplicationNum.Name = "lblApplicationNum";
            this.lblApplicationNum.Size = new System.Drawing.Size(142, 41);
            this.lblApplicationNum.TabIndex = 18;
            this.lblApplicationNum.Text = "Даты:";
            this.lblApplicationNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlbDate
            // 
            this.tlbDate.ColumnCount = 2;
            this.tlbDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tlbDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91F));
            this.tlbDate.Controls.Add(this.mtbEnd, 1, 1);
            this.tlbDate.Controls.Add(this.lblStart, 0, 0);
            this.tlbDate.Controls.Add(this.lblEnd, 0, 1);
            this.tlbDate.Controls.Add(this.mtbStart, 1, 0);
            this.tlbDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlbDate.Location = new System.Drawing.Point(151, 264);
            this.tlbDate.Name = "tlbDate";
            this.tlbDate.RowCount = 2;
            this.tlbDate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlbDate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlbDate.Size = new System.Drawing.Size(586, 83);
            this.tlbDate.TabIndex = 15;
            // 
            // mtbEnd
            // 
            this.mtbEnd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mtbEnd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mtbEnd.Location = new System.Drawing.Point(55, 45);
            this.mtbEnd.Mask = "0000.00.00";
            this.mtbEnd.Name = "mtbEnd";
            this.mtbEnd.Size = new System.Drawing.Size(90, 33);
            this.mtbEnd.TabIndex = 3;
            this.mtbEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblStart
            // 
            this.lblStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStart.Location = new System.Drawing.Point(3, 8);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(46, 25);
            this.lblStart.TabIndex = 0;
            this.lblStart.Text = "С:";
            this.lblStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEnd
            // 
            this.lblEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEnd.Location = new System.Drawing.Point(3, 49);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(46, 25);
            this.lblEnd.TabIndex = 1;
            this.lblEnd.Text = "По:";
            this.lblEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mtbStart
            // 
            this.mtbStart.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mtbStart.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mtbStart.Location = new System.Drawing.Point(55, 4);
            this.mtbStart.Mask = "0000.00.00";
            this.mtbStart.Name = "mtbStart";
            this.mtbStart.Size = new System.Drawing.Size(90, 33);
            this.mtbStart.TabIndex = 2;
            this.mtbStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPatentee
            // 
            this.tbPatentee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPatentee.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPatentee.Location = new System.Drawing.Point(151, 436);
            this.tbPatentee.Name = "tbPatentee";
            this.tbPatentee.Size = new System.Drawing.Size(586, 33);
            this.tbPatentee.TabIndex = 8;
            // 
            // tbAuthor
            // 
            this.tbAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAuthor.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAuthor.Location = new System.Drawing.Point(151, 396);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.Size = new System.Drawing.Size(586, 33);
            this.tbAuthor.TabIndex = 7;
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbName.Location = new System.Drawing.Point(151, 354);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(586, 33);
            this.tbName.TabIndex = 6;
            // 
            // tbApplication
            // 
            this.tbApplication.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbApplication.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbApplication.Location = new System.Drawing.Point(151, 181);
            this.tbApplication.Name = "tbApplication";
            this.tbApplication.Size = new System.Drawing.Size(586, 33);
            this.tbApplication.TabIndex = 3;
            // 
            // lblDocument
            // 
            this.lblDocument.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDocument.AutoSize = true;
            this.lblDocument.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDocument.Location = new System.Drawing.Point(0, 134);
            this.lblDocument.Margin = new System.Windows.Forms.Padding(0);
            this.lblDocument.Name = "lblDocument";
            this.lblDocument.Size = new System.Drawing.Size(148, 41);
            this.lblDocument.TabIndex = 2;
            this.lblDocument.Text = "Документ:";
            // 
            // tbKeysName
            // 
            this.tbKeysName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbKeysName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbKeysName.Location = new System.Drawing.Point(151, 3);
            this.tbKeysName.Multiline = true;
            this.tbKeysName.Name = "tbKeysName";
            this.tbKeysName.Size = new System.Drawing.Size(586, 128);
            this.tbKeysName.TabIndex = 0;
            // 
            // lblKeys
            // 
            this.lblKeys.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKeys.BackColor = System.Drawing.SystemColors.Control;
            this.lblKeys.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblKeys.Location = new System.Drawing.Point(3, 0);
            this.lblKeys.Name = "lblKeys";
            this.lblKeys.Size = new System.Drawing.Size(142, 134);
            this.lblKeys.TabIndex = 1;
            this.lblKeys.Text = "Ключевые слова:";
            // 
            // tbDocument
            // 
            this.tbDocument.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDocument.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDocument.Location = new System.Drawing.Point(151, 137);
            this.tbDocument.Name = "tbDocument";
            this.tbDocument.Size = new System.Drawing.Size(586, 33);
            this.tbDocument.TabIndex = 1;
            // 
            // lblApplication
            // 
            this.lblApplication.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApplication.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblApplication.Location = new System.Drawing.Point(3, 175);
            this.lblApplication.Name = "lblApplication";
            this.lblApplication.Size = new System.Drawing.Size(142, 45);
            this.lblApplication.TabIndex = 4;
            this.lblApplication.Text = "Заявка:";
            this.lblApplication.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(3, 350);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(142, 42);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Название:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAuthor
            // 
            this.lblAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAuthor.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAuthor.Location = new System.Drawing.Point(3, 392);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(142, 41);
            this.lblAuthor.TabIndex = 8;
            this.lblAuthor.Text = "Авторы:";
            this.lblAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPatentee
            // 
            this.lblPatentee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPatentee.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPatentee.Location = new System.Drawing.Point(3, 433);
            this.lblPatentee.Name = "lblPatentee";
            this.lblPatentee.Size = new System.Drawing.Size(142, 39);
            this.lblPatentee.TabIndex = 9;
            this.lblPatentee.Text = "Патентообладатели:";
            this.lblPatentee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbDate
            // 
            this.cbDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbDate.FormattingEnabled = true;
            this.cbDate.Items.AddRange(new object[] {
            "Подача заявки",
            "Публикация документа",
            "Публикация заявки",
            "Начало действия патента"});
            this.cbDate.Location = new System.Drawing.Point(151, 224);
            this.cbDate.Name = "cbDate";
            this.cbDate.Size = new System.Drawing.Size(586, 33);
            this.cbDate.TabIndex = 16;
            // 
            // lblType
            // 
            this.lblType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblType.Location = new System.Drawing.Point(3, 734);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(142, 81);
            this.lblType.TabIndex = 8;
            this.lblType.Text = "Тип:";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpType
            // 
            this.tlpType.ColumnCount = 2;
            this.tlpType.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.06485F));
            this.tlpType.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.93515F));
            this.tlpType.Controls.Add(this.chbPatent, 1, 0);
            this.tlpType.Controls.Add(this.chbApplication, 0, 0);
            this.tlpType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpType.Location = new System.Drawing.Point(151, 737);
            this.tlpType.Name = "tlpType";
            this.tlpType.RowCount = 1;
            this.tlpType.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpType.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tlpType.Size = new System.Drawing.Size(586, 75);
            this.tlpType.TabIndex = 17;
            // 
            // chbPatent
            // 
            this.chbPatent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chbPatent.AutoSize = true;
            this.chbPatent.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbPatent.Location = new System.Drawing.Point(103, 23);
            this.chbPatent.Name = "chbPatent";
            this.chbPatent.Size = new System.Drawing.Size(480, 29);
            this.chbPatent.TabIndex = 1;
            this.chbPatent.Text = "Патент";
            this.chbPatent.UseVisualStyleBackColor = true;
            // 
            // chbApplication
            // 
            this.chbApplication.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chbApplication.AutoSize = true;
            this.chbApplication.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbApplication.Location = new System.Drawing.Point(3, 23);
            this.chbApplication.Name = "chbApplication";
            this.chbApplication.Size = new System.Drawing.Size(94, 29);
            this.chbApplication.TabIndex = 0;
            this.chbApplication.Text = "Заявка";
            this.chbApplication.UseVisualStyleBackColor = true;
            // 
            // YandexPatents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 900);
            this.Controls.Add(this.tlpAttributes);
            this.Controls.Add(this.tlpButton);
            this.Controls.Add(this.tlpParserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "YandexPatents";
            this.Text = "YandexPatents";
            this.Load += new System.EventHandler(this.YandexPatents_Load);
            this.tlpParserName.ResumeLayout(false);
            this.tlpParserName.PerformLayout();
            this.tlpButton.ResumeLayout(false);
            this.tlpAttributes.ResumeLayout(false);
            this.tlpAttributes.PerformLayout();
            this.tlbDate.ResumeLayout(false);
            this.tlbDate.PerformLayout();
            this.tlpType.ResumeLayout(false);
            this.tlpType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpParserName;
        private System.Windows.Forms.Label lblParserName;
        private System.Windows.Forms.TableLayoutPanel tlpButton;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TableLayoutPanel tlpAttributes;
        private System.Windows.Forms.TableLayoutPanel tlbDate;
        private System.Windows.Forms.MaskedTextBox mtbEnd;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.MaskedTextBox mtbStart;
        private System.Windows.Forms.TextBox tbPatentee;
        private System.Windows.Forms.TextBox tbAuthor;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbApplication;
        private System.Windows.Forms.Label lblDocument;
        private System.Windows.Forms.TextBox tbKeysName;
        private System.Windows.Forms.Label lblKeys;
        private System.Windows.Forms.TextBox tbDocument;
        private System.Windows.Forms.Label lblApplication;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblPatentee;
        private System.Windows.Forms.ComboBox cbDate;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TableLayoutPanel tlpType;
        private System.Windows.Forms.CheckBox chbPatent;
        private System.Windows.Forms.CheckBox chbApplication;
        private System.Windows.Forms.Label lblApplicationNum;
    }
}