namespace Parser.UI
{
    partial class SelectingFileName
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelFileExtension = new System.Windows.Forms.Label();
            this.textBox_fileName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.labelUnderNote = new System.Windows.Forms.Label();
            this.btnSetName = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.panelBackground = new System.Windows.Forms.Panel();
            this.panelMain.SuspendLayout();
            this.panelBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panelMain.Controls.Add(this.buttonCancel);
            this.panelMain.Controls.Add(this.labelFileExtension);
            this.panelMain.Controls.Add(this.textBox_fileName);
            this.panelMain.Controls.Add(this.labelUnderNote);
            this.panelMain.Controls.Add(this.btnSetName);
            this.panelMain.Controls.Add(this.button_Exit);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panelMain.Location = new System.Drawing.Point(1, 1);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(618, 298);
            this.panelMain.TabIndex = 1;
            this.panelMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMain_MouseDown);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(117)))), ((int)(((byte)(208)))));
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.Location = new System.Drawing.Point(418, 248);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(90, 40);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelFileExtension
            // 
            this.labelFileExtension.BackColor = System.Drawing.Color.Transparent;
            this.labelFileExtension.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFileExtension.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFileExtension.ForeColor = System.Drawing.Color.White;
            this.labelFileExtension.Location = new System.Drawing.Point(503, 116);
            this.labelFileExtension.Name = "labelFileExtension";
            this.labelFileExtension.Size = new System.Drawing.Size(73, 34);
            this.labelFileExtension.TabIndex = 14;
            this.labelFileExtension.Text = ".xlsx";
            this.labelFileExtension.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_fileName
            // 
            this.textBox_fileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_fileName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_fileName.Location = new System.Drawing.Point(46, 115);
            this.textBox_fileName.Name = "textBox_fileName";
            this.textBox_fileName.Size = new System.Drawing.Size(449, 34);
            this.textBox_fileName.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(129)))), ((int)(((byte)(237)))));
            this.textBox_fileName.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(129)))), ((int)(((byte)(237)))));
            this.textBox_fileName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBox_fileName.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.textBox_fileName.StateCommon.Border.Rounding = 5;
            this.textBox_fileName.StateCommon.Border.Width = 2;
            this.textBox_fileName.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.textBox_fileName.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_fileName.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.textBox_fileName.TabIndex = 1;
            // 
            // labelUnderNote
            // 
            this.labelUnderNote.AutoSize = true;
            this.labelUnderNote.BackColor = System.Drawing.Color.Transparent;
            this.labelUnderNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUnderNote.ForeColor = System.Drawing.Color.White;
            this.labelUnderNote.Location = new System.Drawing.Point(43, 176);
            this.labelUnderNote.Name = "labelUnderNote";
            this.labelUnderNote.Size = new System.Drawing.Size(37, 16);
            this.labelUnderNote.TabIndex = 11;
            this.labelUnderNote.Text = "label";
            // 
            // btnSetName
            // 
            this.btnSetName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(117)))), ((int)(((byte)(208)))));
            this.btnSetName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSetName.ForeColor = System.Drawing.Color.White;
            this.btnSetName.Location = new System.Drawing.Point(518, 248);
            this.btnSetName.Name = "btnSetName";
            this.btnSetName.Size = new System.Drawing.Size(90, 40);
            this.btnSetName.TabIndex = 2;
            this.btnSetName.Text = "ОК";
            this.btnSetName.UseVisualStyleBackColor = false;
            this.btnSetName.Click += new System.EventHandler(this.btnSetName_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(117)))), ((int)(((byte)(208)))));
            this.button_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Exit.FlatAppearance.BorderSize = 0;
            this.button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Exit.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Exit.ForeColor = System.Drawing.Color.White;
            this.button_Exit.Location = new System.Drawing.Point(583, 11);
            this.button_Exit.Margin = new System.Windows.Forms.Padding(2);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(26, 28);
            this.button_Exit.TabIndex = 7;
            this.button_Exit.Text = "✕";
            this.button_Exit.UseVisualStyleBackColor = false;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // panelBackground
            // 
            this.panelBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(117)))), ((int)(((byte)(208)))));
            this.panelBackground.Controls.Add(this.panelMain);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Padding = new System.Windows.Forms.Padding(1);
            this.panelBackground.Size = new System.Drawing.Size(620, 300);
            this.panelBackground.TabIndex = 2;
            // 
            // SelectingFileName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 300);
            this.Controls.Add(this.panelBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectingFileName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FileNameSelect";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelBackground.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button btnSetName;
        private System.Windows.Forms.Label labelUnderNote;
        private System.Windows.Forms.Label labelFileExtension;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBox_fileName;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Panel panelBackground;
    }
}