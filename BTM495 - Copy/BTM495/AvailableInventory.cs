using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTM495
{
    public partial class AvailableInventory : Form
    {
        public AvailableInventory()
        {
            InitializeComponent();
        }
        private void AvailableInventory_Load(object sender, EventArgs e)
        {
            DataAccess gridViewSource = new DataAccess();
            
            ProductsDataGridView.DataSource = gridViewSource.GetProducts();
        }
    }
}
