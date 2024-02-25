using System.Data;
using System.Windows.Forms;

namespace Parser.UI.Analytics
{
    public partial class optionDataView : Form
    {
        public optionDataView(DataSet ds)
        {
            InitializeComponent();

            dataGridView.DataSource = ds.Tables[0];
        }
    }
}
