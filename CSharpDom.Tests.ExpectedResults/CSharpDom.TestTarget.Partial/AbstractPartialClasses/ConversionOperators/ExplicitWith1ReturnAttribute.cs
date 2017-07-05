namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.ConversionOperators
{
    public abstract partial class AbstractPartialClassWithExplicitConversionOperatorWith1ReturnAttribute
    {
        [return: Attribute1]
        public static explicit operator AbstractClassWithExplicitConversionOperatorWith1ReturnAttribute(string text)
        {
            return default(AbstractClassWithExplicitConversionOperatorWith1ReturnAttribute);
        }
    }
}
