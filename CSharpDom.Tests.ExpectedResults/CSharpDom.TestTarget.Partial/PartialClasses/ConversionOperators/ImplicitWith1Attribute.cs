namespace CSharpDom.TestTarget.Partial.PartialClasses.ConversionOperators
{
    public partial class PartialClassWithImplicitConversionOperatorWith1Attribute
    {
        [Attribute1]
        public static implicit operator PartialClassWithImplicitConversionOperatorWith1Attribute(string text)
        {
            return default(PartialClassWithImplicitConversionOperatorWith1Attribute);
        }
    }
}
