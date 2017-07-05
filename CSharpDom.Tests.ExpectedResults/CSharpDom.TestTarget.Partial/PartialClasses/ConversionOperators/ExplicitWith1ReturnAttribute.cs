namespace CSharpDom.TestTarget.Partial.PartialClasses.ConversionOperators
{
    public partial class PartialClassWithExplicitConversionOperatorWith1ReturnAttribute
    {
        [return: Attribute1]
        public static explicit operator ClassWithExplicitConversionOperatorWith1ReturnAttribute(string text)
        {
            return default(ClassWithExplicitConversionOperatorWith1ReturnAttribute);
        }
    }
}
