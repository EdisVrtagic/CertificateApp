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
    public partial class CertificateOverviewControl : UserControl
    {
        public CertificateOverviewControl()
        {
            InitializeComponent();
        }
        private string _certsupp, _certype, _certvfrom, _certvto; //Private fields to store certificate data
        private int _certid; //Private field that stores the certificate ID
        public event EventHandler EditSelect = null; //An event that signifies the selection for certificate editing. EventHandler is a delegate that will be invoked when the event is triggered
        public event EventHandler DeleteSelect = null; //An event that signifies the selection for certificate deleting. EventHandler is a delegate that will be invoked when the event is triggered
        //Property to get or set the Certificate ID
        public int CertID
        {
            get { return _certid; }
            set { _certid = value; }
        }
        //Property to get or set the Certificate Supplier and update the corresponding UI element
        public string CertSupplier
        {
            get { return _certsupp; }
            set { _certsupp = value; SupplierNameC.Text = value; }
        }
        //This event is triggered when the state of the ToggleButton EditDelBtn changes
        private void EditDelBtn_CheckedChanged(object sender, EventArgs e)
        {
            //Check if EditDelBtn is checked
            if (EditDelBtn.Checked)
            {
                //If EditDelBtn is checked, show the EditDelPanel
                EditDelPanel.Show();
            }
            else
            {
                //If EditDelBtn is not checked, hide the EditDelPanel
                EditDelPanel.Hide();
            }
        }

        //Property to get or set the Certificate Type and update the corresponding UI element
        public string CertType
        {
            get { return _certype; }
            set { _certype = value; CertTypeC.Text = value; }
        }
        //Invokes the EditSelect event when the user clicks the edit button
        private void EditBtn_Click(object sender, EventArgs e)
        {
            EditSelect?.Invoke(this, e);
        }
        //Invokes the DeleteSelect event when the user clicks the delete button
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DeleteSelect?.Invoke(this, e);
        }

        //Property to get or set the Certificate Valid From date and update the corresponding UI element
        public string CertValidFrom
        {
            get { return _certvfrom; }
            set { _certvfrom = value; ValidFromC.Text = value; }
        }
        //Property to get or set the Certificate Valid To date and update the corresponding UI element
        public string CertValidTo
        {
            get { return _certvto; }
            set { _certvto = value; ValitToC.Text = value; }
        }
        //Event handler for the CertificateOverviewControl's Load event
        private void CertificateOverviewControl_Load(object sender, EventArgs e)
        {
            EditDelPanel.Hide();
        }
    }
}
