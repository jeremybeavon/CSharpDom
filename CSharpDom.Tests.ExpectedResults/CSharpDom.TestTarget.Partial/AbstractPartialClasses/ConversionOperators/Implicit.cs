namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.ConversionOperators
{
    public abstract partial class AbstractPartialClassWithImplicitConversionOperator
    {
        public static implicit operator AbstractClassWithImplicitConversionOperator(string text)
        {
            return default(AbstractClassWithImplicitConversionOperator);
        }
    }
}
