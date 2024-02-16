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
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDocument = new System.Windows.Forms.Label();
            this.lblKeys = new System.Windows.Forms.Label();
            this.lblApplication = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblPatentee = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.kryptonPanelBackground = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.panelBorder = new System.Windows.Forms.Panel();
            this.kryptonPanelMain = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.tableLayoutPanelCenter = new System.Windows.Forms.TableLayoutPanel();
            this.tlbDate = new System.Windows.Forms.TableLayoutPanel();
            this.mtbEnd = new ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.mtbStart = new ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox();
            this.tbPatentee = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tbAuthor = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tbName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tbApplication = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tbDocument = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tbKeys = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.cbDate = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanelBottom = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelDocAmount = new System.Windows.Forms.TableLayoutPanel();
            this.tbDocAmount = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblDocAmount = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tableLayoutPanelTop = new System.Windows.Forms.TableLayoutPanel();
            this.panelUnderline = new System.Windows.Forms.Panel();
            this.lblParserName = new System.Windows.Forms.Label();
            this.chbApplication = new System.Windows.Forms.CheckBox();
            this.chbPatent = new System.Windows.Forms.CheckBox();
            this.tlpType = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelBackground)).BeginInit();
            this.kryptonPanelBackground.SuspendLayout();
            this.panelBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelMain)).BeginInit();
            this.kryptonPanelMain.SuspendLayout();
            this.tableLayoutPanelCenter.SuspendLayout();
            this.tlbDate.SuspendLayout();
            this.tableLayoutPanelBottom.SuspendLayout();
            this.tableLayoutPanelDocAmount.SuspendLayout();
            this.tableLayoutPanelTop.SuspendLayout();
            this.tlpType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(8, 152);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(234, 44);
            this.lblDate.TabIndex = 18;
            this.lblDate.Text = "Даты:";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDocument
            // 
            this.lblDocument.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDocument.AutoSize = true;
            this.lblDocument.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDocument.ForeColor = System.Drawing.Color.White;
            this.lblDocument.Location = new System.Drawing.Point(8, 64);
            this.lblDocument.Name = "lblDocument";
            this.lblDocument.Size = new System.Drawing.Size(234, 44);
            this.lblDocument.TabIndex = 2;
            this.lblDocument.Text = "Документ:";
            this.lblDocument.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblKeys
            // 
            this.lblKeys.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKeys.BackColor = System.Drawing.Color.Transparent;
            this.lblKeys.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblKeys.ForeColor = System.Drawing.Color.White;
            this.lblKeys.Location = new System.Drawing.Point(8, 20);
            this.lblKeys.Name = "lblKeys";
            this.lblKeys.Size = new System.Drawing.Size(234, 44);
            this.lblKeys.TabIndex = 1;
            this.lblKeys.Text = "Ключевые слова:";
            this.lblKeys.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblApplication
            // 
            this.lblApplication.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApplication.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblApplication.ForeColor = System.Drawing.Color.White;
            this.lblApplication.Location = new System.Drawing.Point(8, 108);
            this.lblApplication.Name = "lblApplication";
            this.lblApplication.Size = new System.Drawing.Size(234, 44);
            this.lblApplication.TabIndex = 4;
            this.lblApplication.Text = "Заявка:";
            this.lblApplication.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(8, 291);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(234, 44);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Название:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAuthor
            // 
            this.lblAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAuthor.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAuthor.ForeColor = System.Drawing.Color.White;
            this.lblAuthor.Location = new System.Drawing.Point(8, 335);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(234, 44);
            this.lblAuthor.TabIndex = 8;
            this.lblAuthor.Text = "Авторы:";
            this.lblAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPatentee
            // 
            this.lblPatentee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPatentee.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPatentee.ForeColor = System.Drawing.Color.White;
            this.lblPatentee.Location = new System.Drawing.Point(8, 379);
            this.lblPatentee.Name = "lblPatentee";
            this.lblPatentee.Size = new System.Drawing.Size(234, 44);
            this.lblPatentee.TabIndex = 9;
            this.lblPatentee.Text = "Патентообладатели:";
            this.lblPatentee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblType
            // 
            this.lblType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblType.ForeColor = System.Drawing.Color.White;
            this.lblType.Location = new System.Drawing.Point(8, 423);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(234, 59);
            this.lblType.TabIndex = 8;
            this.lblType.Text = "Тип:";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // kryptonPanelBackground
            // 
            this.kryptonPanelBackground.Controls.Add(this.panelBorder);
            this.kryptonPanelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanelBackground.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanelBackground.Name = "kryptonPanelBackground";
            this.kryptonPanelBackground.Padding = new System.Windows.Forms.Padding(10, 15, 10, 15);
            this.kryptonPanelBackground.Size = new System.Drawing.Size(740, 900);
            this.kryptonPanelBackground.StateNormal.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.kryptonPanelBackground.StateNormal.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.kryptonPanelBackground.StateNormal.ColorAngle = 25F;
            this.kryptonPanelBackground.StateNormal.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.ExpertSquareHighlight2;
            this.kryptonPanelBackground.TabIndex = 30;
            // 
            // panelBorder
            // 
            this.panelBorder.BackColor = System.Drawing.Color.White;
            this.panelBorder.Controls.Add(this.kryptonPanelMain);
            this.panelBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBorder.Location = new System.Drawing.Point(10, 15);
            this.panelBorder.Name = "panelBorder";
            this.panelBorder.Padding = new System.Windows.Forms.Padding(1);
            this.panelBorder.Size = new System.Drawing.Size(720, 870);
            this.panelBorder.TabIndex = 5;
            // 
            // kryptonPanelMain
            // 
            this.kryptonPanelMain.Controls.Add(this.tableLayoutPanelCenter);
            this.kryptonPanelMain.Controls.Add(this.tableLayoutPanelBottom);
            this.kryptonPanelMain.Controls.Add(this.tableLayoutPanelTop);
            this.kryptonPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanelMain.Location = new System.Drawing.Point(1, 1);
            this.kryptonPanelMain.Name = "kryptonPanelMain";
            this.kryptonPanelMain.Padding = new System.Windows.Forms.Padding(10);
            this.kryptonPanelMain.Size = new System.Drawing.Size(718, 868);
            this.kryptonPanelMain.StateNormal.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.kryptonPanelMain.StateNormal.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.kryptonPanelMain.StateNormal.ColorAngle = 30F;
            this.kryptonPanelMain.StateNormal.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Sigma;
            this.kryptonPanelMain.TabIndex = 4;
            // 
            // tableLayoutPanelCenter
            // 
            this.tableLayoutPanelCenter.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanelCenter.ColumnCount = 2;
            this.tableLayoutPanelCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanelCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanelCenter.Controls.Add(this.tlbDate, 1, 4);
            this.tableLayoutPanelCenter.Controls.Add(this.lblDate, 0, 3);
            this.tableLayoutPanelCenter.Controls.Add(this.tbPatentee, 1, 7);
            this.tableLayoutPanelCenter.Controls.Add(this.tbAuthor, 1, 6);
            this.tableLayoutPanelCenter.Controls.Add(this.lblKeys, 0, 0);
            this.tableLayoutPanelCenter.Controls.Add(this.tbName, 1, 5);
            this.tableLayoutPanelCenter.Controls.Add(this.lblDocument, 0, 1);
            this.tableLayoutPanelCenter.Controls.Add(this.lblPatentee, 0, 7);
            this.tableLayoutPanelCenter.Controls.Add(this.lblAuthor, 0, 6);
            this.tableLayoutPanelCenter.Controls.Add(this.lblName, 0, 5);
            this.tableLayoutPanelCenter.Controls.Add(this.lblApplication, 0, 2);
            this.tableLayoutPanelCenter.Controls.Add(this.tbApplication, 1, 2);
            this.tableLayoutPanelCenter.Controls.Add(this.tbDocument, 1, 1);
            this.tableLayoutPanelCenter.Controls.Add(this.tbKeys, 1, 0);
            this.tableLayoutPanelCenter.Controls.Add(this.cbDate, 1, 3);
            this.tableLayoutPanelCenter.Controls.Add(this.lblType, 0, 8);
            this.tableLayoutPanelCenter.Controls.Add(this.tlpType, 1, 8);
            this.tableLayoutPanelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelCenter.Location = new System.Drawing.Point(10, 50);
            this.tableLayoutPanelCenter.Name = "tableLayoutPanelCenter";
            this.tableLayoutPanelCenter.Padding = new System.Windows.Forms.Padding(5, 20, 5, 0);
            this.tableLayoutPanelCenter.RowCount = 10;
            this.tableLayoutPanelCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanelCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanelCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanelCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanelCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tableLayoutPanelCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanelCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanelCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanelCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanelCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37F));
            this.tableLayoutPanelCenter.Size = new System.Drawing.Size(698, 758);
            this.tableLayoutPanelCenter.TabIndex = 3;
            // 
            // tlbDate
            // 
            this.tlbDate.ColumnCount = 2;
            this.tlbDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.tlbDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89F));
            this.tlbDate.Controls.Add(this.mtbEnd, 1, 1);
            this.tlbDate.Controls.Add(this.lblStart, 0, 0);
            this.tlbDate.Controls.Add(this.lblEnd, 0, 1);
            this.tlbDate.Controls.Add(this.mtbStart, 1, 0);
            this.tlbDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlbDate.Location = new System.Drawing.Point(248, 199);
            this.tlbDate.Name = "tlbDate";
            this.tlbDate.RowCount = 2;
            this.tlbDate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlbDate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlbDate.Size = new System.Drawing.Size(442, 89);
            this.tlbDate.TabIndex = 20;
            // 
            // mtbEnd
            // 
            this.mtbEnd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mtbEnd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mtbEnd.Location = new System.Drawing.Point(51, 52);
            this.mtbEnd.Mask = "0000.00.00";
            this.mtbEnd.Name = "mtbEnd";
            this.mtbEnd.Size = new System.Drawing.Size(70, 28);
            this.mtbEnd.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(129)))), ((int)(((byte)(237)))));
            this.mtbEnd.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(129)))), ((int)(((byte)(237)))));
            this.mtbEnd.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.mtbEnd.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.mtbEnd.StateCommon.Border.Rounding = 5;
            this.mtbEnd.StateCommon.Border.Width = 1;
            this.mtbEnd.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.mtbEnd.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mtbEnd.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.mtbEnd.TabIndex = 6;
            this.mtbEnd.Text = "    ,  ,";
            // 
            // lblStart
            // 
            this.lblStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStart.ForeColor = System.Drawing.Color.White;
            this.lblStart.Location = new System.Drawing.Point(3, 10);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(42, 23);
            this.lblStart.TabIndex = 0;
            this.lblStart.Text = "С:";
            this.lblStart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEnd
            // 
            this.lblEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEnd.ForeColor = System.Drawing.Color.White;
            this.lblEnd.Location = new System.Drawing.Point(3, 55);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(42, 23);
            this.lblEnd.TabIndex = 1;
            this.lblEnd.Text = "По:";
            this.lblEnd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mtbStart
            // 
            this.mtbStart.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mtbStart.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mtbStart.Location = new System.Drawing.Point(51, 8);
            this.mtbStart.Mask = "0000.00.00";
            this.mtbStart.Name = "mtbStart";
            this.mtbStart.Size = new System.Drawing.Size(70, 28);
            this.mtbStart.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(129)))), ((int)(((byte)(237)))));
            this.mtbStart.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(129)))), ((int)(((byte)(237)))));
            this.mtbStart.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.mtbStart.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.mtbStart.StateCommon.Border.Rounding = 5;
            this.mtbStart.StateCommon.Border.Width = 1;
            this.mtbStart.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.mtbStart.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mtbStart.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.mtbStart.TabIndex = 5;
            this.mtbStart.Text = "    ,  ,";
            // 
            // tbPatentee
            // 
            this.tbPatentee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPatentee.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPatentee.Location = new System.Drawing.Point(248, 387);
            this.tbPatentee.Name = "tbPatentee";
            this.tbPatentee.Size = new System.Drawing.Size(442, 28);
            this.tbPatentee.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(129)))), ((int)(((byte)(237)))));
            this.tbPatentee.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(129)))), ((int)(((byte)(237)))));
            this.tbPatentee.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbPatentee.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.tbPatentee.StateCommon.Border.Rounding = 5;
            this.tbPatentee.StateCommon.Border.Width = 1;
            this.tbPatentee.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.tbPatentee.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbPatentee.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tbPatentee.TabIndex = 9;
            // 
            // tbAuthor
            // 
            this.tbAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAuthor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAuthor.Location = new System.Drawing.Point(248, 343);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.Size = new System.Drawing.Size(442, 28);
            this.tbAuthor.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(129)))), ((int)(((byte)(237)))));
            this.tbAuthor.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(129)))), ((int)(((byte)(237)))));
            this.tbAuthor.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbAuthor.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.tbAuthor.StateCommon.Border.Rounding = 5;
            this.tbAuthor.StateCommon.Border.Width = 1;
            this.tbAuthor.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.tbAuthor.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbAuthor.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tbAuthor.TabIndex = 8;
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbName.Location = new System.Drawing.Point(248, 299);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(442, 28);
            this.tbName.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(129)))), ((int)(((byte)(237)))));
            this.tbName.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(129)))), ((int)(((byte)(237)))));
            this.tbName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbName.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.tbName.StateCommon.Border.Rounding = 5;
            this.tbName.StateCommon.Border.Width = 1;
            this.tbName.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.tbName.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbName.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tbName.TabIndex = 7;
            // 
            // tbApplication
            // 
            this.tbApplication.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbApplication.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbApplication.Location = new System.Drawing.Point(248, 116);
            this.tbApplication.Name = "tbApplication";
            this.tbApplication.Size = new System.Drawing.Size(442, 28);
            this.tbApplication.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(129)))), ((int)(((byte)(237)))));
            this.tbApplication.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(129)))), ((int)(((byte)(237)))));
            this.tbApplication.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbApplication.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.tbApplication.StateCommon.Border.Rounding = 5;
            this.tbApplication.StateCommon.Border.Width = 1;
            this.tbApplication.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.tbApplication.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbApplication.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tbApplication.TabIndex = 3;
            // 
            // tbDocument
            // 
            this.tbDocument.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDocument.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbDocument.Location = new System.Drawing.Point(248, 72);
            this.tbDocument.Name = "tbDocument";
            this.tbDocument.Size = new System.Drawing.Size(442, 28);
            this.tbDocument.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(129)))), ((int)(((byte)(237)))));
            this.tbDocument.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(129)))), ((int)(((byte)(237)))));
            this.tbDocument.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbDocument.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.tbDocument.StateCommon.Border.Rounding = 5;
            this.tbDocument.StateCommon.Border.Width = 1;
            this.tbDocument.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.tbDocument.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbDocument.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tbDocument.TabIndex = 2;
            // 
            // tbKeys
            // 
            this.tbKeys.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbKeys.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbKeys.Location = new System.Drawing.Point(248, 28);
            this.tbKeys.Name = "tbKeys";
            this.tbKeys.Size = new System.Drawing.Size(442, 28);
            this.tbKeys.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(129)))), ((int)(((byte)(237)))));
            this.tbKeys.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(129)))), ((int)(((byte)(237)))));
            this.tbKeys.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbKeys.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.tbKeys.StateCommon.Border.Rounding = 5;
            this.tbKeys.StateCommon.Border.Width = 1;
            this.tbKeys.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.tbKeys.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbKeys.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tbKeys.TabIndex = 1;
            // 
            // cbDate
            // 
            this.cbDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbDate.ForeColor = System.Drawing.Color.Black;
            this.cbDate.FormattingEnabled = true;
            this.cbDate.Items.AddRange(new object[] {
            "Подача заявки",
            "Публикация документа",
            "Публикация заявки",
            "Начало действия патента"});
            this.cbDate.Location = new System.Drawing.Point(248, 159);
            this.cbDate.Name = "cbDate";
            this.cbDate.Size = new System.Drawing.Size(442, 29);
            this.cbDate.TabIndex = 25;
            // 
            // tableLayoutPanelBottom
            // 
            this.tableLayoutPanelBottom.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanelBottom.ColumnCount = 2;
            this.tableLayoutPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.38348F));
            this.tableLayoutPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.61652F));
            this.tableLayoutPanelBottom.Controls.Add(this.tableLayoutPanelDocAmount, 0, 0);
            this.tableLayoutPanelBottom.Controls.Add(this.btnSearch, 1, 0);
            this.tableLayoutPanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanelBottom.Location = new System.Drawing.Point(10, 808);
            this.tableLayoutPanelBottom.Name = "tableLayoutPanelBottom";
            this.tableLayoutPanelBottom.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tableLayoutPanelBottom.RowCount = 1;
            this.tableLayoutPanelBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBottom.Size = new System.Drawing.Size(698, 50);
            this.tableLayoutPanelBottom.TabIndex = 2;
            // 
            // tableLayoutPanelDocAmount
            // 
            this.tableLayoutPanelDocAmount.ColumnCount = 3;
            this.tableLayoutPanelDocAmount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.49442F));
            this.tableLayoutPanelDocAmount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.60595F));
            this.tableLayoutPanelDocAmount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.54113F));
            this.tableLayoutPanelDocAmount.Controls.Add(this.tbDocAmount, 0, 0);
            this.tableLayoutPanelDocAmount.Controls.Add(this.lblDocAmount, 0, 0);
            this.tableLayoutPanelDocAmount.Controls.Add(this.btnClear, 2, 0);
            this.tableLayoutPanelDocAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelDocAmount.Location = new System.Drawing.Point(13, 3);
            this.tableLayoutPanelDocAmount.Name = "tableLayoutPanelDocAmount";
            this.tableLayoutPanelDocAmount.RowCount = 1;
            this.tableLayoutPanelDocAmount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelDocAmount.Size = new System.Drawing.Size(538, 44);
            this.tableLayoutPanelDocAmount.TabIndex = 23;
            // 
            // tbDocAmount
            // 
            this.tbDocAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDocAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbDocAmount.Location = new System.Drawing.Point(237, 6);
            this.tbDocAmount.Name = "tbDocAmount";
            this.tbDocAmount.Size = new System.Drawing.Size(121, 32);
            this.tbDocAmount.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(129)))), ((int)(((byte)(237)))));
            this.tbDocAmount.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(129)))), ((int)(((byte)(237)))));
            this.tbDocAmount.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbDocAmount.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.tbDocAmount.StateCommon.Border.Rounding = 5;
            this.tbDocAmount.StateCommon.Border.Width = 1;
            this.tbDocAmount.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.tbDocAmount.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDocAmount.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tbDocAmount.TabIndex = 12;
            // 
            // lblDocAmount
            // 
            this.lblDocAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDocAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDocAmount.ForeColor = System.Drawing.Color.White;
            this.lblDocAmount.Location = new System.Drawing.Point(3, 0);
            this.lblDocAmount.Name = "lblDocAmount";
            this.lblDocAmount.Size = new System.Drawing.Size(228, 44);
            this.lblDocAmount.TabIndex = 24;
            this.lblDocAmount.Text = "Количество документов:";
            this.lblDocAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(117)))), ((int)(((byte)(208)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(364, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(171, 33);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Очистить форму";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(117)))), ((int)(((byte)(208)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(557, 8);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(128, 33);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tableLayoutPanelTop
            // 
            this.tableLayoutPanelTop.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanelTop.ColumnCount = 1;
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTop.Controls.Add(this.panelUnderline, 0, 1);
            this.tableLayoutPanelTop.Controls.Add(this.lblParserName, 0, 0);
            this.tableLayoutPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelTop.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanelTop.Name = "tableLayoutPanelTop";
            this.tableLayoutPanelTop.RowCount = 2;
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelTop.Size = new System.Drawing.Size(698, 40);
            this.tableLayoutPanelTop.TabIndex = 0;
            // 
            // panelUnderline
            // 
            this.panelUnderline.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelUnderline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(117)))), ((int)(((byte)(208)))));
            this.panelUnderline.Location = new System.Drawing.Point(219, 39);
            this.panelUnderline.Name = "panelUnderline";
            this.panelUnderline.Size = new System.Drawing.Size(260, 1);
            this.panelUnderline.TabIndex = 3;
            // 
            // lblParserName
            // 
            this.lblParserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblParserName.AutoSize = true;
            this.lblParserName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblParserName.ForeColor = System.Drawing.Color.White;
            this.lblParserName.Location = new System.Drawing.Point(3, 0);
            this.lblParserName.Name = "lblParserName";
            this.lblParserName.Size = new System.Drawing.Size(692, 36);
            this.lblParserName.TabIndex = 1;
            this.lblParserName.Text = "Поиск по сайту Яндекс.Патенты";
            this.lblParserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chbApplication
            // 
            this.chbApplication.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chbApplication.AutoSize = true;
            this.chbApplication.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbApplication.ForeColor = System.Drawing.Color.White;
            this.chbApplication.Location = new System.Drawing.Point(3, 13);
            this.chbApplication.Name = "chbApplication";
            this.chbApplication.Size = new System.Drawing.Size(126, 27);
            this.chbApplication.TabIndex = 10;
            this.chbApplication.Text = "Заявка";
            this.chbApplication.UseVisualStyleBackColor = true;
            // 
            // chbPatent
            // 
            this.chbPatent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chbPatent.AutoSize = true;
            this.chbPatent.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbPatent.ForeColor = System.Drawing.Color.White;
            this.chbPatent.Location = new System.Drawing.Point(135, 13);
            this.chbPatent.Name = "chbPatent";
            this.chbPatent.Size = new System.Drawing.Size(304, 27);
            this.chbPatent.TabIndex = 11;
            this.chbPatent.Text = "Патент";
            this.chbPatent.UseVisualStyleBackColor = true;
            // 
            // tlpType
            // 
            this.tlpType.ColumnCount = 2;
            this.tlpType.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpType.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpType.Controls.Add(this.chbPatent, 1, 0);
            this.tlpType.Controls.Add(this.chbApplication, 0, 0);
            this.tlpType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpType.Location = new System.Drawing.Point(248, 426);
            this.tlpType.Name = "tlpType";
            this.tlpType.RowCount = 1;
            this.tlpType.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpType.Size = new System.Drawing.Size(442, 53);
            this.tlpType.TabIndex = 24;
            // 
            // YandexPatents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 900);
            this.Controls.Add(this.kryptonPanelBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "YandexPatents";
            this.Text = "YandexPatents";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelBackground)).EndInit();
            this.kryptonPanelBackground.ResumeLayout(false);
            this.panelBorder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanelMain)).EndInit();
            this.kryptonPanelMain.ResumeLayout(false);
            this.tableLayoutPanelCenter.ResumeLayout(false);
            this.tableLayoutPanelCenter.PerformLayout();
            this.tlbDate.ResumeLayout(false);
            this.tlbDate.PerformLayout();
            this.tableLayoutPanelBottom.ResumeLayout(false);
            this.tableLayoutPanelDocAmount.ResumeLayout(false);
            this.tableLayoutPanelDocAmount.PerformLayout();
            this.tableLayoutPanelTop.ResumeLayout(false);
            this.tableLayoutPanelTop.PerformLayout();
            this.tlpType.ResumeLayout(false);
            this.tlpType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblDocument;
        private System.Windows.Forms.Label lblKeys;
        private System.Windows.Forms.Label lblApplication;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblPatentee;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblDate;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanelBackground;
        private System.Windows.Forms.Panel panelBorder;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCenter;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbPatentee;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbAuthor;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbApplication;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbDocument;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbKeys;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBottom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDocAmount;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbDocAmount;
        private System.Windows.Forms.Label lblDocAmount;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTop;
        private System.Windows.Forms.Panel panelUnderline;
        private System.Windows.Forms.Label lblParserName;
        private System.Windows.Forms.TableLayoutPanel tlbDate;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
        private ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox mtbEnd;
        private ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox mtbStart;
        private System.Windows.Forms.ComboBox cbDate;
        private System.Windows.Forms.TableLayoutPanel tlpType;
        private System.Windows.Forms.CheckBox chbPatent;
        private System.Windows.Forms.CheckBox chbApplication;
    }
}