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
            this.imageList_icon = new System.Windows.Forms.ImageList(this.components);
            this.tabControl_Parsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList_icons
            // 
            this.imageList_icons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_icons.ImageStream")));
            this.imageList_icons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_icons.Images.SetKeyName(0, "tabAdd");
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
            this.tabPage_AddButton.Location = new System.Drawing.Point(4, 29);
            this.tabPage_AddButton.Name = "tabPage_AddButton";
            this.tabPage_AddButton.Size = new System.Drawing.Size(872, 777);
            this.tabPage_AddButton.TabIndex = 0;
            this.tabPage_AddButton.UseVisualStyleBackColor = true;
            // 
            // imageList_icon
            // 
            this.imageList_icon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_icon.ImageStream")));
            this.imageList_icon.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_icon.Images.SetKeyName(0, "tabCls");
            // 
            // ParserContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 810);
            this.Controls.Add(this.tabControl_Parsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ParserContainer";
            this.Text = "ParserContainer";
            this.TopMost = true;
            this.tabControl_Parsers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList_icons;
        private System.Windows.Forms.TabControl tabControl_Parsers;
        private System.Windows.Forms.TabPage tabPage_AddButton;
        private System.Windows.Forms.ImageList imageList_icon;
    }
}