namespace CSharpDom.TestTarget.Partial.PartialClasses.ConversionOperators
{
    public partial class PartialClassWithImplicitConversionOperatorWith1ReturnAttribute
    {
        [return: Attribute1]
        public static implicit operator PartialClassWithImplicitConversionOperatorWith1ReturnAttribute(string text)
        {
            return default(PartialClassWithImplicitConversionOperatorWith1ReturnAttribute);
        }
    }
}
