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
            this.tbRequest = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.pnlGigaChatHeader = new System.Windows.Forms.Panel();
            this.lblChatName = new System.Windows.Forms.Label();
            this.pnlGigaChatText = new System.Windows.Forms.Panel();
            this.panelBackground.SuspendLayout();
            this.tlpChats.SuspendLayout();
            this.tlpGigaChat.SuspendLayout();
            this.tlpGigaChatWorkArea.SuspendLayout();
            this.pnlGigaChatHeader.SuspendLayout();
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
            this.tlpGigaChat.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpGigaChat.Size = new System.Drawing.Size(594, 794);
            this.tlpGigaChat.TabIndex = 0;
            // 
            // tlpGigaChatWorkArea
            // 
            this.tlpGigaChatWorkArea.ColumnCount = 2;
            this.tlpGigaChatWorkArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tlpGigaChatWorkArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpGigaChatWorkArea.Controls.Add(this.btnGigaChatSend, 1, 0);
            this.tlpGigaChatWorkArea.Controls.Add(this.tbRequest, 0, 0);
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
            // tbRequest
            // 
            this.tbRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbRequest.Location = new System.Drawing.Point(45, 5);
            this.tbRequest.Margin = new System.Windows.Forms.Padding(45, 5, 5, 15);
            this.tbRequest.Multiline = true;
            this.tbRequest.Name = "tbRequest";
            this.tbRequest.Size = new System.Drawing.Size(454, 44);
            this.tbRequest.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(147)))), ((int)(((byte)(238)))));
            this.tbRequest.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbRequest.StateActive.Border.Rounding = 20;
            this.tbRequest.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(117)))), ((int)(((byte)(208)))));
            this.tbRequest.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbRequest.StateCommon.Border.Rounding = 20;
            this.tbRequest.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.tbRequest.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRequest.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 5, 10, -1);
            this.tbRequest.TabIndex = 1;
            // 
            // pnlGigaChatHeader
            // 
            this.pnlGigaChatHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(117)))), ((int)(((byte)(208)))));
            this.pnlGigaChatHeader.Controls.Add(this.lblChatName);
            this.pnlGigaChatHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGigaChatHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pnlGigaChatHeader.Location = new System.Drawing.Point(10, 10);
            this.pnlGigaChatHeader.Margin = new System.Windows.Forms.Padding(10, 10, 150, 10);
            this.pnlGigaChatHeader.Name = "pnlGigaChatHeader";
            this.pnlGigaChatHeader.Size = new System.Drawing.Size(434, 59);
            this.pnlGigaChatHeader.TabIndex = 4;
            this.pnlGigaChatHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGigaChatHeader_Paint);
            // 
            // lblChatName
            // 
            this.lblChatName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblChatName.Font = new System.Drawing.Font("Segoe UI", 33.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblChatName.ForeColor = System.Drawing.Color.White;
            this.lblChatName.Location = new System.Drawing.Point(0, 0);
            this.lblChatName.Margin = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.lblChatName.Name = "lblChatName";
            this.lblChatName.Size = new System.Drawing.Size(434, 59);
            this.lblChatName.TabIndex = 2;
            this.lblChatName.Text = "GigaChat";
            this.lblChatName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.TableLayoutPanel tlpChats;
        private System.Windows.Forms.TableLayoutPanel tlpGigaChat;
        private System.Windows.Forms.TableLayoutPanel tlpGigaChatWorkArea;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbRequest;
        private System.Windows.Forms.Button btnGigaChatSend;
        private System.Windows.Forms.Label lblChatName;
        private System.Windows.Forms.Panel pnlGigaChatHeader;
        private System.Windows.Forms.Panel pnlGigaChatText;
    }
}