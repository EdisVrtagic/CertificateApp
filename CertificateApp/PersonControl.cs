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
    public partial class PersonControl : UserControl
    {
        public PersonControl()
        {
            InitializeComponent();
        }
        private string _nameper, _fnameper, _userid, _depart, _plantp; //Private fields to store person data
        private int _perid; //Private field that stores the person ID
        //Identification number of the person ID
        public int IDPerson
        {
            get { return _perid; }
            set { _perid = value; }
        }
        //Last name of the person
        public string NamePerson
        {
            get { return _nameper; }
            set { _nameper = value; PerName.Text = value; }
        }
        //First name of the person
        public string FirstNamePerson
        {
            get { return _fnameper; }
            set { _fnameper = value; PerFName.Text = value; }
        }
        //User ID of the person
        public string UserIDPerson
        {
            get { return _userid; }
            set { _userid = value; PerUserID.Text = value; }
        }
        //Department where the person works
        public string DepartmentPerson
        {
            get { return _depart; }
            set { _depart = value; PerDepar.Text = value; }
        }
        //Location where the person works
        public string PlantPerson
        {
            get { return _plantp; }
            set { _plantp = value; PerPlant.Text = value; }
        }
        private void PersonControl_Load(object sender, EventArgs e)
        {

        }
    }
}
