using System.ComponentModel;

namespace OptionsSample.Options
{
    public class GeneralOptions : BaseOptionModel<GeneralOptions>
    {
        public class Page : BaseOptionPage<GeneralOptions> { }

        [Category("My category")]
        [DisplayName("Message box text")]
        [Description("Specifies the text to show in the message box")]
        public string Message { get; set; } = "My message";
    }
}
