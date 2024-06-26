﻿namespace Parser.UI.main
{
    partial class DataView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label_Search = new System.Windows.Forms.Label();
            this.btnRight = new System.Windows.Forms.Button();
            this.panelBackground = new System.Windows.Forms.Panel();
            this.dataGridView_excel = new System.Windows.Forms.DataGridView();
            this.lblPage = new System.Windows.Forms.Label();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnAnalytics = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_excel)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelHeader.Controls.Add(this.btnAnalytics);
            this.panelHeader.Controls.Add(this.label_Search);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 40);
            this.panelHeader.TabIndex = 0;
            // 
            // label_Search
            // 
            this.label_Search.BackColor = System.Drawing.Color.Transparent;
            this.label_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Search.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Search.ForeColor = System.Drawing.Color.White;
            this.label_Search.Location = new System.Drawing.Point(0, 0);
            this.label_Search.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label_Search.Name = "label_Search";
            this.label_Search.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label_Search.Size = new System.Drawing.Size(800, 40);
            this.label_Search.TabIndex = 14;
            this.label_Search.Text = "Просмотр данных:";
            this.label_Search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnRight
            // 
            this.btnRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRight.BackColor = System.Drawing.Color.White;
            this.btnRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRight.FlatAppearance.BorderSize = 0;
            this.btnRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRight.ForeColor = System.Drawing.Color.White;
            this.btnRight.Image = global::Parser.Properties.Resources.double_right;
            this.btnRight.Location = new System.Drawing.Point(757, 531);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(35, 25);
            this.btnRight.TabIndex = 15;
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.Visible = false;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // panelBackground
            // 
            this.panelBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panelBackground.Controls.Add(this.btnLeft);
            this.panelBackground.Controls.Add(this.dataGridView_excel);
            this.panelBackground.Controls.Add(this.btnRight);
            this.panelBackground.Controls.Add(this.lblPage);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 40);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Padding = new System.Windows.Forms.Padding(5, 15, 5, 35);
            this.panelBackground.Size = new System.Drawing.Size(800, 560);
            this.panelBackground.TabIndex = 9;
            // 
            // dataGridView_excel
            // 
            this.dataGridView_excel.AllowUserToAddRows = false;
            this.dataGridView_excel.AllowUserToDeleteRows = false;
            this.dataGridView_excel.AllowUserToOrderColumns = true;
            this.dataGridView_excel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_excel.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_excel.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_excel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_excel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_excel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(117)))), ((int)(((byte)(208)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_excel.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_excel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_excel.EnableHeadersVisualStyles = false;
            this.dataGridView_excel.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dataGridView_excel.Location = new System.Drawing.Point(5, 15);
            this.dataGridView_excel.MultiSelect = false;
            this.dataGridView_excel.Name = "dataGridView_excel";
            this.dataGridView_excel.ReadOnly = true;
            this.dataGridView_excel.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView_excel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_excel.Size = new System.Drawing.Size(790, 510);
            this.dataGridView_excel.TabIndex = 0;
            this.dataGridView_excel.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_excel_CellDoubleClick);
            // 
            // lblPage
            // 
            this.lblPage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPage.BackColor = System.Drawing.Color.Transparent;
            this.lblPage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPage.ForeColor = System.Drawing.Color.White;
            this.lblPage.Location = new System.Drawing.Point(12, 531);
            this.lblPage.Margin = new System.Windows.Forms.Padding(3, 0, 15, 0);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(780, 25);
            this.lblPage.TabIndex = 17;
            this.lblPage.Text = "Страница: ";
            this.lblPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPage.Visible = false;
            // 
            // btnLeft
            // 
            this.btnLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLeft.BackColor = System.Drawing.Color.White;
            this.btnLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLeft.FlatAppearance.BorderSize = 0;
            this.btnLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLeft.ForeColor = System.Drawing.Color.White;
            this.btnLeft.Image = global::Parser.Properties.Resources.double_left;
            this.btnLeft.Location = new System.Drawing.Point(12, 531);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(35, 25);
            this.btnLeft.TabIndex = 16;
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.Visible = false;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnAnalytics
            // 
            this.btnAnalytics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnalytics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(117)))), ((int)(((byte)(208)))));
            this.btnAnalytics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnalytics.FlatAppearance.BorderSize = 0;
            this.btnAnalytics.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAnalytics.ForeColor = System.Drawing.Color.Navy;
            this.btnAnalytics.Image = global::Parser.Properties.Resources.analytics;
            this.btnAnalytics.Location = new System.Drawing.Point(763, 2);
            this.btnAnalytics.Name = "btnAnalytics";
            this.btnAnalytics.Size = new System.Drawing.Size(35, 35);
            this.btnAnalytics.TabIndex = 1;
            this.btnAnalytics.UseVisualStyleBackColor = false;
            this.btnAnalytics.Click += new System.EventHandler(this.btnAnalytics_Click);
            // 
            // DataView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panelBackground);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DataView";
            this.Text = "DataView";
            this.panelHeader.ResumeLayout(false);
            this.panelBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_excel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.DataGridView dataGridView_excel;
        private System.Windows.Forms.Label label_Search;
        private System.Windows.Forms.Button btnAnalytics;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Label lblPage;
    }
}