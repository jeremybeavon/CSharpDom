namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.ConversionOperators
{
    public abstract partial class AbstractPartialClassWithImplicitConversionOperator
    {
        public static implicit operator AbstractPartialClassWithImplicitConversionOperator(string text)
        {
            return default(AbstractPartialClassWithImplicitConversionOperator);
        }
    }
}
