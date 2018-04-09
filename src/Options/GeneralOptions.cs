using System.ComponentModel;

namespace OptionsSample.Options
{
    public class GeneralOptions : BaseOptionModel<GeneralOptions>
    {
        [Category("My category")]
        [DisplayName("Message box text")]
        [Description("Specifies the text to show in the message box")]
        public string Message { get; set; } = "My message";

        #region DialogPage
        /// <summary>The DialogPage to register on the Package class.</summary>
        public class Page : BaseOptionPage<GeneralOptions> { }
        #endregion
    }
}
