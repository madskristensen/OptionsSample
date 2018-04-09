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
            // Call the Instance singleton from the UI thread is easy
            bool showMessage = OtherOptions.Instance.ShowMessage;

            if (showMessage)
            {
                System.Threading.Tasks.Task.Run(async () =>
                {
                    // Make the call to GetLiveInstanceAsync from a background thread to avoid blocking the UI thread
                    GeneralOptions options = await GeneralOptions.GetLiveInstanceAsync();
                    System.Windows.Forms.MessageBox.Show(options.Message);
                });
            }
        }
    }
}
