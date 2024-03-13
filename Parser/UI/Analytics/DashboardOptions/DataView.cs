using System.Data;
using System.Windows.Forms;

namespace Parser.UI.Analytics
{
    public partial class DataView : Form
    {
        public DataView(DataSet ds)
        {
            InitializeComponent();

            dataGridView.DataSource = ds.Tables[0];
        }
    }
}
