namespace Parser.UI.Parsers
{
    partial class Espacenet
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.tlpAttributes = new System.Windows.Forms.TableLayoutPanel();
            this.tbMPK = new System.Windows.Forms.TextBox();
            this.tbSRS = new System.Windows.Forms.TextBox();
            this.tbInventor = new System.Windows.Forms.TextBox();
            this.tbApplicant = new System.Windows.Forms.TextBox();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.tbDocNum = new System.Windows.Forms.TextBox();
            this.tbApplicationNum = new System.Windows.Forms.TextBox();
            this.tbPublicationNum = new System.Windows.Forms.TextBox();
            this.lblKeysText = new System.Windows.Forms.Label();
            this.tbKeysName = new System.Windows.Forms.TextBox();
            this.lblKeysName = new System.Windows.Forms.Label();
            this.tbKeysText = new System.Windows.Forms.TextBox();
            this.lblPublicationNum = new System.Windows.Forms.Label();
            this.lblApplicationNum = new System.Windows.Forms.Label();
            this.lblDocNum = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblApplicant = new System.Windows.Forms.Label();
            this.lblInventor = new System.Windows.Forms.Label();
            this.lblSRS = new System.Windows.Forms.Label();
            this.lblMPK = new System.Windows.Forms.Label();
            this.tlpDocAmount = new System.Windows.Forms.TableLayoutPanel();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblDocAmount = new System.Windows.Forms.Label();
            this.tbDocAmount = new System.Windows.Forms.TextBox();
            this.tlpParserName.SuspendLayout();
            this.tlpButton.SuspendLayout();
            this.tlpAttributes.SuspendLayout();
            this.tlpDocAmount.SuspendLayout();
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
            this.lblParserName.Text = "Поиск по сайту Espacenet";
            this.lblParserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpButton
            // 
            this.tlpButton.ColumnCount = 2;
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88F));
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tlpButton.Controls.Add(this.btnSearch, 1, 0);
            this.tlpButton.Controls.Add(this.tlpDocAmount, 0, 0);
            this.tlpButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpButton.Location = new System.Drawing.Point(0, 855);
            this.tlpButton.Name = "tlpButton";
            this.tlpButton.RowCount = 1;
            this.tlpButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButton.Size = new System.Drawing.Size(740, 45);
            this.tlpButton.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearch.Location = new System.Drawing.Point(654, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(83, 33);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tlpAttributes
            // 
            this.tlpAttributes.AutoScroll = true;
            this.tlpAttributes.ColumnCount = 2;
            this.tlpAttributes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpAttributes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpAttributes.Controls.Add(this.tbMPK, 1, 9);
            this.tlpAttributes.Controls.Add(this.tbSRS, 1, 8);
            this.tlpAttributes.Controls.Add(this.tbInventor, 1, 7);
            this.tlpAttributes.Controls.Add(this.tbApplicant, 1, 6);
            this.tlpAttributes.Controls.Add(this.tbDate, 1, 5);
            this.tlpAttributes.Controls.Add(this.tbDocNum, 1, 4);
            this.tlpAttributes.Controls.Add(this.tbApplicationNum, 1, 3);
            this.tlpAttributes.Controls.Add(this.tbPublicationNum, 1, 2);
            this.tlpAttributes.Controls.Add(this.lblKeysText, 0, 1);
            this.tlpAttributes.Controls.Add(this.tbKeysName, 1, 0);
            this.tlpAttributes.Controls.Add(this.lblKeysName, 0, 0);
            this.tlpAttributes.Controls.Add(this.tbKeysText, 1, 1);
            this.tlpAttributes.Controls.Add(this.lblPublicationNum, 0, 2);
            this.tlpAttributes.Controls.Add(this.lblApplicationNum, 0, 3);
            this.tlpAttributes.Controls.Add(this.lblDocNum, 0, 4);
            this.tlpAttributes.Controls.Add(this.lblDate, 0, 5);
            this.tlpAttributes.Controls.Add(this.lblApplicant, 0, 6);
            this.tlpAttributes.Controls.Add(this.lblInventor, 0, 7);
            this.tlpAttributes.Controls.Add(this.lblSRS, 0, 8);
            this.tlpAttributes.Controls.Add(this.lblMPK, 0, 9);
            this.tlpAttributes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAttributes.Location = new System.Drawing.Point(0, 40);
            this.tlpAttributes.Name = "tlpAttributes";
            this.tlpAttributes.RowCount = 10;
            this.tlpAttributes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.06018F));
            this.tlpAttributes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.06018F));
            this.tlpAttributes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.121365F));
            this.tlpAttributes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.121365F));
            this.tlpAttributes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.03009F));
            this.tlpAttributes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.121365F));
            this.tlpAttributes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.121365F));
            this.tlpAttributes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.121365F));
            this.tlpAttributes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.121365F));
            this.tlpAttributes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.121365F));
            this.tlpAttributes.Size = new System.Drawing.Size(740, 815);
            this.tlpAttributes.TabIndex = 3;
            // 
            // tbMPK
            // 
            this.tbMPK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMPK.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMPK.Location = new System.Drawing.Point(225, 768);
            this.tbMPK.Name = "tbMPK";
            this.tbMPK.Size = new System.Drawing.Size(512, 33);
            this.tbMPK.TabIndex = 10;
            // 
            // tbSRS
            // 
            this.tbSRS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSRS.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSRS.Location = new System.Drawing.Point(225, 709);
            this.tbSRS.Name = "tbSRS";
            this.tbSRS.Size = new System.Drawing.Size(512, 33);
            this.tbSRS.TabIndex = 9;
            // 
            // tbInventor
            // 
            this.tbInventor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInventor.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbInventor.Location = new System.Drawing.Point(225, 651);
            this.tbInventor.Name = "tbInventor";
            this.tbInventor.Size = new System.Drawing.Size(512, 33);
            this.tbInventor.TabIndex = 8;
            // 
            // tbApplicant
            // 
            this.tbApplicant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbApplicant.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbApplicant.Location = new System.Drawing.Point(225, 593);
            this.tbApplicant.Name = "tbApplicant";
            this.tbApplicant.Size = new System.Drawing.Size(512, 33);
            this.tbApplicant.TabIndex = 7;
            // 
            // tbDate
            // 
            this.tbDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDate.Location = new System.Drawing.Point(225, 535);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(512, 33);
            this.tbDate.TabIndex = 6;
            // 
            // tbDocNum
            // 
            this.tbDocNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDocNum.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDocNum.Location = new System.Drawing.Point(225, 466);
            this.tbDocNum.Name = "tbDocNum";
            this.tbDocNum.Size = new System.Drawing.Size(512, 33);
            this.tbDocNum.TabIndex = 5;
            // 
            // tbApplicationNum
            // 
            this.tbApplicationNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbApplicationNum.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbApplicationNum.Location = new System.Drawing.Point(225, 396);
            this.tbApplicationNum.Name = "tbApplicationNum";
            this.tbApplicationNum.Size = new System.Drawing.Size(512, 33);
            this.tbApplicationNum.TabIndex = 4;
            // 
            // tbPublicationNum
            // 
            this.tbPublicationNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPublicationNum.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPublicationNum.Location = new System.Drawing.Point(225, 338);
            this.tbPublicationNum.Name = "tbPublicationNum";
            this.tbPublicationNum.Size = new System.Drawing.Size(512, 33);
            this.tbPublicationNum.TabIndex = 3;
            // 
            // lblKeysText
            // 
            this.lblKeysText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKeysText.AutoSize = true;
            this.lblKeysText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblKeysText.Location = new System.Drawing.Point(0, 163);
            this.lblKeysText.Margin = new System.Windows.Forms.Padding(0);
            this.lblKeysText.Name = "lblKeysText";
            this.lblKeysText.Size = new System.Drawing.Size(222, 163);
            this.lblKeysText.TabIndex = 2;
            this.lblKeysText.Text = "Ключевые слова в названии изобретения или реферате:";
            // 
            // tbKeysName
            // 
            this.tbKeysName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbKeysName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbKeysName.Location = new System.Drawing.Point(225, 3);
            this.tbKeysName.Multiline = true;
            this.tbKeysName.Name = "tbKeysName";
            this.tbKeysName.Size = new System.Drawing.Size(512, 157);
            this.tbKeysName.TabIndex = 0;
            // 
            // lblKeysName
            // 
            this.lblKeysName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKeysName.BackColor = System.Drawing.SystemColors.Control;
            this.lblKeysName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblKeysName.Location = new System.Drawing.Point(3, 0);
            this.lblKeysName.Name = "lblKeysName";
            this.lblKeysName.Size = new System.Drawing.Size(216, 163);
            this.lblKeysName.TabIndex = 1;
            this.lblKeysName.Text = "Ключевые слова в названии:";
            // 
            // tbKeysText
            // 
            this.tbKeysText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbKeysText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbKeysText.Location = new System.Drawing.Point(225, 166);
            this.tbKeysText.Multiline = true;
            this.tbKeysText.Name = "tbKeysText";
            this.tbKeysText.Size = new System.Drawing.Size(512, 157);
            this.tbKeysText.TabIndex = 1;
            // 
            // lblPublicationNum
            // 
            this.lblPublicationNum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPublicationNum.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPublicationNum.Location = new System.Drawing.Point(3, 326);
            this.lblPublicationNum.Name = "lblPublicationNum";
            this.lblPublicationNum.Size = new System.Drawing.Size(216, 58);
            this.lblPublicationNum.TabIndex = 4;
            this.lblPublicationNum.Text = "Номер публикации:";
            this.lblPublicationNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblApplicationNum
            // 
            this.lblApplicationNum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApplicationNum.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblApplicationNum.Location = new System.Drawing.Point(3, 384);
            this.lblApplicationNum.Name = "lblApplicationNum";
            this.lblApplicationNum.Size = new System.Drawing.Size(216, 58);
            this.lblApplicationNum.TabIndex = 5;
            this.lblApplicationNum.Text = "Номер заявки:";
            this.lblApplicationNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDocNum
            // 
            this.lblDocNum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDocNum.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDocNum.Location = new System.Drawing.Point(3, 442);
            this.lblDocNum.Name = "lblDocNum";
            this.lblDocNum.Size = new System.Drawing.Size(216, 81);
            this.lblDocNum.TabIndex = 6;
            this.lblDocNum.Text = "Номер приоритетного/связанного документа:";
            this.lblDocNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDate.Location = new System.Drawing.Point(3, 523);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(216, 58);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "Дата публикации:";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblApplicant
            // 
            this.lblApplicant.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApplicant.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblApplicant.Location = new System.Drawing.Point(3, 581);
            this.lblApplicant.Name = "lblApplicant";
            this.lblApplicant.Size = new System.Drawing.Size(216, 58);
            this.lblApplicant.TabIndex = 8;
            this.lblApplicant.Text = "Заявитель(и):";
            this.lblApplicant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblInventor
            // 
            this.lblInventor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInventor.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInventor.Location = new System.Drawing.Point(3, 639);
            this.lblInventor.Name = "lblInventor";
            this.lblInventor.Size = new System.Drawing.Size(216, 58);
            this.lblInventor.TabIndex = 9;
            this.lblInventor.Text = "Изобретатель(и):";
            this.lblInventor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSRS
            // 
            this.lblSRS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSRS.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSRS.Location = new System.Drawing.Point(3, 697);
            this.lblSRS.Name = "lblSRS";
            this.lblSRS.Size = new System.Drawing.Size(216, 58);
            this.lblSRS.TabIndex = 10;
            this.lblSRS.Text = "CPC";
            this.lblSRS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMPK
            // 
            this.lblMPK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMPK.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMPK.Location = new System.Drawing.Point(3, 755);
            this.lblMPK.Name = "lblMPK";
            this.lblMPK.Size = new System.Drawing.Size(216, 60);
            this.lblMPK.TabIndex = 11;
            this.lblMPK.Text = "МПК";
            this.lblMPK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpDocAmount
            // 
            this.tlpDocAmount.ColumnCount = 3;
            this.tlpDocAmount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.95349F));
            this.tlpDocAmount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.12403F));
            this.tlpDocAmount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.92248F));
            this.tlpDocAmount.Controls.Add(this.tbDocAmount, 0, 0);
            this.tlpDocAmount.Controls.Add(this.lblDocAmount, 0, 0);
            this.tlpDocAmount.Controls.Add(this.btnClear, 2, 0);
            this.tlpDocAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDocAmount.Location = new System.Drawing.Point(3, 3);
            this.tlpDocAmount.Name = "tlpDocAmount";
            this.tlpDocAmount.RowCount = 1;
            this.tlpDocAmount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDocAmount.Size = new System.Drawing.Size(645, 39);
            this.tlpDocAmount.TabIndex = 23;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.Location = new System.Drawing.Point(455, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(187, 33);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "Очистить форму";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblDocAmount
            // 
            this.lblDocAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDocAmount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDocAmount.Location = new System.Drawing.Point(3, 0);
            this.lblDocAmount.Name = "lblDocAmount";
            this.lblDocAmount.Size = new System.Drawing.Size(213, 39);
            this.lblDocAmount.TabIndex = 24;
            this.lblDocAmount.Text = "Количество документов:";
            this.lblDocAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbDocAmount
            // 
            this.tbDocAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDocAmount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDocAmount.Location = new System.Drawing.Point(222, 3);
            this.tbDocAmount.Name = "tbDocAmount";
            this.tbDocAmount.Size = new System.Drawing.Size(227, 33);
            this.tbDocAmount.TabIndex = 25;
            // 
            // Espacenet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 900);
            this.Controls.Add(this.tlpAttributes);
            this.Controls.Add(this.tlpButton);
            this.Controls.Add(this.tlpParserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Espacenet";
            this.Text = "Espacenet";
            this.tlpParserName.ResumeLayout(false);
            this.tlpParserName.PerformLayout();
            this.tlpButton.ResumeLayout(false);
            this.tlpAttributes.ResumeLayout(false);
            this.tlpAttributes.PerformLayout();
            this.tlpDocAmount.ResumeLayout(false);
            this.tlpDocAmount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpParserName;
        private System.Windows.Forms.Label lblParserName;
        private System.Windows.Forms.TableLayoutPanel tlpButton;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TableLayoutPanel tlpAttributes;
        private System.Windows.Forms.TextBox tbMPK;
        private System.Windows.Forms.TextBox tbSRS;
        private System.Windows.Forms.TextBox tbInventor;
        private System.Windows.Forms.TextBox tbApplicant;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.TextBox tbDocNum;
        private System.Windows.Forms.TextBox tbApplicationNum;
        private System.Windows.Forms.TextBox tbPublicationNum;
        private System.Windows.Forms.Label lblKeysText;
        private System.Windows.Forms.TextBox tbKeysName;
        private System.Windows.Forms.Label lblKeysName;
        private System.Windows.Forms.TextBox tbKeysText;
        private System.Windows.Forms.Label lblPublicationNum;
        private System.Windows.Forms.Label lblApplicationNum;
        private System.Windows.Forms.Label lblDocNum;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblApplicant;
        private System.Windows.Forms.Label lblInventor;
        private System.Windows.Forms.Label lblSRS;
        private System.Windows.Forms.Label lblMPK;
        private System.Windows.Forms.TableLayoutPanel tlpDocAmount;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblDocAmount;
        private System.Windows.Forms.TextBox tbDocAmount;
    }
}