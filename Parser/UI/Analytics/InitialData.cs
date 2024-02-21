using System.Data;
using System.Windows.Forms;

namespace Parser.UI.Analytics
{
    public partial class InitialData : Form
    {
        public InitialData(DataSet ds)
        {
            InitializeComponent();

            dataGridView.DataSource = ds.Tables[0];
        }
    }
}
