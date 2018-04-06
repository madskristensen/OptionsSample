using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Text.Editor;
using Microsoft.VisualStudio.Utilities;
using OptionsSample.Options;

namespace OptionsSample
{
    [Export(typeof(IWpfTextViewCreationListener))]
    [ContentType("text")]
    [TextViewRole(PredefinedTextViewRoles.PrimaryDocument)]
    public class TextviewCreationListener : IWpfTextViewCreationListener
    {
        public void TextViewCreated(IWpfTextView textView)
        {
            System.Threading.Tasks.Task.Run(() =>
            {
                System.Windows.Forms.MessageBox.Show(GeneralOptions.Instance.Message);
            });
        }
    }
}
