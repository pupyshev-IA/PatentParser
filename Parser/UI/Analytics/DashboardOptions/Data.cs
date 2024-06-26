﻿using System;
using System.Data;
using System.Windows.Forms;
using Parser.Models.main;
using Parser.UI.DialogForm;

namespace Parser.UI.Analytics.DashboardOptions
{
    public partial class Data : Form
    {
        Dashboard dashboard;
        DataFilter filter;
        DataSet dataSet;

        private int selectedIndex;
        private string selectedLink, selectedDocNum;
        public int SelectedIndex { get => selectedIndex; }
        public string SelectedLink { get => selectedLink; }
        public string SelectedDocNum { get => selectedDocNum; }

        public Data(Dashboard dashboard, DataSet ds)
        {
            InitializeComponent();

            this.dashboard = dashboard;
            dataSet = ds;
            dataGridView.DataSource = dataSet.Tables[0];
            selectedLink = dataGridView.Rows[0].Cells["Ссылка"].Value.ToString();
            if (selectedLink.Contains("fips"))
                selectedDocNum = dataGridView.Rows[0].Cells["Номер документа"].Value.ToString();
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var cellURL = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

            if (cellURL.Contains("http"))
            {
                var docNum = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value.ToString();

                LinkNavigator navigator = new LinkNavigator();
                navigator.OpenLink(cellURL, docNum);
            }
        }

        private void dataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            selectedIndex = e.RowIndex;
            selectedLink = dataGridView.Rows[e.RowIndex].Cells["Ссылка"].Value.ToString();
            if (selectedLink.Contains("fips"))
                selectedDocNum = dataGridView.Rows[e.RowIndex].Cells["Номер документа"].Value.ToString();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (filter != null)
            {
                filter.ShowDialog();
                if (filter.FilteredTable != null)
                    dataGridView.DataSource = filter.FilteredTable; 
                return;
            }

            filter = new DataFilter(dataSet.Tables[0]);
            filter.ShowDialog();

            if (filter.FilteredTable != null)
                dataGridView.DataSource = filter.FilteredTable;
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            if (filter != null)
            {
                filter.Close();
                filter = null;
                dataGridView.DataSource = dataSet.Tables[0];
            }
        }

        private void btnPatentInfo_Click(object sender, EventArgs e)
        {
            dashboard.ClickPatentInfoButton();
        }
    }
}
