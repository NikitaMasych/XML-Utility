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

        private void openInBrowserButton_Click(object sender, EventArgs e)
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
    }
}
