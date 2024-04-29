namespace Parser.UI.Analytics.DashboardOptions
{
    partial class ChatBot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatBot));
            this.panelBackground = new System.Windows.Forms.Panel();
            this.tlpChats = new System.Windows.Forms.TableLayoutPanel();
            this.tlpGigaChat = new System.Windows.Forms.TableLayoutPanel();
            this.tlpGigaChatWorkArea = new System.Windows.Forms.TableLayoutPanel();
            this.btnGigaChatSend = new System.Windows.Forms.Button();
            this.tbGigaChatRequest = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.pnlGigaChatHeader = new System.Windows.Forms.Panel();
            this.lblGigaChat = new System.Windows.Forms.Label();
            this.pnlGigaChatText = new System.Windows.Forms.Panel();
            this.tlpYandexGPT = new System.Windows.Forms.TableLayoutPanel();
            this.tlpYandexGPTWorkArea = new System.Windows.Forms.TableLayoutPanel();
            this.btnYandexGPTSend = new System.Windows.Forms.Button();
            this.tbYandexGPTRequest = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.pnlYandexGPTHeader = new System.Windows.Forms.Panel();
            this.lblYandexGPT = new System.Windows.Forms.Label();
            this.pnlYandexGPTText = new System.Windows.Forms.Panel();
            this.panelBackground.SuspendLayout();
            this.tlpChats.SuspendLayout();
            this.tlpGigaChat.SuspendLayout();
            this.tlpGigaChatWorkArea.SuspendLayout();
            this.pnlGigaChatHeader.SuspendLayout();
            this.tlpYandexGPT.SuspendLayout();
            this.tlpYandexGPTWorkArea.SuspendLayout();
            this.pnlYandexGPTHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBackground
            // 
            this.panelBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panelBackground.Controls.Add(this.tlpChats);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(1200, 800);
            this.panelBackground.TabIndex = 1;
            // 
            // tlpChats
            // 
            this.tlpChats.ColumnCount = 2;
            this.tlpChats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpChats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpChats.Controls.Add(this.tlpYandexGPT, 0, 0);
            this.tlpChats.Controls.Add(this.tlpGigaChat, 0, 0);
            this.tlpChats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpChats.Location = new System.Drawing.Point(0, 0);
            this.tlpChats.Name = "tlpChats";
            this.tlpChats.RowCount = 1;
            this.tlpChats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpChats.Size = new System.Drawing.Size(1200, 800);
            this.tlpChats.TabIndex = 0;
            // 
            // tlpGigaChat
            // 
            this.tlpGigaChat.ColumnCount = 1;
            this.tlpGigaChat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpGigaChat.Controls.Add(this.tlpGigaChatWorkArea, 0, 2);
            this.tlpGigaChat.Controls.Add(this.pnlGigaChatHeader, 0, 0);
            this.tlpGigaChat.Controls.Add(this.pnlGigaChatText, 0, 1);
            this.tlpGigaChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpGigaChat.Location = new System.Drawing.Point(3, 3);
            this.tlpGigaChat.Name = "tlpGigaChat";
            this.tlpGigaChat.RowCount = 3;
            this.tlpGigaChat.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpGigaChat.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82F));
            this.tlpGigaChat.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tlpGigaChat.Size = new System.Drawing.Size(594, 794);
            this.tlpGigaChat.TabIndex = 0;
            // 
            // tlpGigaChatWorkArea
            // 
            this.tlpGigaChatWorkArea.ColumnCount = 2;
            this.tlpGigaChatWorkArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tlpGigaChatWorkArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpGigaChatWorkArea.Controls.Add(this.btnGigaChatSend, 1, 0);
            this.tlpGigaChatWorkArea.Controls.Add(this.tbGigaChatRequest, 0, 0);
            this.tlpGigaChatWorkArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpGigaChatWorkArea.Location = new System.Drawing.Point(0, 730);
            this.tlpGigaChatWorkArea.Margin = new System.Windows.Forms.Padding(0);
            this.tlpGigaChatWorkArea.Name = "tlpGigaChatWorkArea";
            this.tlpGigaChatWorkArea.RowCount = 1;
            this.tlpGigaChatWorkArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpGigaChatWorkArea.Size = new System.Drawing.Size(594, 64);
            this.tlpGigaChatWorkArea.TabIndex = 2;
            // 
            // btnGigaChatSend
            // 
            this.btnGigaChatSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(117)))), ((int)(((byte)(208)))));
            this.btnGigaChatSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGigaChatSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGigaChatSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGigaChatSend.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnGigaChatSend.ForeColor = System.Drawing.Color.White;
            this.btnGigaChatSend.Image = ((System.Drawing.Image)(resources.GetObject("btnGigaChatSend.Image")));
            this.btnGigaChatSend.Location = new System.Drawing.Point(509, 10);
            this.btnGigaChatSend.Margin = new System.Windows.Forms.Padding(5, 10, 50, 20);
            this.btnGigaChatSend.Name = "btnGigaChatSend";
            this.btnGigaChatSend.Size = new System.Drawing.Size(35, 34);
            this.btnGigaChatSend.TabIndex = 2;
            this.btnGigaChatSend.UseVisualStyleBackColor = false;
            this.btnGigaChatSend.Click += new System.EventHandler(this.btnGigaChatSend_Click);
            // 
            // tbGigaChatRequest
            // 
            this.tbGigaChatRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbGigaChatRequest.Location = new System.Drawing.Point(45, 5);
            this.tbGigaChatRequest.Margin = new System.Windows.Forms.Padding(45, 5, 5, 15);
            this.tbGigaChatRequest.Multiline = true;
            this.tbGigaChatRequest.Name = "tbGigaChatRequest";
            this.tbGigaChatRequest.Size = new System.Drawing.Size(454, 44);
            this.tbGigaChatRequest.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(147)))), ((int)(((byte)(238)))));
            this.tbGigaChatRequest.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbGigaChatRequest.StateActive.Border.Rounding = 20;
            this.tbGigaChatRequest.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(117)))), ((int)(((byte)(208)))));
            this.tbGigaChatRequest.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbGigaChatRequest.StateCommon.Border.Rounding = 20;
            this.tbGigaChatRequest.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.tbGigaChatRequest.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbGigaChatRequest.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 5, 10, -1);
            this.tbGigaChatRequest.TabIndex = 1;
            // 
            // pnlGigaChatHeader
            // 
            this.pnlGigaChatHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(117)))), ((int)(((byte)(208)))));
            this.pnlGigaChatHeader.Controls.Add(this.lblGigaChat);
            this.pnlGigaChatHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGigaChatHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pnlGigaChatHeader.Location = new System.Drawing.Point(10, 10);
            this.pnlGigaChatHeader.Margin = new System.Windows.Forms.Padding(10, 10, 150, 10);
            this.pnlGigaChatHeader.Name = "pnlGigaChatHeader";
            this.pnlGigaChatHeader.Size = new System.Drawing.Size(434, 59);
            this.pnlGigaChatHeader.TabIndex = 4;
            this.pnlGigaChatHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGigaChatHeader_Paint);
            // 
            // lblGigaChat
            // 
            this.lblGigaChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGigaChat.Font = new System.Drawing.Font("Segoe UI", 33.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGigaChat.ForeColor = System.Drawing.Color.White;
            this.lblGigaChat.Location = new System.Drawing.Point(0, 0);
            this.lblGigaChat.Margin = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.lblGigaChat.Name = "lblGigaChat";
            this.lblGigaChat.Size = new System.Drawing.Size(434, 59);
            this.lblGigaChat.TabIndex = 2;
            this.lblGigaChat.Text = "GigaChat";
            this.lblGigaChat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlGigaChatText
            // 
            this.pnlGigaChatText.AutoScroll = true;
            this.pnlGigaChatText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pnlGigaChatText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGigaChatText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pnlGigaChatText.Location = new System.Drawing.Point(25, 94);
            this.pnlGigaChatText.Margin = new System.Windows.Forms.Padding(25, 15, 25, 15);
            this.pnlGigaChatText.Name = "pnlGigaChatText";
            this.pnlGigaChatText.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.pnlGigaChatText.Size = new System.Drawing.Size(544, 621);
            this.pnlGigaChatText.TabIndex = 5;
            this.pnlGigaChatText.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGigaChatText_Paint);
            // 
            // tlpYandexGPT
            // 
            this.tlpYandexGPT.ColumnCount = 1;
            this.tlpYandexGPT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpYandexGPT.Controls.Add(this.tlpYandexGPTWorkArea, 0, 2);
            this.tlpYandexGPT.Controls.Add(this.pnlYandexGPTHeader, 0, 0);
            this.tlpYandexGPT.Controls.Add(this.pnlYandexGPTText, 0, 1);
            this.tlpYandexGPT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpYandexGPT.Location = new System.Drawing.Point(603, 3);
            this.tlpYandexGPT.Name = "tlpYandexGPT";
            this.tlpYandexGPT.RowCount = 3;
            this.tlpYandexGPT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpYandexGPT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82F));
            this.tlpYandexGPT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tlpYandexGPT.Size = new System.Drawing.Size(594, 794);
            this.tlpYandexGPT.TabIndex = 1;
            // 
            // tlpYandexGPTWorkArea
            // 
            this.tlpYandexGPTWorkArea.ColumnCount = 2;
            this.tlpYandexGPTWorkArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tlpYandexGPTWorkArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpYandexGPTWorkArea.Controls.Add(this.btnYandexGPTSend, 1, 0);
            this.tlpYandexGPTWorkArea.Controls.Add(this.tbYandexGPTRequest, 0, 0);
            this.tlpYandexGPTWorkArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpYandexGPTWorkArea.Location = new System.Drawing.Point(0, 730);
            this.tlpYandexGPTWorkArea.Margin = new System.Windows.Forms.Padding(0);
            this.tlpYandexGPTWorkArea.Name = "tlpYandexGPTWorkArea";
            this.tlpYandexGPTWorkArea.RowCount = 1;
            this.tlpYandexGPTWorkArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpYandexGPTWorkArea.Size = new System.Drawing.Size(594, 64);
            this.tlpYandexGPTWorkArea.TabIndex = 2;
            // 
            // btnYandexGPTSend
            // 
            this.btnYandexGPTSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(117)))), ((int)(((byte)(208)))));
            this.btnYandexGPTSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYandexGPTSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnYandexGPTSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYandexGPTSend.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnYandexGPTSend.ForeColor = System.Drawing.Color.White;
            this.btnYandexGPTSend.Image = ((System.Drawing.Image)(resources.GetObject("btnYandexGPTSend.Image")));
            this.btnYandexGPTSend.Location = new System.Drawing.Point(509, 10);
            this.btnYandexGPTSend.Margin = new System.Windows.Forms.Padding(5, 10, 50, 20);
            this.btnYandexGPTSend.Name = "btnYandexGPTSend";
            this.btnYandexGPTSend.Size = new System.Drawing.Size(35, 34);
            this.btnYandexGPTSend.TabIndex = 2;
            this.btnYandexGPTSend.UseVisualStyleBackColor = false;
            this.btnYandexGPTSend.Click += new System.EventHandler(this.btnYandexGPTSend_Click);
            // 
            // tbYandexGPTRequest
            // 
            this.tbYandexGPTRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbYandexGPTRequest.Location = new System.Drawing.Point(45, 5);
            this.tbYandexGPTRequest.Margin = new System.Windows.Forms.Padding(45, 5, 5, 15);
            this.tbYandexGPTRequest.Multiline = true;
            this.tbYandexGPTRequest.Name = "tbYandexGPTRequest";
            this.tbYandexGPTRequest.Size = new System.Drawing.Size(454, 44);
            this.tbYandexGPTRequest.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(147)))), ((int)(((byte)(238)))));
            this.tbYandexGPTRequest.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbYandexGPTRequest.StateActive.Border.Rounding = 20;
            this.tbYandexGPTRequest.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(117)))), ((int)(((byte)(208)))));
            this.tbYandexGPTRequest.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbYandexGPTRequest.StateCommon.Border.Rounding = 20;
            this.tbYandexGPTRequest.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.tbYandexGPTRequest.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbYandexGPTRequest.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 5, 10, -1);
            this.tbYandexGPTRequest.TabIndex = 1;
            // 
            // pnlYandexGPTHeader
            // 
            this.pnlYandexGPTHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(117)))), ((int)(((byte)(208)))));
            this.pnlYandexGPTHeader.Controls.Add(this.lblYandexGPT);
            this.pnlYandexGPTHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlYandexGPTHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pnlYandexGPTHeader.Location = new System.Drawing.Point(10, 10);
            this.pnlYandexGPTHeader.Margin = new System.Windows.Forms.Padding(10, 10, 150, 10);
            this.pnlYandexGPTHeader.Name = "pnlYandexGPTHeader";
            this.pnlYandexGPTHeader.Size = new System.Drawing.Size(434, 59);
            this.pnlYandexGPTHeader.TabIndex = 4;
            this.pnlYandexGPTHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlYandexGPTHeader_Paint);
            // 
            // lblYandexGPT
            // 
            this.lblYandexGPT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblYandexGPT.Font = new System.Drawing.Font("Segoe UI", 33.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblYandexGPT.ForeColor = System.Drawing.Color.White;
            this.lblYandexGPT.Location = new System.Drawing.Point(0, 0);
            this.lblYandexGPT.Margin = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.lblYandexGPT.Name = "lblYandexGPT";
            this.lblYandexGPT.Size = new System.Drawing.Size(434, 59);
            this.lblYandexGPT.TabIndex = 2;
            this.lblYandexGPT.Text = "YandexGPT";
            this.lblYandexGPT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlYandexGPTText
            // 
            this.pnlYandexGPTText.AutoScroll = true;
            this.pnlYandexGPTText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pnlYandexGPTText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlYandexGPTText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pnlYandexGPTText.Location = new System.Drawing.Point(25, 94);
            this.pnlYandexGPTText.Margin = new System.Windows.Forms.Padding(25, 15, 25, 15);
            this.pnlYandexGPTText.Name = "pnlYandexGPTText";
            this.pnlYandexGPTText.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.pnlYandexGPTText.Size = new System.Drawing.Size(544, 621);
            this.pnlYandexGPTText.TabIndex = 5;
            this.pnlYandexGPTText.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlYandexGPTText_Paint);
            // 
            // ChatBot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.panelBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChatBot";
            this.Text = "ChatBot";
            this.panelBackground.ResumeLayout(false);
            this.tlpChats.ResumeLayout(false);
            this.tlpGigaChat.ResumeLayout(false);
            this.tlpGigaChatWorkArea.ResumeLayout(false);
            this.tlpGigaChatWorkArea.PerformLayout();
            this.pnlGigaChatHeader.ResumeLayout(false);
            this.tlpYandexGPT.ResumeLayout(false);
            this.tlpYandexGPTWorkArea.ResumeLayout(false);
            this.tlpYandexGPTWorkArea.PerformLayout();
            this.pnlYandexGPTHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.TableLayoutPanel tlpChats;
        private System.Windows.Forms.TableLayoutPanel tlpGigaChat;
        private System.Windows.Forms.TableLayoutPanel tlpGigaChatWorkArea;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbGigaChatRequest;
        private System.Windows.Forms.Button btnGigaChatSend;
        private System.Windows.Forms.Label lblGigaChat;
        private System.Windows.Forms.Panel pnlGigaChatHeader;
        private System.Windows.Forms.Panel pnlGigaChatText;
        private System.Windows.Forms.TableLayoutPanel tlpYandexGPT;
        private System.Windows.Forms.TableLayoutPanel tlpYandexGPTWorkArea;
        private System.Windows.Forms.Button btnYandexGPTSend;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbYandexGPTRequest;
        private System.Windows.Forms.Panel pnlYandexGPTHeader;
        private System.Windows.Forms.Label lblYandexGPT;
        private System.Windows.Forms.Panel pnlYandexGPTText;
    }
}