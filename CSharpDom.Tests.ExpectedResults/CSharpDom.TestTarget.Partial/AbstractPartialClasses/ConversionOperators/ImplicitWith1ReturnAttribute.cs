namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.ConversionOperators
{
    public abstract partial class AbstractPartialClassWithImplicitConversionOperatorWith1ReturnAttribute
    {
        [return: Attribute1]
        public static implicit operator AbstractClassWithImplicitConversionOperatorWith1ReturnAttribute(string text)
        {
            return default(AbstractClassWithImplicitConversionOperatorWith1ReturnAttribute);
        }
    }
}
