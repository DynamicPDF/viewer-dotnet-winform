using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace viewer_dotnet_winforms_cs
{
    public partial class CustomSearchInterface : Form
    {
        public CustomSearchInterface()
        {
            InitializeComponent();
        }
        private void pdfViewer1_SearchDialogShowing(object sender, ceTe.DynamicPDF.Viewer.SearchDialogShowingEventArgs e)
        {
            e.Cancel = true;
            searchText.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(searchText.Text))
            {
                ceTe.DynamicPDF.Viewer.MatchOptions matchOptions = ceTe.DynamicPDF.Viewer.MatchOptions.All; ;
                if ((matchWholeWord.Checked == true) && (matchCase.Checked == true))
                {
                    matchOptions = ceTe.DynamicPDF.Viewer.MatchOptions.All;
                }
                else if ((matchWholeWord.Checked == true) && (matchCase.Checked == false))
                {
                    matchOptions = ceTe.DynamicPDF.Viewer.MatchOptions.WholeWordOnly;
                }
                else if ((matchWholeWord.Checked == false) && (matchCase.Checked == true))
                {
                    matchOptions = ceTe.DynamicPDF.Viewer.MatchOptions.CaseSensitive;
                }
                else
                {
                    matchOptions = ceTe.DynamicPDF.Viewer.MatchOptions.None;
                }

                pdfViewer1.SearchForward(searchText.Text, matchOptions);
            }
        }

        private void pdfViewer1_DocumentDisplayed(object sender, ceTe.DynamicPDF.Viewer.DocumentDisplayedEventArgs e)
        {
            groupBox1.Enabled = true;
            title.Text = "Type a search term in the 'Find' text box and click on 'Find Next'.";
        }
    }
}
