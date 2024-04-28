namespace Parser.UI.Analytics.DashboardOptions
{
    partial class PatentInfo
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
            this.panelBackground = new System.Windows.Forms.Panel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.tbAbstract_text = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tlpAbstract = new System.Windows.Forms.TableLayoutPanel();
            this.lblAbstract = new System.Windows.Forms.Label();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.tlpTop = new System.Windows.Forms.TableLayoutPanel();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.tlpCharts = new System.Windows.Forms.TableLayoutPanel();
            this.pieChart_clusters = new LiveCharts.WinForms.PieChart();
            this.cartesianChart_keys = new LiveCharts.WinForms.CartesianChart();
            this.tlpInfo = new System.Windows.Forms.TableLayoutPanel();
            this.lblIPC_text = new System.Windows.Forms.Label();
            this.lblIPC = new System.Windows.Forms.Label();
            this.lblApplicant_text = new System.Windows.Forms.Label();
            this.lblApplicant = new System.Windows.Forms.Label();
            this.lblInventor_text = new System.Windows.Forms.Label();
            this.lblInventor = new System.Windows.Forms.Label();
            this.lblDocNum_text = new System.Windows.Forms.Label();
            this.lblName_text = new System.Windows.Forms.Label();
            this.lblDocNum = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panelBackground.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.tlpAbstract.SuspendLayout();
            this.tlpTop.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.tlpCharts.SuspendLayout();
            this.tlpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBackground
            // 
            this.panelBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panelBackground.Controls.Add(this.pnlBottom);
            this.panelBackground.Controls.Add(this.tlpTop);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(1250, 800);
            this.panelBackground.TabIndex = 0;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.Transparent;
            this.pnlBottom.Controls.Add(this.tbAbstract_text);
            this.pnlBottom.Controls.Add(this.tlpAbstract);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottom.Location = new System.Drawing.Point(0, 640);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1250, 160);
            this.pnlBottom.TabIndex = 1;
            // 
            // tbAbstract_text
            // 
            this.tbAbstract_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAbstract_text.Location = new System.Drawing.Point(0, 45);
            this.tbAbstract_text.Multiline = true;
            this.tbAbstract_text.Name = "tbAbstract_text";
            this.tbAbstract_text.ReadOnly = true;
            this.tbAbstract_text.Size = new System.Drawing.Size(1250, 115);
            this.tbAbstract_text.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tbAbstract_text.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.None;
            this.tbAbstract_text.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.tbAbstract_text.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAbstract_text.StateCommon.Content.Padding = new System.Windows.Forms.Padding(15, 5, -1, -1);
            this.tbAbstract_text.TabIndex = 4;
            // 
            // tlpAbstract
            // 
            this.tlpAbstract.ColumnCount = 2;
            this.tlpAbstract.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96.7F));
            this.tlpAbstract.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.3F));
            this.tlpAbstract.Controls.Add(this.lblAbstract, 0, 0);
            this.tlpAbstract.Controls.Add(this.btnTranslate, 1, 0);
            this.tlpAbstract.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpAbstract.Location = new System.Drawing.Point(0, 0);
            this.tlpAbstract.Name = "tlpAbstract";
            this.tlpAbstract.RowCount = 1;
            this.tlpAbstract.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAbstract.Size = new System.Drawing.Size(1250, 45);
            this.tlpAbstract.TabIndex = 3;
            // 
            // lblAbstract
            // 
            this.lblAbstract.BackColor = System.Drawing.Color.Transparent;
            this.lblAbstract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAbstract.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAbstract.ForeColor = System.Drawing.Color.White;
            this.lblAbstract.Location = new System.Drawing.Point(3, 0);
            this.lblAbstract.Name = "lblAbstract";
            this.lblAbstract.Padding = new System.Windows.Forms.Padding(15, 5, 0, 0);
            this.lblAbstract.Size = new System.Drawing.Size(1202, 45);
            this.lblAbstract.TabIndex = 1;
            this.lblAbstract.Text = "Реферат:";
            // 
            // btnTranslate
            // 
            this.btnTranslate.BackColor = System.Drawing.Color.Transparent;
            this.btnTranslate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTranslate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTranslate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTranslate.FlatAppearance.BorderSize = 0;
            this.btnTranslate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnTranslate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTranslate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTranslate.Image = global::Parser.Properties.Resources.translate;
            this.btnTranslate.Location = new System.Drawing.Point(1211, 3);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(36, 39);
            this.btnTranslate.TabIndex = 2;
            this.btnTranslate.UseVisualStyleBackColor = false;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // tlpTop
            // 
            this.tlpTop.ColumnCount = 2;
            this.tlpTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tlpTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tlpTop.Controls.Add(this.pnlInfo, 0, 0);
            this.tlpTop.Controls.Add(this.pictureBox, 1, 0);
            this.tlpTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpTop.Location = new System.Drawing.Point(0, 0);
            this.tlpTop.Name = "tlpTop";
            this.tlpTop.RowCount = 1;
            this.tlpTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTop.Size = new System.Drawing.Size(1250, 640);
            this.tlpTop.TabIndex = 0;
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.Transparent;
            this.pnlInfo.Controls.Add(this.tlpCharts);
            this.pnlInfo.Controls.Add(this.tlpInfo);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInfo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pnlInfo.Location = new System.Drawing.Point(3, 3);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(681, 634);
            this.pnlInfo.TabIndex = 1;
            // 
            // tlpCharts
            // 
            this.tlpCharts.ColumnCount = 2;
            this.tlpCharts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpCharts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpCharts.Controls.Add(this.pieChart_clusters, 0, 0);
            this.tlpCharts.Controls.Add(this.cartesianChart_keys, 1, 0);
            this.tlpCharts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCharts.Location = new System.Drawing.Point(0, 370);
            this.tlpCharts.Name = "tlpCharts";
            this.tlpCharts.RowCount = 1;
            this.tlpCharts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCharts.Size = new System.Drawing.Size(681, 264);
            this.tlpCharts.TabIndex = 3;
            // 
            // pieChart_clusters
            // 
            this.pieChart_clusters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pieChart_clusters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pieChart_clusters.ForeColor = System.Drawing.Color.Black;
            this.pieChart_clusters.Location = new System.Drawing.Point(3, 3);
            this.pieChart_clusters.Name = "pieChart_clusters";
            this.pieChart_clusters.Size = new System.Drawing.Size(266, 258);
            this.pieChart_clusters.TabIndex = 0;
            // 
            // cartesianChart_keys
            // 
            this.cartesianChart_keys.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.cartesianChart_keys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartesianChart_keys.Location = new System.Drawing.Point(275, 3);
            this.cartesianChart_keys.Name = "cartesianChart_keys";
            this.cartesianChart_keys.Size = new System.Drawing.Size(403, 258);
            this.cartesianChart_keys.TabIndex = 1;
            this.cartesianChart_keys.Text = "cartesianChart1";
            // 
            // tlpInfo
            // 
            this.tlpInfo.BackColor = System.Drawing.Color.Transparent;
            this.tlpInfo.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpInfo.ColumnCount = 2;
            this.tlpInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpInfo.Controls.Add(this.lblIPC_text, 1, 4);
            this.tlpInfo.Controls.Add(this.lblIPC, 0, 4);
            this.tlpInfo.Controls.Add(this.lblApplicant_text, 1, 3);
            this.tlpInfo.Controls.Add(this.lblApplicant, 0, 3);
            this.tlpInfo.Controls.Add(this.lblInventor_text, 1, 2);
            this.tlpInfo.Controls.Add(this.lblInventor, 0, 2);
            this.tlpInfo.Controls.Add(this.lblDocNum_text, 1, 1);
            this.tlpInfo.Controls.Add(this.lblName_text, 1, 0);
            this.tlpInfo.Controls.Add(this.lblDocNum, 0, 1);
            this.tlpInfo.Controls.Add(this.lblName, 0, 0);
            this.tlpInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpInfo.Location = new System.Drawing.Point(0, 0);
            this.tlpInfo.Margin = new System.Windows.Forms.Padding(0);
            this.tlpInfo.Name = "tlpInfo";
            this.tlpInfo.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.tlpInfo.RowCount = 5;
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpInfo.Size = new System.Drawing.Size(681, 370);
            this.tlpInfo.TabIndex = 2;
            // 
            // lblIPC_text
            // 
            this.lblIPC_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIPC_text.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIPC_text.ForeColor = System.Drawing.Color.White;
            this.lblIPC_text.Location = new System.Drawing.Point(209, 296);
            this.lblIPC_text.Margin = new System.Windows.Forms.Padding(3);
            this.lblIPC_text.Name = "lblIPC_text";
            this.lblIPC_text.Size = new System.Drawing.Size(465, 70);
            this.lblIPC_text.TabIndex = 13;
            this.lblIPC_text.Text = "-----";
            this.lblIPC_text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIPC
            // 
            this.lblIPC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIPC.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIPC.ForeColor = System.Drawing.Color.White;
            this.lblIPC.Location = new System.Drawing.Point(7, 296);
            this.lblIPC.Margin = new System.Windows.Forms.Padding(3);
            this.lblIPC.Name = "lblIPC";
            this.lblIPC.Size = new System.Drawing.Size(195, 70);
            this.lblIPC.TabIndex = 12;
            this.lblIPC.Text = "МПК:";
            this.lblIPC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblApplicant_text
            // 
            this.lblApplicant_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblApplicant_text.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblApplicant_text.ForeColor = System.Drawing.Color.White;
            this.lblApplicant_text.Location = new System.Drawing.Point(209, 223);
            this.lblApplicant_text.Margin = new System.Windows.Forms.Padding(3);
            this.lblApplicant_text.Name = "lblApplicant_text";
            this.lblApplicant_text.Size = new System.Drawing.Size(465, 66);
            this.lblApplicant_text.TabIndex = 11;
            this.lblApplicant_text.Text = "-----";
            this.lblApplicant_text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblApplicant
            // 
            this.lblApplicant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblApplicant.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblApplicant.ForeColor = System.Drawing.Color.White;
            this.lblApplicant.Location = new System.Drawing.Point(7, 223);
            this.lblApplicant.Margin = new System.Windows.Forms.Padding(3);
            this.lblApplicant.Name = "lblApplicant";
            this.lblApplicant.Size = new System.Drawing.Size(195, 66);
            this.lblApplicant.TabIndex = 10;
            this.lblApplicant.Text = "Заявитель:";
            this.lblApplicant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblInventor_text
            // 
            this.lblInventor_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInventor_text.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInventor_text.ForeColor = System.Drawing.Color.White;
            this.lblInventor_text.Location = new System.Drawing.Point(209, 150);
            this.lblInventor_text.Margin = new System.Windows.Forms.Padding(3);
            this.lblInventor_text.Name = "lblInventor_text";
            this.lblInventor_text.Size = new System.Drawing.Size(465, 66);
            this.lblInventor_text.TabIndex = 9;
            this.lblInventor_text.Text = "-----";
            this.lblInventor_text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblInventor
            // 
            this.lblInventor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInventor.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInventor.ForeColor = System.Drawing.Color.White;
            this.lblInventor.Location = new System.Drawing.Point(7, 150);
            this.lblInventor.Margin = new System.Windows.Forms.Padding(3);
            this.lblInventor.Name = "lblInventor";
            this.lblInventor.Size = new System.Drawing.Size(195, 66);
            this.lblInventor.TabIndex = 8;
            this.lblInventor.Text = "Автор:";
            this.lblInventor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDocNum_text
            // 
            this.lblDocNum_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDocNum_text.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDocNum_text.ForeColor = System.Drawing.Color.White;
            this.lblDocNum_text.Location = new System.Drawing.Point(209, 77);
            this.lblDocNum_text.Margin = new System.Windows.Forms.Padding(3);
            this.lblDocNum_text.Name = "lblDocNum_text";
            this.lblDocNum_text.Size = new System.Drawing.Size(465, 66);
            this.lblDocNum_text.TabIndex = 7;
            this.lblDocNum_text.Text = "-----";
            this.lblDocNum_text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblName_text
            // 
            this.lblName_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName_text.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName_text.ForeColor = System.Drawing.Color.White;
            this.lblName_text.Location = new System.Drawing.Point(209, 4);
            this.lblName_text.Margin = new System.Windows.Forms.Padding(3);
            this.lblName_text.Name = "lblName_text";
            this.lblName_text.Size = new System.Drawing.Size(465, 66);
            this.lblName_text.TabIndex = 6;
            this.lblName_text.Text = "-----";
            this.lblName_text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDocNum
            // 
            this.lblDocNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDocNum.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDocNum.ForeColor = System.Drawing.Color.White;
            this.lblDocNum.Location = new System.Drawing.Point(7, 77);
            this.lblDocNum.Margin = new System.Windows.Forms.Padding(3);
            this.lblDocNum.Name = "lblDocNum";
            this.lblDocNum.Size = new System.Drawing.Size(195, 66);
            this.lblDocNum.TabIndex = 5;
            this.lblDocNum.Text = "Номер документа:";
            this.lblDocNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblName
            // 
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(7, 4);
            this.lblName.Margin = new System.Windows.Forms.Padding(3);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(195, 66);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Название:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Image = global::Parser.Properties.Resources.no_pictures;
            this.pictureBox.Location = new System.Drawing.Point(690, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(557, 634);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            this.pictureBox.VisibleChanged += new System.EventHandler(this.pictureBox_VisibleChanged);
            // 
            // PatentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 800);
            this.Controls.Add(this.panelBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PatentInfo";
            this.Text = "PatentInfo";
            this.panelBackground.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.tlpAbstract.ResumeLayout(false);
            this.tlpTop.ResumeLayout(false);
            this.pnlInfo.ResumeLayout(false);
            this.tlpCharts.ResumeLayout(false);
            this.tlpInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.TableLayoutPanel tlpTop;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblAbstract;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.TableLayoutPanel tlpInfo;
        private System.Windows.Forms.Label lblIPC_text;
        private System.Windows.Forms.Label lblIPC;
        private System.Windows.Forms.Label lblApplicant_text;
        private System.Windows.Forms.Label lblApplicant;
        private System.Windows.Forms.Label lblInventor_text;
        private System.Windows.Forms.Label lblInventor;
        private System.Windows.Forms.Label lblDocNum_text;
        private System.Windows.Forms.Label lblDocNum;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TableLayoutPanel tlpCharts;
        private LiveCharts.WinForms.PieChart pieChart_clusters;
        private LiveCharts.WinForms.CartesianChart cartesianChart_keys;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label lblName_text;
        private System.Windows.Forms.TableLayoutPanel tlpAbstract;
        private System.Windows.Forms.Button btnTranslate;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbAbstract_text;
    }
}