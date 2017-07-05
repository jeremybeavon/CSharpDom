namespace CSharpDom.TestTarget.Partial.PartialClasses.ConversionOperators
{
    public partial class PartialClassWithImplicitConversionOperatorWith1ReturnAttribute
    {
        [return: Attribute1]
        public static implicit operator ClassWithImplicitConversionOperatorWith1ReturnAttribute(string text)
        {
            return default(ClassWithImplicitConversionOperatorWith1ReturnAttribute);
        }
    }
}
