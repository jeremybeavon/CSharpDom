namespace CSharpDom.TestTarget.Partial.PartialClasses.ConversionOperators
{
    public partial class PartialClassWithExplicitConversionOperatorWith1ReturnAttribute
    {
        [return: Attribute1]
        public static explicit operator PartialClassWithExplicitConversionOperatorWith1ReturnAttribute(string text)
        {
            return default(PartialClassWithExplicitConversionOperatorWith1ReturnAttribute);
        }
    }
}
