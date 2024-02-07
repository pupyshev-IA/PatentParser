namespace Parser.UI
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
            this.treeView_ExcelFiles = new System.Windows.Forms.TreeView();
            this.imageList_treeIcons = new System.Windows.Forms.ImageList(this.components);
            this.label_Search = new System.Windows.Forms.Label();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.pictureBox_Clear = new System.Windows.Forms.PictureBox();
            this.imageList_formIcons = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Clear)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView_ExcelFiles
            // 
            this.treeView_ExcelFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView_ExcelFiles.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeView_ExcelFiles.ImageIndex = 0;
            this.treeView_ExcelFiles.ImageList = this.imageList_treeIcons;
            this.treeView_ExcelFiles.Location = new System.Drawing.Point(0, 28);
            this.treeView_ExcelFiles.Name = "treeView_ExcelFiles";
            this.treeView_ExcelFiles.SelectedImageIndex = 0;
            this.treeView_ExcelFiles.Size = new System.Drawing.Size(330, 772);
            this.treeView_ExcelFiles.StateImageList = this.imageList_treeIcons;
            this.treeView_ExcelFiles.TabIndex = 0;
            this.treeView_ExcelFiles.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_ExcelFiles_NodeMouseDoubleClick);
            // 
            // imageList_treeIcons
            // 
            this.imageList_treeIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_treeIcons.ImageStream")));
            this.imageList_treeIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_treeIcons.Images.SetKeyName(0, "folder");
            this.imageList_treeIcons.Images.SetKeyName(1, "excel");
            // 
            // label_Search
            // 
            this.label_Search.AutoSize = true;
            this.label_Search.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_Search.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Search.Location = new System.Drawing.Point(0, 0);
            this.label_Search.Name = "label_Search";
            this.label_Search.Size = new System.Drawing.Size(70, 25);
            this.label_Search.TabIndex = 1;
            this.label_Search.Text = "Поиск:";
            // 
            // textBox_Search
            // 
            this.textBox_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Search.Location = new System.Drawing.Point(76, 0);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(225, 29);
            this.textBox_Search.TabIndex = 2;
            this.textBox_Search.TextChanged += new System.EventHandler(this.textBox_Search_TextChanged);
            // 
            // pictureBox_Clear
            // 
            this.pictureBox_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Clear.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Clear.Image")));
            this.pictureBox_Clear.Location = new System.Drawing.Point(301, 0);
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
            // FileExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 800);
            this.Controls.Add(this.label_Search);
            this.Controls.Add(this.treeView_ExcelFiles);
            this.Controls.Add(this.pictureBox_Clear);
            this.Controls.Add(this.textBox_Search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FileExplorer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FileExplorer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Clear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView_ExcelFiles;
        private System.Windows.Forms.ImageList imageList_treeIcons;
        private System.Windows.Forms.Label label_Search;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.PictureBox pictureBox_Clear;
        private System.Windows.Forms.ImageList imageList_formIcons;
    }
}