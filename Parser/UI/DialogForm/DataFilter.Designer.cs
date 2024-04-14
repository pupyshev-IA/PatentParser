namespace Parser.UI.DialogForm
{
    partial class DataFilter
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
            this.panelBackground = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLike = new System.Windows.Forms.Button();
            this.btnOr = new System.Windows.Forms.Button();
            this.btnAnd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbHeaders = new System.Windows.Forms.ComboBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.labelUnderNote = new System.Windows.Forms.Label();
            this.button_Exit = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.toolTipAnd = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipOr = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipLike = new System.Windows.Forms.ToolTip(this.components);
            this.panelBackground.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBackground
            // 
            this.panelBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(117)))), ((int)(((byte)(208)))));
            this.panelBackground.Controls.Add(this.panelMain);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Padding = new System.Windows.Forms.Padding(1);
            this.panelBackground.Size = new System.Drawing.Size(645, 345);
            this.panelBackground.TabIndex = 3;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.btnLike);
            this.panelMain.Controls.Add(this.btnOr);
            this.panelMain.Controls.Add(this.btnAnd);
            this.panelMain.Controls.Add(this.btnClear);
            this.panelMain.Controls.Add(this.btnAdd);
            this.panelMain.Controls.Add(this.cbHeaders);
            this.panelMain.Controls.Add(this.tbSearch);
            this.panelMain.Controls.Add(this.labelUnderNote);
            this.panelMain.Controls.Add(this.button_Exit);
            this.panelMain.Controls.Add(this.btnFilter);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panelMain.Location = new System.Drawing.Point(1, 1);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(643, 343);
            this.panelMain.TabIndex = 0;
            this.panelMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMain_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 32);
            this.label1.TabIndex = 18;
            this.label1.Text = "Фильтр";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLike
            // 
            this.btnLike.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(117)))), ((int)(((byte)(208)))));
            this.btnLike.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLike.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLike.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnLike.ForeColor = System.Drawing.Color.White;
            this.btnLike.Location = new System.Drawing.Point(185, 217);
            this.btnLike.Name = "btnLike";
            this.btnLike.Size = new System.Drawing.Size(81, 40);
            this.btnLike.TabIndex = 17;
            this.btnLike.Text = "LIKE";
            this.toolTipLike.SetToolTip(this.btnLike, "Оператор для поиска подстроки. Оператор \'%\' соответствует любому символу (один ил" +
        "и несколько).\r\nДля отрицания используется оператор \'NOT LIKE\'");
            this.btnLike.UseVisualStyleBackColor = false;
            this.btnLike.Click += new System.EventHandler(this.btnLike_Click);
            // 
            // btnOr
            // 
            this.btnOr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(117)))), ((int)(((byte)(208)))));
            this.btnOr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOr.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnOr.ForeColor = System.Drawing.Color.White;
            this.btnOr.Location = new System.Drawing.Point(98, 217);
            this.btnOr.Name = "btnOr";
            this.btnOr.Size = new System.Drawing.Size(81, 40);
            this.btnOr.TabIndex = 16;
            this.btnOr.Text = "OR";
            this.toolTipOr.SetToolTip(this.btnOr, "Соответствует логическому оператору \'ИЛИ\'");
            this.btnOr.UseVisualStyleBackColor = false;
            this.btnOr.Click += new System.EventHandler(this.btnOr_Click);
            // 
            // btnAnd
            // 
            this.btnAnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(117)))), ((int)(((byte)(208)))));
            this.btnAnd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAnd.ForeColor = System.Drawing.Color.White;
            this.btnAnd.Location = new System.Drawing.Point(11, 217);
            this.btnAnd.Name = "btnAnd";
            this.btnAnd.Size = new System.Drawing.Size(81, 40);
            this.btnAnd.TabIndex = 15;
            this.btnAnd.Text = "AND";
            this.toolTipAnd.SetToolTip(this.btnAnd, "Соответствует логическому оператору \'И\'");
            this.btnAnd.UseVisualStyleBackColor = false;
            this.btnAnd.Click += new System.EventHandler(this.btnAnd_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(117)))), ((int)(((byte)(208)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(11, 140);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(255, 40);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(117)))), ((int)(((byte)(208)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(11, 94);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(255, 40);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbHeaders
            // 
            this.cbHeaders.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbHeaders.FormattingEnabled = true;
            this.cbHeaders.Location = new System.Drawing.Point(11, 59);
            this.cbHeaders.Name = "cbHeaders";
            this.cbHeaders.Size = new System.Drawing.Size(255, 29);
            this.cbHeaders.TabIndex = 12;
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSearch.Location = new System.Drawing.Point(272, 59);
            this.tbSearch.Multiline = true;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(360, 260);
            this.tbSearch.TabIndex = 11;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // labelUnderNote
            // 
            this.labelUnderNote.BackColor = System.Drawing.Color.Transparent;
            this.labelUnderNote.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUnderNote.ForeColor = System.Drawing.Color.White;
            this.labelUnderNote.Location = new System.Drawing.Point(11, 183);
            this.labelUnderNote.Name = "labelUnderNote";
            this.labelUnderNote.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.labelUnderNote.Size = new System.Drawing.Size(255, 31);
            this.labelUnderNote.TabIndex = 10;
            this.labelUnderNote.Text = "Операторы:";
            this.labelUnderNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Exit
            // 
            this.button_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(117)))), ((int)(((byte)(208)))));
            this.button_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Exit.FlatAppearance.BorderSize = 0;
            this.button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Exit.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Exit.ForeColor = System.Drawing.Color.White;
            this.button_Exit.Location = new System.Drawing.Point(606, 10);
            this.button_Exit.Margin = new System.Windows.Forms.Padding(2);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(26, 28);
            this.button_Exit.TabIndex = 7;
            this.button_Exit.Text = "✕";
            this.button_Exit.UseVisualStyleBackColor = false;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(117)))), ((int)(((byte)(208)))));
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Location = new System.Drawing.Point(11, 279);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(255, 40);
            this.btnFilter.TabIndex = 1;
            this.btnFilter.Text = "Фильтр";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // toolTipAnd
            // 
            this.toolTipAnd.Tag = "";
            this.toolTipAnd.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // toolTipOr
            // 
            this.toolTipOr.Tag = "";
            this.toolTipOr.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // toolTipLike
            // 
            this.toolTipLike.Tag = "";
            this.toolTipLike.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // DataFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 345);
            this.Controls.Add(this.panelBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DataFilter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filter";
            this.Load += new System.EventHandler(this.DataFilter_Load);
            this.panelBackground.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label labelUnderNote;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox cbHeaders;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnLike;
        private System.Windows.Forms.Button btnOr;
        private System.Windows.Forms.Button btnAnd;
        private System.Windows.Forms.ToolTip toolTipAnd;
        private System.Windows.Forms.ToolTip toolTipOr;
        private System.Windows.Forms.ToolTip toolTipLike;
        private System.Windows.Forms.Label label1;
    }
}