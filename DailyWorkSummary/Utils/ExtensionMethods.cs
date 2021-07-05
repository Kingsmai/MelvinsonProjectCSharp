using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;

namespace DailyWorkSummary.Utils
{
    public static class ExtensionMethods
    {
        public static string getContentAsString(this RichTextBox rtb)
        {
            TextRange textRange = new TextRange(rtb.Document.ContentStart, rtb.Document.ContentEnd);

            return textRange.Text;
        }
    }
}
