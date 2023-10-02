using System;
using System.Windows.Forms;

namespace CertificateApp
{
    public partial class ParticipantControl : UserControl
    {
        public ParticipantControl()
        {
            InitializeComponent();
        }
        private string _namepart, _depapart, _emapart; //Private fields to store participant data
        private int _partid; //Private field that stores the participant ID
        public event EventHandler DeleteSelect = null; //Handler on delete participant
        //Identification number of the participant ID
        public int IDPart
        {
            get { return _partid; }
            set { _partid = value; }
        }
        //Name of the participant
        public string NameParticipant
        {
            get { return _namepart; }
            set { _namepart = value; PartNameBox.Text = value; }
        }
        //Department of the participant
        public string DepartmentParticipant
        {
            get { return _depapart; }
            set { _depapart = value; PartDepBox.Text = value; }
        }
        //Email of the participant
        public string EmailParticipant
        {
            get { return _emapart; }
            set { _emapart = value; PartEmailBox.Text = value; }
        }
        //Delete participant button
        private void DeletePartBtn_Click(object sender, EventArgs e)
        {
            DeleteSelect?.Invoke(this, e);
        }
        private void ParticipantControl_Load(object sender, EventArgs e)
        {

        }
    }
}
