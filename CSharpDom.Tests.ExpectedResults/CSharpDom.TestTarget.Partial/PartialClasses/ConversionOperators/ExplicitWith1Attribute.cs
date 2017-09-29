namespace CSharpDom.TestTarget.Partial.PartialClasses.ConversionOperators
{
    public partial class PartialClassWithExplicitConversionOperatorWith1Attribute
    {
        [Attribute1]
        public static explicit operator PartialClassWithExplicitConversionOperatorWith1Attribute(string text)
        {
            return default(PartialClassWithExplicitConversionOperatorWith1Attribute);
        }
    }
}
