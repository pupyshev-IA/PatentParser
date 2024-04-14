namespace Parser.UI.main
{
    partial class FileExplorer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileExplorer));
            this.imageList_treeIcons = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox_Clear = new System.Windows.Forms.PictureBox();
            this.imageList_formIcons = new System.Windows.Forms.ImageList(this.components);
            this.textBox_Search = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label_Search = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.tableLayoutPanelTop = new System.Windows.Forms.TableLayoutPanel();
            this.panelBackground = new System.Windows.Forms.Panel();
            this.treeView_ExcelFiles = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Clear)).BeginInit();
            this.panelTop.SuspendLayout();
            this.tableLayoutPanelTop.SuspendLayout();
            this.panelBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList_treeIcons
            // 
            this.imageList_treeIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_treeIcons.ImageStream")));
            this.imageList_treeIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_treeIcons.Images.SetKeyName(0, "folder");
            this.imageList_treeIcons.Images.SetKeyName(1, "excel");
            // 
            // pictureBox_Clear
            // 
            this.pictureBox_Clear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox_Clear.BackColor = System.Drawing.Color.White;
            this.pictureBox_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Clear.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Clear.Image")));
            this.pictureBox_Clear.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Clear.InitialImage")));
            this.pictureBox_Clear.Location = new System.Drawing.Point(293, 5);
            this.pictureBox_Clear.Name = "pictureBox_Clear";
            this.pictureBox_Clear.Size = new System.Drawing.Size(29, 29);
            this.pictureBox_Clear.TabIndex = 3;
            this.pictureBox_Clear.TabStop = false;
            this.pictureBox_Clear.Click += new System.EventHandler(this.pictureBox_Clear_Click);
            // 
            // imageList_formIcons
            // 
            this.imageList_formIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_formIcons.ImageStream")));
            this.imageList_formIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_formIcons.Images.SetKeyName(0, "update");
            this.imageList_formIcons.Images.SetKeyName(1, "clear");
            // 
            // textBox_Search
            // 
            this.textBox_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_Search.Location = new System.Drawing.Point(95, 3);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(192, 32);
            this.textBox_Search.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(129)))), ((int)(((byte)(237)))));
            this.textBox_Search.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(129)))), ((int)(((byte)(237)))));
            this.textBox_Search.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBox_Search.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.textBox_Search.StateCommon.Border.Rounding = 5;
            this.textBox_Search.StateCommon.Border.Width = 1;
            this.textBox_Search.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.textBox_Search.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Search.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.textBox_Search.TabIndex = 12;
            this.textBox_Search.TextChanged += new System.EventHandler(this.textBox_Search_TextChanged);
            // 
            // label_Search
            // 
            this.label_Search.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_Search.AutoSize = true;
            this.label_Search.BackColor = System.Drawing.Color.Transparent;
            this.label_Search.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Search.ForeColor = System.Drawing.Color.White;
            this.label_Search.Location = new System.Drawing.Point(3, 7);
            this.label_Search.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label_Search.Name = "label_Search";
            this.label_Search.Size = new System.Drawing.Size(70, 25);
            this.label_Search.TabIndex = 13;
            this.label_Search.Text = "Поиск:";
            this.label_Search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelTop.Controls.Add(this.tableLayoutPanelTop);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(330, 40);
            this.panelTop.TabIndex = 6;
            // 
            // tableLayoutPanelTop
            // 
            this.tableLayoutPanelTop.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanelTop.ColumnCount = 3;
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanelTop.Controls.Add(this.label_Search, 0, 0);
            this.tableLayoutPanelTop.Controls.Add(this.pictureBox_Clear, 2, 0);
            this.tableLayoutPanelTop.Controls.Add(this.textBox_Search, 1, 0);
            this.tableLayoutPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelTop.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelTop.Name = "tableLayoutPanelTop";
            this.tableLayoutPanelTop.RowCount = 1;
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTop.Size = new System.Drawing.Size(330, 40);
            this.tableLayoutPanelTop.TabIndex = 14;
            // 
            // panelBackground
            // 
            this.panelBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panelBackground.Controls.Add(this.treeView_ExcelFiles);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 40);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Padding = new System.Windows.Forms.Padding(20);
            this.panelBackground.Size = new System.Drawing.Size(330, 760);
            this.panelBackground.TabIndex = 7;
            // 
            // treeView_ExcelFiles
            // 
            this.treeView_ExcelFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.treeView_ExcelFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_ExcelFiles.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeView_ExcelFiles.ForeColor = System.Drawing.Color.White;
            this.treeView_ExcelFiles.ImageIndex = 0;
            this.treeView_ExcelFiles.ImageList = this.imageList_treeIcons;
            this.treeView_ExcelFiles.Location = new System.Drawing.Point(20, 20);
            this.treeView_ExcelFiles.Name = "treeView_ExcelFiles";
            this.treeView_ExcelFiles.SelectedImageIndex = 0;
            this.treeView_ExcelFiles.Size = new System.Drawing.Size(290, 720);
            this.treeView_ExcelFiles.StateImageList = this.imageList_treeIcons;
            this.treeView_ExcelFiles.TabIndex = 0;
            this.treeView_ExcelFiles.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_ExcelFiles_AfterSelect);
            this.treeView_ExcelFiles.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_ExcelFiles_NodeMouseDoubleClick);
            // 
            // FileExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(330, 800);
            this.Controls.Add(this.panelBackground);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FileExplorer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FileExplorer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Clear)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.tableLayoutPanelTop.ResumeLayout(false);
            this.tableLayoutPanelTop.PerformLayout();
            this.panelBackground.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList_treeIcons;
        private System.Windows.Forms.PictureBox pictureBox_Clear;
        private System.Windows.Forms.ImageList imageList_formIcons;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBox_Search;
        private System.Windows.Forms.Label label_Search;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.TreeView treeView_ExcelFiles;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTop;
    }
}