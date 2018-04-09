namespace OptionsSample.Options
{
    /// <summary>
    /// A provider for custom <see cref="DialogPage" /> implementations.
    /// </summary>
    internal class DialogPageProvider
    {
        public class GeneralOptionsPage : BaseOptionPage<GeneralOptions> { }
        public class OtherOptionsPage : BaseOptionPage<OtherOptions> { }
    }
}
