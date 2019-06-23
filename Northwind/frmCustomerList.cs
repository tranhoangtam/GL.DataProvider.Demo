using GL.DataProvider;
using Northwind.DataAccess;
using Northwind.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind
{
    public partial class frmCustomerList : Form
    {
        public frmCustomerList()
        {
            InitializeComponent();
        }

        private void FrmCustomerList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwindDataSet.Customers' table. You can move, or remove it, as needed.
            //this.customersTableAdapter.Fill(this.northwindDataSet.Customers);
            //Option 1
            SqlHelper.ConnectionString = Settings.Default.ConnectionString;
            SqlHelper.Helper.Fill(CommandType.Text, "Select * from customers", northwindDataSet.Customers);
            //Option 2
            var sql = new SqlProvider(Settings.Default.ConnectionString);
            sql.Fill(CommandType.Text, "select * from customers", northwindDataSet.Customers);
            //Option 3
            var dao = new CustomersDA();
            dao.Fill(northwindDataSet.Customers);
        }
    }
}
