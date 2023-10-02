using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CertificateApp
{
    public partial class SupplierControl : UserControl
    {
        public SupplierControl()
        {
            InitializeComponent();
        }
        private string _suppname, _suppindex, _suppcity; //Private fields to store certificate data
        public event EventHandler RadioSelect; //RadioSelect handler
        //Property to get or set the Supplier and update the corresponding UI element
        public string NameSupplier
        {
            get { return _suppname; }
            set { _suppname = value; SUPNInfo.Text = value; }
        }
        //Property to get or set the Supplier Index and update the corresponding UI element
        public string IndexSupplier
        {
            get { return _suppindex; }
            set { _suppindex = value; SUPIInfo.Text = value; }
        }
        //RadioSelect checkedchanged
        private void RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioSelect != null)
            {
                RadioSelect(this, EventArgs.Empty);
            }
        }
        //Property to get or set the Supplier City and update the corresponding UI element
        public string CitySupplier
        {
            get { return _suppcity; }
            set { _suppcity = value; SUPCInfo.Text = value; }
        }
        //Event handler for the SupplierControl's Load event
        private void SupplierControl_Load(object sender, EventArgs e)
        {

        }
    }
}
