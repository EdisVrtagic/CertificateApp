using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace CertificateApp
{
    public partial class AppMainForm : Form
    {
        //Database connection
        private readonly static string conect = ConfigurationManager.ConnectionStrings["CERTCON"].ConnectionString;
        private readonly SqlConnection Con = new SqlConnection(conect);
        public AppMainForm()
        {
            InitializeComponent();
        }
        //Method called when the form is loaded
        private void Form1_Load(object sender, EventArgs e)
        {
            VisibleComponents(); //Calls the function to set component visibility
        }
        //Method to set the visibility of specific components
        private void VisibleComponents()
        {
            UserAdLabel.Text = UserSelectBox.SelectedItem.ToString(); //Default selection of the first index
            CertValidFromBox.Value = DateTime.Now; //Sets the Valid from date to the current date and time
            CertValidToBox.Value = DateTime.Now; //Sets the Valid to date to the current date and time
            MachLearBtn.Hide(); //Hide the machine learning button
            ArrowPic.Hide(); //Hide the arrow picture
            ExamplePanel.Hide(); //Hide the example panel
            CertOverviewPanel.Location = new Point(249, 47); //Location the certificate overview panel
            CertOverviewPanel.Hide(); //Hide the certificate overview panel
            NewCertificatePanel.Location = new Point(249, 10); //Location the new certificate panel
            NewCertificatePanel.Hide(); //Hide the new certificate panel
            SuppListPanel.Location = new Point(362, 47); //Location the dialog supp list panel
            SuppListPanel.Hide(); //Hide the dialog supp list panel
            SupplierListPanel.Hide(); //Hide the Supplier list panel
            SearchPersonPanel.Location = new Point(362, 10); //Location the SearchPersonPanel panel
            SearchPersonPanel.Hide(); //Hide the SearchPersonPanel
            PersListPanel.Hide(); //Hide the Person list panel
            DynamicParticipantControl(); //Show the participant dynamic control
            AddCommentPanel.Hide(); //Hide the add comment panel
            CommentViewPanel.Hide(); //Hide the comment view panel
        }
        //Method called when the start button is clicked
        private void StartBtn_Click(object sender, EventArgs e)
        {
            if (StartBtn.Checked == true)
            {
                MachLearBtn.Show(); //Show the machine learning button
                ArrowPic.Show(); //Show the arrow picture
                NewCertificatePanel.Enabled = true; //New certificate panel enabled
                SearchPersonPanel.Hide(); //Hide the search person panel
                AddCommentPanel.Hide(); //Hide comment panel
                CommentViewPanel.Hide(); //Hide comment view panel 
            }
            else
            {
                ExamplePanelTransition.HideSync(ExamplePanel); //Hide the example panel with a transition
                MachLearBtn.Checked = false; //Set the machine learning button's checked state to false
                MachLearBtn.Hide(); //Hide the machine learning button
                ArrowPic.Hide(); //Hide the arrow picture
                ExampleBtn1.Checked = false; //Set the ExampleBtn1 button's checked state to false
                ExampleBtn2.Checked = false; //Set the ExampleBtn2 button's checked state to false
                ExampleBtn3.Checked = false; //Set the ExampleBtn3 button's checked state to false
                CertOverviewPanel.Hide(); //Hides the certificate overview panel
                NewCertificatePanel.Hide(); //Hide the new certificate panel
                SuppListPanel.Hide(); //Hide the dialog supp list panel
                SearchPersonPanel.Hide(); //Hide the search person panel
                AddCommentPanel.Hide(); //Hide comment panel
                CommentViewPanel.Hide(); //Hide comment view panel 
            }
        }
        //Method called when the machine learning button is clicked
        private void MachLearBtn_Click(object sender, EventArgs e)
        {
            if (MachLearBtn.Checked == true)
            {
                ExamplePanelTransition.ShowSync(ExamplePanel); //Show the example panel with a transition
                NewCertificatePanel.Enabled = true; //New certificate panel enabled
                SuppListPanel.Hide(); //Hide the dialog supp list panel
                SearchPersonPanel.Hide(); //Hide the search person panel
                AddCommentPanel.Hide(); //Hide comment panel
                CommentViewPanel.Hide(); //Hide comment view panel 
            }
            else
            {
                ExamplePanelTransition.HideSync(ExamplePanel); //Hide the example panel with a transition
                NewCertificatePanel.Enabled = true; //New certificate panel enabled
                SuppListPanel.Hide(); //Hide the dialog supp list panel
                SearchPersonPanel.Hide(); //Hide the search person panel
                AddCommentPanel.Hide(); //Hide comment panel
                CommentViewPanel.Hide(); //Hide comment view panel 
            }
        }
        //Method called when the selected language in the drop down menu changes
        private void LanguageSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectLangIndex = LanguageSelectBox.SelectedIndex;
            //Checks which language is selected and calls the appropriate function to set language options
            if (selectLangIndex == 0)
            {
                LanguageEnglish(); //Sets the language to English
            }
            else if (selectLangIndex == 1)
            {
                LanguageBosanski(); //Sets the language to Bosnian
            }
        }
        //Method for setting language options to English
        private void LanguageEnglish()
        {
            LangLabel.Text = "Language:";
            UserLabel.Text = "User:";
            StartBtn.Text = "Start";
            MachLearBtn.Text = "Machine Learning";
            ExampleBtn1.Text = "Example 1";
            ExampleBtn2.Text = "Example 2";
            ExampleBtn3.Text = "Example 3";
            NewCertBtn.Text = "New certificate";
            SuppLbl.Text = "Supplier";
            CertLbl.Text = "Certificate type";
            VaFromLbl.Text = "Valid from";
            VaToLbl.Text = "Valid to";
            NewCertLabel.Text = "New certificate";
            SuppNewCertLabel.Text = "Supplier";
            CertNewCertLabel.Text = "Certificate type";
            VFromNewCertLabel.Text = "Valid from";
            VToNewCertLabel.Text = "Valid to";
            SaveCertBtn.Text = "Save";
            EditCertBtn.Text = "Edit";
            SearchSuppLabel.Text = "Search for suppliers";
            SearchCriteriaLabel.Text = "Search criteria";
            SearchSuppNameLabel.Text = "Supplier name";
            SearchSuppIndexLabel.Text = "Supplier index";
            SearchSuppCityLabel.Text = "City";
            SearchSupplierBtn.Text = "Search";
            ResetSupplierBtn.Text = "Reset";
            SupplierListLabel.Text = "Supplier list";
            SLabel1.Text = "Supplier name";
            IndexLabel1.Text = "Supplier index";
            CityLabel1.Text = "City";
            SelectSuppBtn.Text = "Select";
            CancelSuppBtn.Text = "Cancel";
            SeaForPerLabel.Text = "Search for persons";
            SeaCriLabel.Text = "Search criteria";
            SeaNameLabel.Text = "Name";
            SeaFNameLabel.Text = "First name";
            SeaUseIDLabel.Text = "User ID";
            SeaDepaLabel.Text = "Department";
            SeaPlantLabel.Text = "Plant";
            SeaPerBtn.Text = "Search";
            SeaPerReset.Text = "Reset";
            PerListLabel.Text = "Person list";
            PerNameLabel.Text = "Name";
            PerFNameLabel.Text = "First name";
            PerUseIDLabel.Text = "User ID";
            PerDepaLabel.Text = "Department";
            PerPlantLabel.Text = "Plant";
            PerSelectBtn.Text = "Select";
            PerCancBtn.Text = "Cancel";
            AddParticipantBtn.Text = "Add participant";
            NamePartLabel.Text = "Name";
            DepaPartLabel.Text = "Department";
            EmailPartLabel.Text = "E-mail";
            AssigLabel.Text = "Assigned users";
            UserComLabel.Text = "User:";
            ComComLabel.Text = "Comment:";
            NewCommentBtn.Text = "New comment";
            CommentBtn.Text = "Comment";
            commentTextBox.PlaceholderText = "comment";
        }
        //Method for setting language options to Bosnian
        private void LanguageBosanski()
        {
            LangLabel.Text = "Jezik:";
            StartBtn.Text = "Pocetak";
            MachLearBtn.Text = "Masinsko ucenje";
            ExampleBtn1.Text = "Primjer 1";
            ExampleBtn2.Text = "Primjer 2";
            ExampleBtn3.Text = "Primjer 3";
            NewCertBtn.Text = "Novi certifikat";
            SuppLbl.Text = "Dobavljac";
            CertLbl.Text = "Vrsta certifikata";
            VaFromLbl.Text = "Vrijedi od";
            VaToLbl.Text = "Vrijedi do";
            NewCertLabel.Text = "Novi certifikat";
            SuppNewCertLabel.Text = "Dobavljac";
            CertNewCertLabel.Text = "Vrsta certifikata";
            VFromNewCertLabel.Text = "Vrijedi od";
            VToNewCertLabel.Text = "Vrijedi do";
            SaveCertBtn.Text = "Spremi";
            EditCertBtn.Text = "Izmijeni";
            SearchSuppLabel.Text = "Pretrazi dobavljace";
            SearchCriteriaLabel.Text = "Kriteriji pretrage";
            SearchSuppNameLabel.Text = "Ime dobavljaca";
            SearchSuppIndexLabel.Text = "Indeks dobavljaca";
            SearchSuppCityLabel.Text = "Grad";
            SearchSupplierBtn.Text = "Pretrazi";
            ResetSupplierBtn.Text = "Resetuj";
            SupplierListLabel.Text = "Lista dobavljaca";
            SLabel1.Text = "Ime dobavljaca";
            IndexLabel1.Text = "Indeks dobavljaca";
            CityLabel1.Text = "Grad";
            SelectSuppBtn.Text = "Odaberi";
            CancelSuppBtn.Text = "Otkazi";
            SeaForPerLabel.Text = "Pretrazivanje osoba";
            SeaCriLabel.Text = "Kriteriji pretrage";
            SeaNameLabel.Text = "Prezime";
            SeaFNameLabel.Text = "Ime";
            SeaUseIDLabel.Text = "Korisnicki ID";
            SeaDepaLabel.Text = "Odjel";
            SeaPlantLabel.Text = "Lokacija";
            SeaPerBtn.Text = "Pretrazi";
            SeaPerReset.Text = "Resetuj";
            PerListLabel.Text = "Lista osoba";
            PerNameLabel.Text = "Prezime";
            PerFNameLabel.Text = "Ime";
            PerUseIDLabel.Text = "Korisnicki ID";
            PerDepaLabel.Text = "Odjel";
            PerPlantLabel.Text = "Lokacija";
            PerSelectBtn.Text = "Odaberi";
            PerCancBtn.Text = "Otkazi";
            AddParticipantBtn.Text = "Dodaj ucesnika";
            NamePartLabel.Text = "Ime";
            DepaPartLabel.Text = "Odjel";
            EmailPartLabel.Text = "E-mail";
            AssigLabel.Text = "Dodijeljeni korisnici";
            UserLabel.Text = "Korisnik:";
            UserComLabel.Text = "Korisnik:";
            ComComLabel.Text = "Komentar:";
            NewCommentBtn.Text = "Novi komentar";
            CommentBtn.Text = "Komentar";
            commentTextBox.PlaceholderText = "komentarisi";
        }
        //Method called when the Example 1 button is clicked
        private void ExampleBtn1_Click(object sender, EventArgs e)
        {
            if (ExampleBtn1.Checked == true)
            {
                NewCertificatePanel.Hide(); //Hide the new certificate panel
                NewCertificatePanel.Enabled = true; //New certificate panel enabled
                ExampleBtn2.Checked = false; //If Example 1 button is selected, unchecks the Example 2 button
                ExampleBtn3.Checked = false; //If Example 1 button is selected, unchecks the Example 3 button
                DynamicCertificationControl(); //Refreshes the certificate display by calling the DynamicCertificationControl function
                CertOverviewPanel.Show(); //Shows the certificate overview panel
                SuppListPanel.Hide(); //Hide the dialog supp list panel
                SearchPersonPanel.Hide(); //Hide the search person panel
                AddCommentPanel.Hide(); //Hide comment panel
                CommentViewPanel.Hide(); //Hide comment view panel 
            }
        }
        // Method called when the Example 2 button is clicked
        private void ExampleBtn2_Click(object sender, EventArgs e)
        {
            if (ExampleBtn2.Checked == true)
            {
                ExampleBtn1.Checked = false; //If Example 2 button is selected, unchecks the Example 1 button
                ExampleBtn3.Checked = false; //If Example 2 button is selected, unchecks the Example 1 button
                CertOverviewPanel.Hide(); //Hides the certificate overview panel
                NewCertificatePanel.Enabled = true; //New certificate panel enabled
                NewCertificatePanel.Hide(); //Hide the new certificate panel
                SuppListPanel.Hide(); //Hide the dialog supp list panel
                SearchPersonPanel.Hide(); //Hide the search person panel
                AddCommentPanel.Hide(); //Hide comment panel
                CommentViewPanel.Hide(); //Hide comment view panel 
            }
        }
        // Method called when the New Certificate button is clicked
        private void NewCertBtn_Click(object sender, EventArgs e)
        {
            NewCertificatePanel.Enabled = true; //New certificate panel enabled
            CertOverviewPanel.Hide(); //Hide the certificate overview panel
            NewCertificatePanel.Show(); //Shows the panel for creating a new certificate
            SearchPersonPanel.Hide(); //Hide the search person panel
        }
        //Save certificate in database
        private void SaveCertBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Checks if the mandatory fields are filled
                if (SuppNameBox.Text == "" || CertTypeBox.SelectedIndex == -1 || CertValidFromBox.Text == "" || CertValidToBox.Text == "")
                {
                    return; //If not, it aborts the operation
                }
                else
                {
                    Con.Open(); //Opens a connection to the database
                    string query = "INSERT INTO CertificateTbl(Cert_Supplier, Cert_Type, Cert_ValidFrom, Cert_ValidTo) VALUES (@Cert_Supplier, @Cert_Type, @Cert_ValidFrom, @Cert_ValidTo)";
                    try
                    {
                        //Creates an SQL command with parameters
                        using (SqlCommand cmd = new SqlCommand(query, Con))
                        {
                            cmd.Parameters.AddWithValue("@Cert_Supplier", SuppNameBox.Text);
                            cmd.Parameters.AddWithValue("@Cert_Type", CertTypeBox.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@Cert_ValidFrom", CertValidFromBox.Value.ToShortDateString());
                            cmd.Parameters.AddWithValue("@Cert_ValidTo", CertValidToBox.Value.ToShortDateString());
                            cmd.ExecuteNonQuery(); //Executes the SQL command to insert data into the database
                            ResetNewCertificatesBoxes(); //Calls the function to reset fields after successful insertion
                            NewCertificatePanel.Hide(); //Hide the new certificate panel
                            ExampleBtn1.Checked = true; // Sets the state of ExampleBtn1 to checked ( true )
                            DynamicCertificationControl(); //Refreshes the certificate display by calling the DynamicCertificationControl function
                            CertOverviewPanel.Show(); //Shows the certificate overview panel
                        }
                    }
                    catch (Exception)
                    {
                    }
                }
            }
            finally
            {
                Con.Close(); //Closes the connection to the database
            }
        }
        //Method to reset fields for entering new certificates
        private void ResetNewCertificatesBoxes()
        {
            SuppNameBox.Clear(); //Clears the supplier field
            CertTypeBox.SelectedIndex = -1; //Clears the selected certificate type
            CertValidFromBox.Value = DateTime.Now; //Sets the Valid from date to the current date and time
            CertValidToBox.Value = DateTime.Now; //Sets the Valid to date to the current date and time
        }
        //Dynamically populates the CertFlowLayout with controls to display certificate information
        public void DynamicCertificationControl()
        {
            //Clears all controls within CertFlowLayout to prepare for new certificates
            CertFlowLayout.Controls.Clear();
            try
            {
                string query = "SELECT * FROM CertificateTbl";
                SqlCommand cmd = new SqlCommand(query, Con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                //Checks if the DataTable is populated and contains certificates
                if (dt != null && dt.Rows.Count > 0)
                {
                    //Iterates through the rows of the DataTable and creates a control for each certificate
                    foreach (DataRow row in dt.Rows)
                    {
                        //Creates an instance of the control for displaying certificates
                        CertificateOverviewControl certWidget = new CertificateOverviewControl();
                        //Sets the certificate information on the control
                        certWidget.CertID = (int)row["ID_Cert"];
                        certWidget.CertSupplier = row["Cert_Supplier"].ToString();
                        certWidget.CertType = row["Cert_Type"].ToString();
                        certWidget.CertValidFrom = row["Cert_ValidFrom"].ToString();
                        certWidget.CertValidTo = row["Cert_ValidTo"].ToString();
                        //Adds the certificate control to CertFlowLayout
                        CertFlowLayout.Controls.Add(certWidget);
                        //Subscribes to the EditSelect event of the certificate widget to invoke the EditCertPanel_Click function when the event is triggered
                        certWidget.EditSelect += new EventHandler(this.EditCertPanel_Click);
                        //Subscribes to the DeleteSelect event of the certificate widget to invoke the DeleteCertPanel_Click function when the event is triggered
                        certWidget.DeleteSelect += new EventHandler(this.DeleteCertPanel_Click);
                    }
                }
            }
            catch (Exception)
            {
            }
        }
        //Edit certificate panel click
        private int certId; //Variable that stores the ID of the certificate to be edited
        void EditCertPanel_Click(object sender, EventArgs e)
        {
            CertificateOverviewControl obj = (CertificateOverviewControl)sender;
            certId = obj.CertID; //Sets certId to the ID of the certificate being edited
            SuppNameBox.Text = obj.CertSupplier; //Sets the text field SuppNameBox to the supplier value from the object
            CertTypeBox.Text = obj.CertType; //Sets the text field CertTypeBox to the certificate type from the object
            CertValidFromBox.Value = DateTime.Parse(obj.CertValidFrom); //Sets the CertValidFromBox date picker to the certificate's validity start date from the object
            CertValidToBox.Value = DateTime.Parse(obj.CertValidTo); //Sets the CertValidToBox date picker to the certificate's validity end date from the object
            CertOverviewPanel.Hide(); //Hides the certificate overview panel
            NewCertificatePanel.Show(); //Shows the panel for entering a new certificate
        }
        //Delete certificate button
        void DeleteCertPanel_Click(object sender, EventArgs e)
        {
            CertificateOverviewControl objdel = (CertificateOverviewControl)sender;
            certId = objdel.CertID; //Set certId to the value obtained from the objdel object
            try
            {
                Con.Open(); //Open a connection to the database
                string deleteQuery = "DELETE FROM CertificateTbl WHERE ID_Cert = @ID_Cert"; //SQL query to delete a certificate by ID
                using (SqlCommand cmd = new SqlCommand(deleteQuery, Con))
                {
                    cmd.Parameters.AddWithValue("@ID_Cert", certId); //Set the parameter for the certificate ID
                    cmd.ExecuteNonQuery(); //Execute the SQL command to delete data from the database
                    DynamicCertificationControl(); //Refresh the certificate display by calling the DynamicCertificationControl function
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                Con.Close(); //Close the connection to the database
            }
        }
        //Edit certificate button
        private void EditCertBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Check if required fields are filled
                if (SuppNameBox.Text == "" || CertTypeBox.SelectedIndex == -1 || CertValidFromBox.Text == "" || CertValidToBox.Text == "")
                {
                    return; //If not, the operation is aborted
                }
                else
                {
                    Con.Open(); //Open a connection to the database

                    //Check if a certificate with specific criteria certificate ID exists
                    if (certId != -1)
                    {
                        // SQL query to update certificate data
                        string query = "UPDATE CertificateTbl SET Cert_Supplier = @Cert_Supplier, Cert_Type = @Cert_Type, Cert_ValidFrom = @Cert_ValidFrom, Cert_ValidTo = @Cert_ValidTo WHERE ID_Cert = @ID_Cert";
                        try
                        {
                            using (SqlCommand cmd = new SqlCommand(query, Con))
                            {
                                cmd.Parameters.AddWithValue("@Cert_Supplier", SuppNameBox.Text);
                                cmd.Parameters.AddWithValue("@Cert_Type", CertTypeBox.SelectedItem.ToString());
                                cmd.Parameters.AddWithValue("@Cert_ValidFrom", CertValidFromBox.Value.ToShortDateString());
                                cmd.Parameters.AddWithValue("@Cert_ValidTo", CertValidToBox.Value.ToShortDateString());
                                cmd.Parameters.AddWithValue("@ID_Cert", certId); //Add a parameter for the certificate ID
                                cmd.ExecuteNonQuery(); //Execute the SQL command to update data in the database
                                ResetNewCertificatesBoxes(); //Reset fields after a successful update
                                NewCertificatePanel.Hide(); //Hide the panel for a new certificate
                                ExampleBtn1.Checked = true; //Set the state of ExampleBtn1 to checked (true)
                                DynamicCertificationControl(); //Refresh the certificate display by calling the DynamicCertificationControl function
                                CertOverviewPanel.Show(); //Show the certificate overview panel
                            }
                        }
                        catch (Exception)
                        {
                        }
                    }
                    else
                    {
                    }
                }
            }
            finally
            {
                Con.Close(); //Close the database connection
            }
        }
        //Clear supplier text field
        private void DelSuppBoxBtn_Click(object sender, EventArgs e)
        {
            SuppNameBox.Clear(); //Clears the supplier field
        }
        //Search button for suppliers
        private void SearchSupplierBtn_Click(object sender, EventArgs e)
        {
            //Clear all previous controls from SuppFlowLayout
            SuppFlowLayout.Controls.Clear();
            string query = $"SELECT * FROM SupplierTbl WHERE " +
                           $"{(!string.IsNullOrEmpty(SuppBox.Text) ? $"Supplier_Name LIKE '%{SuppBox.Text}%' AND " : "")}" +
                           $"{(!string.IsNullOrEmpty(IndexBox.Text) ? $"Supplier_Index LIKE '%{IndexBox.Text}%' AND " : "")}" +
                           $"{(!string.IsNullOrEmpty(CityBox.Text) ? $"Supplier_City LIKE '%{CityBox.Text}%' AND " : "")}";
            if (query.EndsWith("AND "))
            {
                query = query.Substring(0, query.Length - 4);
            }
            try
            {
                Con.Open();
                //Execute the SQL query
                using (SqlCommand cmd = new SqlCommand(query, Con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            SupplierControl supplierControl = new SupplierControl();
                            //Set supplier data from the query result using properties
                            supplierControl.NameSupplier = reader["Supplier_Name"].ToString();
                            supplierControl.IndexSupplier = reader["Supplier_Index"].ToString();
                            supplierControl.CitySupplier = reader["Supplier_City"].ToString();
                            SupplierListPanel.Show(); //Show the Supplier list panel
                            //Add SupplierControl to the FlowLayoutPanel
                            SuppFlowLayout.Controls.Add(supplierControl);
                            supplierControl.RadioSelect += SupplierControl_RadioSelect;
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                Con.Close(); //Close the database connection
            }
        }
        private SupplierControl selectedSupplierControl = null;
        //Handler for the RadioSelect event in SupplierControl
        private void SupplierControl_RadioSelect(object sender, EventArgs e)
        {
            selectedSupplierControl = (SupplierControl)sender;
        }
        //Select button for Radioselect supplier
        private void SelectSuppBtn_Click(object sender, EventArgs e)
        {
            if (selectedSupplierControl != null)
            {
                SuppNameBox.Clear(); //Supplier name clear box
                SuppNameBox.Text = selectedSupplierControl.NameSupplier + ", " + selectedSupplierControl.IndexSupplier + ", " + selectedSupplierControl.CitySupplier;
                SuppListPanel.Hide(); //Hide dialog supplier list and search
                NewCertificatePanel.Enabled = true; //Enable the New Certificate Panel
                ResetSearchSupplierFilter(); //Call the function to reset the search filter
                SuppFlowLayout.Controls.Clear(); //Clear all previous controls from SuppFlowLayout
                SupplierListPanel.Hide(); //Hide the Supplier list panel
            }
        }
        //Cancel button for suppliers
        private void CancelSuppBtn_Click(object sender, EventArgs e)
        {
            SuppFlowLayout.Controls.Clear(); //Clear all previous controls from SuppFlowLayout
            SupplierListPanel.Hide(); //Hide the Supplier list panel
        }
        //Handler for the ResetSupplierBtn click event
        private void ResetSupplierBtn_Click(object sender, EventArgs e)
        {
            //Call the function to reset the search filter
            ResetSearchSupplierFilter();
        }
        //Function to reset the search filter for suppliers
        void ResetSearchSupplierFilter()
        {
            // Clear the text in the Supplier Name, Index, and City text boxes
            SuppBox.Clear();
            IndexBox.Clear();
            CityBox.Clear();
        }
        //Handler for the CloseDialogBtn click event
        private void CloseDialogBtn_Click(object sender, EventArgs e)
        {
            //Reset the search filter for suppliers
            ResetSearchSupplierFilter();

            //Hide the Supplier List Panel and the Supplier List Dialog Panel
            SupplierListPanel.Hide();
            SuppListPanel.Hide();
            //Enable the New Certificate Panel
            NewCertificatePanel.Enabled = true;
        }
        //Handler for the SearchSuppBtn click event
        private void SearchSuppBtn_Click(object sender, EventArgs e)
        {
            //Disable the New Certificate Panel
            NewCertificatePanel.Enabled = false;

            //Show the Supplier List Dialog Panel
            SuppListPanel.Show();
        }
        private void checkBoxAll_CheckedChanged(object sender, EventArgs e)
        {
            //Iterate through all controls within the FlowLayoutPanel
            foreach (Control control in PersonFlowLayout.Controls)
            {
                //Check if the control is of type PersonControl
                if (control is PersonControl personControl)
                {
                    //Set the state of the CheckBox in PersonControl to the state of checkBoxAll
                    personControl.checkBox1.Checked = checkBoxAll.Checked;
                }
            }
        }
        //Search person button
        private void SeaPerBtn_Click(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM PersonTbl WHERE " +
                           $"{(!string.IsNullOrEmpty(NamePerBox.Text) ? $"Name_Person LIKE '%{NamePerBox.Text}%' AND " : "")}" +
                           $"{(!string.IsNullOrEmpty(FNamePerBox.Text) ? $"Firstname_Person LIKE '%{FNamePerBox.Text}%' AND " : "")}" +
                           $"{(!string.IsNullOrEmpty(UserIDPerBox.Text) ? $"User_ID LIKE '%{UserIDPerBox.Text}%' AND " : "")}" +
                           $"{(!string.IsNullOrEmpty(UserDepPerBox.Text) ? $"Department_Person LIKE '%{UserDepPerBox.Text}%' AND " : "")}" +
                           $"{(!string.IsNullOrEmpty(UserPlantPerBox.Text) ? $"Plant_Person LIKE '%{UserPlantPerBox.Text}%' AND " : "")}";
            //Remove AND from the last condition
            if (query.EndsWith("AND "))
            {
                query = query.Substring(0, query.Length - 5);
            }
            try
            {
                Con.Open();
                //Execute the SQL query
                using (SqlCommand cmd = new SqlCommand(query, Con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PersonControl personControl = new PersonControl();
                            //Set supplier data from the query result using properties
                            personControl.NamePerson = reader["Name_Person"].ToString();
                            personControl.FirstNamePerson = reader["Firstname_Person"].ToString();
                            personControl.UserIDPerson = reader["User_ID"].ToString();
                            personControl.DepartmentPerson = reader["Department_Person"].ToString();
                            personControl.PlantPerson = reader["Plant_Person"].ToString();
                            PersListPanel.Show(); //Show the Person list panel
                            PersonFlowLayout.Controls.Add(personControl);
                            ResetSearchPersonFilter();
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                Con.Close(); //Close the database connection
            }
        }
        //Function to reset the search filter for person
        void ResetSearchPersonFilter()
        {
            NamePerBox.Clear();
            FNamePerBox.Clear();
            UserIDPerBox.Clear();
            UserDepPerBox.Clear();
            UserPlantPerBox.Clear();
        }
        //Handler for the SeaPerReset click event
        private void SeaPerReset_Click(object sender, EventArgs e)
        {
            ResetSearchPersonFilter();
        }
        //Add participant button
        private void AddParticipantBtn_Click(object sender, EventArgs e)
        {
            //Disable the New Certificate Panel
            NewCertificatePanel.Enabled = false;
            SearchPersonPanel.Show();
        }
        //Person dialog close click button
        private void PerDialogClose_Click(object sender, EventArgs e)
        {
            //Reset the search filter for person
            ResetSearchPersonFilter();
            //Hide the PersListPanel and the Person List Dialog Panel
            PersListPanel.Hide();
            SearchPersonPanel.Hide();
            //Enable the New Certificate Panel
            NewCertificatePanel.Enabled = true;
        }
        //Person cancel click button
        private void PerCancBtn_Click(object sender, EventArgs e)
        {
            //Clear all previous controls from PersonFlowLayout
            PersonFlowLayout.Controls.Clear();
            PersListPanel.Hide();
        }
        //Person select button and add to participant table
        private void PerSelectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                //Iterate through all controls within the PersonFlowLayout
                foreach (Control control in PersonFlowLayout.Controls)
                {
                    //Check if the control is of type PersonControl
                    if (control is PersonControl personControl)
                    {
                        //Check if checkBox1 is checked on this PersonControl widget
                        if (personControl.checkBox1.Checked)
                        {
                            //Retrieve data from the selected widget
                            string partName = personControl.NamePerson + ", " + personControl.FirstNamePerson + " (" + personControl.PlantPerson + ")";
                            string partDep = personControl.DepartmentPerson;
                            string partEmail = $"{char.ToLower(personControl.NamePerson[0])}{personControl.NamePerson.Substring(1)}{char.ToLower(personControl.FirstNamePerson[0])}@mail.com";
                            //SQL query for inserting data into the ParticipantTbl table
                            string query = "INSERT INTO ParticipantTbl (Part_Name, Part_Depart, Part_Email) VALUES (@Part_Name, @Part_Depart, @Part_Email)";
                            using (SqlCommand cmd = new SqlCommand(query, Con))
                            {
                                //Set parameters for the SQL query
                                cmd.Parameters.AddWithValue("@Part_Name", partName);
                                cmd.Parameters.AddWithValue("@Part_Depart", partDep);
                                cmd.Parameters.AddWithValue("@Part_Email", partEmail);
                                cmd.ExecuteNonQuery();
                                DynamicParticipantControl(); //Refresh the participant display by calling the DynamicParticipantControl function
                                //Reset the search filter for person
                                ResetSearchPersonFilter();
                                //Hide the PersListPanel and the Person List Dialog Panel
                                PersListPanel.Hide();
                                SearchPersonPanel.Hide();
                                //Enable the New Certificate Panel
                                NewCertificatePanel.Enabled = true;
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                Con.Close();
            }
        }
        //Dynamic participant control
        public void DynamicParticipantControl()
        {
            //Clear all controls within PartFlowLayout to refresh the display
            PartFlowLayout.Controls.Clear();
            try
            {
                //Create an SQL query to retrieve all participant data from the ParticipantTbl table
                string query = "SELECT * FROM ParticipantTbl";
                SqlCommand cmd = new SqlCommand(query, Con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                //Check if there is participant data available
                if (dt != null && dt.Rows.Count > 0)
                {
                    //Iterate through each data row and add ParticipantControl widgets for each participant
                    foreach (DataRow row in dt.Rows)
                    {
                        ParticipantControl partWidget = new ParticipantControl();
                        //Set participant data on the newly created ParticipantControl widget
                        partWidget.IDPart = (int)row["Part_ID"];
                        partWidget.NameParticipant = row["Part_Name"].ToString();
                        partWidget.DepartmentParticipant = row["Part_Depart"].ToString();
                        partWidget.EmailParticipant = row["Part_Email"].ToString();
                        //Add the new ParticipantControl to PartFlowLayout
                        PartFlowLayout.Controls.Add(partWidget);
                        //Set a delete event handler for each added ParticipantControl
                        partWidget.DeleteSelect += new EventHandler(this.DeleteParticipant_Click);
                    }
                }
            }
            catch (Exception)
            {
            }
        }
        //Delete participant button
        void DeleteParticipant_Click(object sender, EventArgs e)
        {
            //Check if sender is really a ParticipantControl widget
            if (sender is ParticipantControl partControl)
            {
                //Get the participant ID that triggered the delete event
                int partID = partControl.IDPart;
                try
                {
                    string query = "DELETE FROM ParticipantTbl WHERE Part_ID = @Part_ID";
                    using (SqlCommand cmd = new SqlCommand(query, Con))
                    {
                        cmd.Parameters.AddWithValue("@Part_ID", partID);
                        Con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception)
                {
                }
                finally
                {
                    Con.Close();
                }
                //Refresh the display after deleting the participant
                DynamicParticipantControl();
            }
        }
        //Click new comment button and show comment panel
        private void NewCommentBtn_Click(object sender, EventArgs e)
        {
            AddCommentPanel.Show(); //Show comment panel
        }
        //Selected user for index combobox
        private void UserSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UserSelectBox.SelectedItem != null)
            {
                UserAdLabel.Text = UserSelectBox.SelectedItem.ToString();
            }
        }
        //Add comment in database
        private void CommentBtn_Click(object sender, EventArgs e)
        {
            if (userComment.Text == "")
            {
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "INSERT INTO CommentTbl (User_Comm, Text_Comm) VALUES (@User_Comm, @Text_Comm)";
                    using (SqlCommand cmd = new SqlCommand(query, Con))
                    {
                        cmd.Parameters.AddWithValue("@User_Comm", UserAdLabel.Text);
                        cmd.Parameters.AddWithValue("@Text_Comm", commentTextBox.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception)
                {
                }
                finally
                {
                    Con.Close();
                }
                CommentViewPanel.Show();
                userLog.Text = UserAdLabel.Text;
                userComment.Text = commentTextBox.Text;
            }
        }
        //Upload image button
        private void UploadImgBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Images|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All files|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectImg = openFileDialog.FileName;
                ImgPicBox.Image = Image.FromFile(selectImg);
            }
        }
        //Method called when the CloseAppBtn button is clicked to exit the application
        private void CloseAppBtn_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Exits the application
        }
    }
}
