using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace LempelZivCoding
{
    public partial class CodebookViewerForm : Form
    {
        public CodebookViewerForm()
        {
            InitializeComponent();
        }

        public CodebookViewerForm(IEnumerable<string> codeBook, int numberBase)
        {
            InitializeComponent();
            try
            {
                titleLabel.Text = "Codebook (Base - " + numberBase + ")";
                codeBookTextBox.Lines = codeBook.ToArray();
                totalPhrasesLabel.Text = codeBookTextBox.Lines.Count().ToString("N0", CultureInfo.CreateSpecificCulture("en-IN"));
                longestPhraseLabel.Text = codeBookTextBox.Lines.Max(phrase => phrase.Length).ToString();
            }
            catch { }
        }
    }
}
