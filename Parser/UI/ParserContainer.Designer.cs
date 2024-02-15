namespace Parser.UI
{
    partial class ParserContainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParserContainer));
            this.imageList_icons = new System.Windows.Forms.ImageList(this.components);
            this.tabControl_Parsers = new System.Windows.Forms.TabControl();
            this.tabPage_AddButton = new System.Windows.Forms.TabPage();
            this.labelNote1 = new System.Windows.Forms.Label();
            this.btnNewParser = new System.Windows.Forms.Button();
            this.imageList_icon = new System.Windows.Forms.ImageList(this.components);
            this.labelNote2 = new System.Windows.Forms.Label();
            this.labelNote3 = new System.Windows.Forms.Label();
            this.labelNote4 = new System.Windows.Forms.Label();
            this.linkLabelSimpleSearch = new System.Windows.Forms.LinkLabel();
            this.linkLabelGlobalSearch = new System.Windows.Forms.LinkLabel();
            this.labelNote5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl_Parsers.SuspendLayout();
            this.tabPage_AddButton.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList_icons
            // 
            this.imageList_icons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_icons.ImageStream")));
            this.imageList_icons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_icons.Images.SetKeyName(0, "addTab.png");
            // 
            // tabControl_Parsers
            // 
            this.tabControl_Parsers.Controls.Add(this.tabPage_AddButton);
            this.tabControl_Parsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Parsers.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl_Parsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl_Parsers.ItemSize = new System.Drawing.Size(50, 25);
            this.tabControl_Parsers.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Parsers.Name = "tabControl_Parsers";
            this.tabControl_Parsers.SelectedIndex = 0;
            this.tabControl_Parsers.Size = new System.Drawing.Size(880, 810);
            this.tabControl_Parsers.TabIndex = 0;
            this.tabControl_Parsers.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl_Parsers_DrawItem);
            this.tabControl_Parsers.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl_Parsers_Selecting);
            this.tabControl_Parsers.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabControl_Parsers_MouseDown);
            // 
            // tabPage_AddButton
            // 
            this.tabPage_AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.tabPage_AddButton.Controls.Add(this.tableLayoutPanel);
            this.tabPage_AddButton.Controls.Add(this.labelNote5);
            this.tabPage_AddButton.Controls.Add(this.linkLabelGlobalSearch);
            this.tabPage_AddButton.Controls.Add(this.linkLabelSimpleSearch);
            this.tabPage_AddButton.Controls.Add(this.labelNote4);
            this.tabPage_AddButton.Controls.Add(this.labelNote3);
            this.tabPage_AddButton.Controls.Add(this.labelNote2);
            this.tabPage_AddButton.Controls.Add(this.labelNote1);
            this.tabPage_AddButton.ForeColor = System.Drawing.Color.White;
            this.tabPage_AddButton.Location = new System.Drawing.Point(4, 29);
            this.tabPage_AddButton.Name = "tabPage_AddButton";
            this.tabPage_AddButton.Size = new System.Drawing.Size(872, 777);
            this.tabPage_AddButton.TabIndex = 0;
            // 
            // labelNote1
            // 
            this.labelNote1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNote1.BackColor = System.Drawing.Color.Transparent;
            this.labelNote1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.labelNote1.Location = new System.Drawing.Point(8, 85);
            this.labelNote1.Name = "labelNote1";
            this.labelNote1.Size = new System.Drawing.Size(856, 83);
            this.labelNote1.TabIndex = 2;
            this.labelNote1.Text = "Данная программа предназначена для поиска патентной документации\r\nи ее последующе" +
    "го анализа.";
            this.labelNote1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNewParser
            // 
            this.btnNewParser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNewParser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(117)))), ((int)(((byte)(208)))));
            this.btnNewParser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewParser.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNewParser.ForeColor = System.Drawing.Color.Navy;
            this.btnNewParser.Image = ((System.Drawing.Image)(resources.GetObject("btnNewParser.Image")));
            this.btnNewParser.Location = new System.Drawing.Point(403, 3);
            this.btnNewParser.Name = "btnNewParser";
            this.btnNewParser.Size = new System.Drawing.Size(50, 49);
            this.btnNewParser.TabIndex = 1;
            this.btnNewParser.UseVisualStyleBackColor = false;
            this.btnNewParser.Click += new System.EventHandler(this.btnNewParser_Click);
            // 
            // imageList_icon
            // 
            this.imageList_icon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_icon.ImageStream")));
            this.imageList_icon.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_icon.Images.SetKeyName(0, "tabClos");
            // 
            // labelNote2
            // 
            this.labelNote2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNote2.BackColor = System.Drawing.Color.Transparent;
            this.labelNote2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.labelNote2.Location = new System.Drawing.Point(8, 168);
            this.labelNote2.Name = "labelNote2";
            this.labelNote2.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.labelNote2.Size = new System.Drawing.Size(856, 155);
            this.labelNote2.TabIndex = 3;
            this.labelNote2.Text = resources.GetString("labelNote2.Text");
            this.labelNote2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNote3
            // 
            this.labelNote3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNote3.BackColor = System.Drawing.Color.Transparent;
            this.labelNote3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.labelNote3.Location = new System.Drawing.Point(8, 323);
            this.labelNote3.Name = "labelNote3";
            this.labelNote3.Size = new System.Drawing.Size(856, 39);
            this.labelNote3.TabIndex = 4;
            this.labelNote3.Text = "Для начала поиска нажмите";
            this.labelNote3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNote4
            // 
            this.labelNote4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNote4.BackColor = System.Drawing.Color.Transparent;
            this.labelNote4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.labelNote4.Location = new System.Drawing.Point(8, 480);
            this.labelNote4.Name = "labelNote4";
            this.labelNote4.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.labelNote4.Size = new System.Drawing.Size(856, 39);
            this.labelNote4.TabIndex = 5;
            this.labelNote4.Text = "Также вы можете воспользоваться следующими надстройками:";
            this.labelNote4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // linkLabelSimpleSearch
            // 
            this.linkLabelSimpleSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelSimpleSearch.Location = new System.Drawing.Point(8, 519);
            this.linkLabelSimpleSearch.Name = "linkLabelSimpleSearch";
            this.linkLabelSimpleSearch.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.linkLabelSimpleSearch.Size = new System.Drawing.Size(856, 30);
            this.linkLabelSimpleSearch.TabIndex = 2;
            this.linkLabelSimpleSearch.TabStop = true;
            this.linkLabelSimpleSearch.Text = "Простой поиск";
            this.linkLabelSimpleSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // linkLabelGlobalSearch
            // 
            this.linkLabelGlobalSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelGlobalSearch.Location = new System.Drawing.Point(8, 549);
            this.linkLabelGlobalSearch.Name = "linkLabelGlobalSearch";
            this.linkLabelGlobalSearch.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.linkLabelGlobalSearch.Size = new System.Drawing.Size(856, 30);
            this.linkLabelGlobalSearch.TabIndex = 3;
            this.linkLabelGlobalSearch.TabStop = true;
            this.linkLabelGlobalSearch.Text = "Глобальный поиск";
            this.linkLabelGlobalSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNote5
            // 
            this.labelNote5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNote5.BackColor = System.Drawing.Color.Transparent;
            this.labelNote5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNote5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.labelNote5.Location = new System.Drawing.Point(8, 599);
            this.labelNote5.Name = "labelNote5";
            this.labelNote5.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.labelNote5.Size = new System.Drawing.Size(856, 120);
            this.labelNote5.TabIndex = 8;
            this.labelNote5.Text = resources.GetString("labelNote5.Text");
            this.labelNote5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.btnNewParser, 0, 0);
            this.tableLayoutPanel.Location = new System.Drawing.Point(8, 365);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(856, 55);
            this.tableLayoutPanel.TabIndex = 9;
            // 
            // ParserContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(880, 810);
            this.Controls.Add(this.tabControl_Parsers);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ParserContainer";
            this.Text = "ParserContainer";
            this.TopMost = true;
            this.tabControl_Parsers.ResumeLayout(false);
            this.tabPage_AddButton.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList_icons;
        private System.Windows.Forms.TabControl tabControl_Parsers;
        private System.Windows.Forms.TabPage tabPage_AddButton;
        private System.Windows.Forms.ImageList imageList_icon;
        private System.Windows.Forms.Button btnNewParser;
        private System.Windows.Forms.Label labelNote1;
        private System.Windows.Forms.Label labelNote3;
        private System.Windows.Forms.Label labelNote2;
        private System.Windows.Forms.LinkLabel linkLabelGlobalSearch;
        private System.Windows.Forms.LinkLabel linkLabelSimpleSearch;
        private System.Windows.Forms.Label labelNote4;
        private System.Windows.Forms.Label labelNote5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
    }
}