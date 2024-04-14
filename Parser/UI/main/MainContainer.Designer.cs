namespace Parser.UI.main
{
    partial class MainContainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainContainer));
            this.menuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.глобальныйПоискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.простойПоискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer_out = new System.Windows.Forms.SplitContainer();
            this.splitContainer_in = new System.Windows.Forms.SplitContainer();
            this.kryptonPalette = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.поискПоСайтуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фИПСToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.яндексПатентыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.wIPOToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.espacenetToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_out)).BeginInit();
            this.splitContainer_out.Panel2.SuspendLayout();
            this.splitContainer_out.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_in)).BeginInit();
            this.splitContainer_in.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_Main
            // 
            this.menuStrip_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.menuStrip_Main.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Main.Name = "menuStrip_Main";
            this.menuStrip_Main.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip_Main.Size = new System.Drawing.Size(1384, 25);
            this.menuStrip_Main.TabIndex = 0;
            this.menuStrip_Main.Text = "menuStrip_Main";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 21);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.глобальныйПоискToolStripMenuItem,
            this.простойПоискToolStripMenuItem,
            this.поискПоСайтуToolStripMenuItem});
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.поискToolStripMenuItem.Text = "Поиск";
            // 
            // глобальныйПоискToolStripMenuItem
            // 
            this.глобальныйПоискToolStripMenuItem.Name = "глобальныйПоискToolStripMenuItem";
            this.глобальныйПоискToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.глобальныйПоискToolStripMenuItem.Text = "Глобальный поиск";
            // 
            // простойПоискToolStripMenuItem
            // 
            this.простойПоискToolStripMenuItem.Name = "простойПоискToolStripMenuItem";
            this.простойПоискToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.простойПоискToolStripMenuItem.Text = "Простой поиск";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(83, 21);
            this.settingsToolStripMenuItem.Text = "Настройки";
            // 
            // splitContainer_out
            // 
            this.splitContainer_out.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.splitContainer_out.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer_out.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_out.Location = new System.Drawing.Point(0, 25);
            this.splitContainer_out.Name = "splitContainer_out";
            // 
            // splitContainer_out.Panel1
            // 
            this.splitContainer_out.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.splitContainer_out.Panel1MinSize = 200;
            // 
            // splitContainer_out.Panel2
            // 
            this.splitContainer_out.Panel2.Controls.Add(this.splitContainer_in);
            this.splitContainer_out.Size = new System.Drawing.Size(1384, 836);
            this.splitContainer_out.SplitterDistance = 220;
            this.splitContainer_out.TabIndex = 1;
            // 
            // splitContainer_in
            // 
            this.splitContainer_in.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer_in.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_in.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_in.Name = "splitContainer_in";
            // 
            // splitContainer_in.Panel1
            // 
            this.splitContainer_in.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.splitContainer_in.Panel1MinSize = 200;
            // 
            // splitContainer_in.Panel2
            // 
            this.splitContainer_in.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.splitContainer_in.Panel2MinSize = 200;
            this.splitContainer_in.Size = new System.Drawing.Size(1160, 836);
            this.splitContainer_in.SplitterDistance = 550;
            this.splitContainer_in.TabIndex = 0;
            // 
            // kryptonPalette
            // 
            this.kryptonPalette.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.kryptonPalette.ButtonSpecs.FormClose.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPalette.ButtonSpecs.FormClose.Image")));
            this.kryptonPalette.ButtonSpecs.FormMax.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPalette.ButtonSpecs.FormMax.Image")));
            this.kryptonPalette.ButtonSpecs.FormMin.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPalette.ButtonSpecs.FormMin.Image")));
            this.kryptonPalette.ButtonSpecs.FormRestore.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPalette.ButtonSpecs.FormRestore.Image")));
            this.kryptonPalette.FormStyles.FormCommon.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette.FormStyles.FormCommon.StateCommon.Border.Rounding = 5;
            this.kryptonPalette.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.kryptonPalette.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.kryptonPalette.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette.FormStyles.FormMain.StateCommon.Border.Rounding = 12;
            this.kryptonPalette.HeaderStyles.HeaderCommon.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.kryptonPalette.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.kryptonPalette.HeaderStyles.HeaderForm.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kryptonPalette.HeaderStyles.HeaderForm.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kryptonPalette.HeaderStyles.HeaderForm.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 12;
            this.kryptonPalette.HeaderStyles.HeaderForm.StateCommon.ButtonPadding = new System.Windows.Forms.Padding(5, 3, -1, -1);
            this.kryptonPalette.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.kryptonPalette.ToolMenuStatus.Menu.MenuItemBorder = System.Drawing.Color.Black;
            this.kryptonPalette.ToolMenuStatus.Menu.MenuItemSelectedGradientBegin = System.Drawing.Color.White;
            this.kryptonPalette.ToolMenuStatus.Menu.MenuItemSelectedGradientEnd = System.Drawing.Color.White;
            this.kryptonPalette.ToolMenuStatus.MenuStrip.MenuStripGradientBegin = System.Drawing.Color.White;
            this.kryptonPalette.ToolMenuStatus.MenuStrip.MenuStripGradientEnd = System.Drawing.Color.White;
            // 
            // поискПоСайтуToolStripMenuItem
            // 
            this.поискПоСайтуToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.фИПСToolStripMenuItem1,
            this.яндексПатентыToolStripMenuItem1,
            this.wIPOToolStripMenuItem1,
            this.espacenetToolStripMenuItem1});
            this.поискПоСайтуToolStripMenuItem.Name = "поискПоСайтуToolStripMenuItem";
            this.поискПоСайтуToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.поискПоСайтуToolStripMenuItem.Text = "Поиск по сайту";
            // 
            // фИПСToolStripMenuItem1
            // 
            this.фИПСToolStripMenuItem1.Name = "фИПСToolStripMenuItem1";
            this.фИПСToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.фИПСToolStripMenuItem1.Text = "ФИПС";
            // 
            // яндексПатентыToolStripMenuItem1
            // 
            this.яндексПатентыToolStripMenuItem1.Name = "яндексПатентыToolStripMenuItem1";
            this.яндексПатентыToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.яндексПатентыToolStripMenuItem1.Text = "Яндекс.Патенты";
            // 
            // wIPOToolStripMenuItem1
            // 
            this.wIPOToolStripMenuItem1.Name = "wIPOToolStripMenuItem1";
            this.wIPOToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.wIPOToolStripMenuItem1.Text = "WIPO";
            // 
            // espacenetToolStripMenuItem1
            // 
            this.espacenetToolStripMenuItem1.Name = "espacenetToolStripMenuItem1";
            this.espacenetToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.espacenetToolStripMenuItem1.Text = "Espacenet";
            // 
            // MainContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1384, 861);
            this.Controls.Add(this.splitContainer_out);
            this.Controls.Add(this.menuStrip_Main);
            this.MainMenuStrip = this.menuStrip_Main;
            this.Name = "MainContainer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainContainer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainContainer_Load);
            this.menuStrip_Main.ResumeLayout(false);
            this.menuStrip_Main.PerformLayout();
            this.splitContainer_out.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_out)).EndInit();
            this.splitContainer_out.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_in)).EndInit();
            this.splitContainer_in.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer_out;
        private System.Windows.Forms.SplitContainer splitContainer_in;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem глобальныйПоискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem простойПоискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискПоСайтуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фИПСToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem яндексПатентыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem wIPOToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem espacenetToolStripMenuItem1;
    }
}