using Microsoft.VisualStudio.Shell;

namespace OptionsSample.Options
{
    public class BaseOptionsPage<T> : DialogPage where T : BaseOptionsModel<T>, new()
    {
        private BaseOptionsModel<T> _model;

        public BaseOptionsPage()
        {
#pragma warning disable VSTHRD104 // Offer async methods
            _model = ThreadHelper.JoinableTaskFactory.Run(BaseOptionsModel<T>.CreateAsync);
#pragma warning restore VSTHRD104 // Offer async methods
        }

        public override object AutomationObject => _model;

        public override void LoadSettingsFromStorage()
        {
#pragma warning disable VSTHRD104 // Offer async methods
            ThreadHelper.JoinableTaskFactory.Run(_model.LoadAsync);
#pragma warning restore VSTHRD104 // Offer async methods
        }

        public override void SaveSettingsToStorage()
        {
#pragma warning disable VSTHRD104 // Offer async methods
            ThreadHelper.JoinableTaskFactory.Run(_model.SaveAsync);
#pragma warning restore VSTHRD104 // Offer async methods
        }
    }
}
