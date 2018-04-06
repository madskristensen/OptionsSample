using Microsoft.VisualStudio.Shell;

namespace OptionsSample.Options
{
    public class BaseOptionsPage<T> : DialogPage where T : BaseOptionsModel<T>, new()
    {
        private BaseOptionsModel<T> _model;

        public BaseOptionsPage()
        {
           _model = ThreadHelper.JoinableTaskFactory.Run(BaseOptionsModel<T>.CreateAsync);
        }

        public override object AutomationObject => _model;

        public override void LoadSettingsFromStorage()
        {
            ThreadHelper.JoinableTaskFactory.Run(_model.LoadAsync);
        }

        public override void SaveSettingsToStorage()
        {
            ThreadHelper.JoinableTaskFactory.Run(_model.SaveAsync);
        }
    }
}
