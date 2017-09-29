namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.ConversionOperators
{
    public abstract partial class AbstractPartialClassWithImplicitConversionOperatorWith1ReturnAttribute
    {
        [return: Attribute1]
        public static implicit operator AbstractPartialClassWithImplicitConversionOperatorWith1ReturnAttribute(string text)
        {
            return default(AbstractPartialClassWithImplicitConversionOperatorWith1ReturnAttribute);
        }
    }
}
