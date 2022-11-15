using SigmaExcel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XMLUtility
{
    public partial class UIForm : Form
    {
        private Point mouseDownCredentialsPanelLocation;
        public UIForm()
        {
            InitializeComponent();
        }

        private void TransformButton_Click(object sender, EventArgs e)
        {
            HandleTransform();
        }
        private void HandleTransform()
        {
            try
            {
                Transformer.Transform(
                    Environment.GetEnvironmentVariable("XML_FILEPATH"),
                    Environment.GetEnvironmentVariable("XSL_FILEPATH"),
                    Environment.GetEnvironmentVariable("HTML_FILEPATH"));
                MessageBox.Show("Successfully transformed");
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
        }
        private void OpenInBrowserButton_Click(object sender, EventArgs e)
        {
            HandleOpeningInBrowser();
        }
        private void HandleOpeningInBrowser()
        {
            string currentXML = 
                Environment.GetEnvironmentVariable("XML_FILEPATH");
            
            if (Transformer.WasTransformed.Contains(currentXML))
            {
                string html =
                    Environment.GetEnvironmentVariable("HTML_FILEPATH");
                System.Diagnostics.Process.Start(html);
            }
            else
            {
                MessageBox.Show("You need to conduct transformation first");
            }
        }
        private void SelectButton_Click(object sender, EventArgs e)
        {
            filteredDataTextBox.Text = 
                GetCurrentStrategy().
                FetchCurrentValues(
                    Environment.GetEnvironmentVariable("XML_FILEPATH"),
                    GatherEnabledFilters()
                );
        }
        private HashSet<string> GatherEnabledFilters()
        {
            var enabledFilters = new HashSet<string>();
            if (firstNameCheckbox.Checked) 
                enabledFilters.Add("FIRSTNAME");
            if (surnameCheckBox.Checked)
                enabledFilters.Add("SURNAME");
            if (lastNameCheckBox.Checked) 
                enabledFilters.Add("LASTNAME");
            
            if (workplaceUniversityCheckBox.Checked) 
                enabledFilters.Add("WUNIVERSITY");
            if (workplaceFacultyCheckbox.Checked) 
                enabledFilters.Add("WFACULTY");
            if (workplaceDepartmentCheckBox.Checked)
                enabledFilters.Add("WDEPARTMENT");
            
            if (basicCheckBox.Checked) enabledFilters.Add("BSCHOOL");
            if (graduateCheckBox.Checked) {
                enabledFilters.Add("GUNIVERSITY");
                enabledFilters.Add("GFACULTY");
            }
            if (postgraduateCheckBox.Checked) {
                enabledFilters.Add("PUNIVERSITY");
                enabledFilters.Add("PFACULTY");
            }
            if (doctoralCheckBox.Checked) {
                enabledFilters.Add("DUNIVERSITY");
                enabledFilters.Add("DFACULTY");
            }
            return enabledFilters;
        }
        private ISelectionStrategy GetCurrentStrategy()
        {
            if (DOMRadioButton.Checked){
                return new DOMTraversal();
            }
            return new SAXTraversal();
        }
        private void DocumentationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string html =
                    Environment.GetEnvironmentVariable("DOCUMENTATION_URL");
            System.Diagnostics.Process.Start(html);
        }
        private void ShowCredentials_Click(object sender, EventArgs e)
        {
            credentialsPanel.Visible = true;
        }
        private void HideCredentials_Click(object sender, EventArgs e)
        {
            credentialsPanel.Visible = false;
        }
        private void MoveCredentialsPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                mouseDownCredentialsPanelLocation = e.Location;
            }
        }
        private void MoveCredentialsPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                credentialsPanel.Left = e.X + credentialsPanel.Left -
                    mouseDownCredentialsPanelLocation.X;
                credentialsPanel.Top = e.Y + credentialsPanel.Top -
                    mouseDownCredentialsPanelLocation.Y;
            }
        }
    }
}
