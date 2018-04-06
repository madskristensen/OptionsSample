using System.ComponentModel;

namespace OptionsSample.Options
{
    public class OtherOptions : BaseOptionsModel<OtherOptions>
    {
        [Category("A category")]
        [DisplayName("This is a boolean")]
        [Description("The description of the property")]
        [DefaultValue(true)]
        public bool ThisIsABoolean { get; set; } = true;

        [Category("Another category")]
        [DisplayName("Favorite clothing")]
        [Description("The description of the property")]
        [DefaultValue(Clothing.Pants)]
        public Clothing ClothingChoice { get; set; } = Clothing.Pants;

        [Category("My category")]
        [DisplayName("This is a boolean")]
        [Description("The description of the property")]
        [DefaultValue(true)]
        [Browsable(false)] // This will hide it from the Tools -> Options page, but still work like normal
        public bool HiddenProperty { get; set; } = true;
    }

    public enum Clothing
    {
        Pants,
        Sweater,
        Shoes
    }
}
