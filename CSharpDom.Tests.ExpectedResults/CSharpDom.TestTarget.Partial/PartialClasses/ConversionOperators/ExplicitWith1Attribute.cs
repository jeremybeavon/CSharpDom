namespace CSharpDom.TestTarget.Partial.PartialClasses.ConversionOperators
{
    public partial class PartialClassWithExplicitConversionOperatorWith1Attribute
    {
        [Attribute1]
        public static explicit operator ClassWithExplicitConversionOperatorWith1Attribute(string text)
        {
            return default(ClassWithExplicitConversionOperatorWith1Attribute);
        }
    }
}
