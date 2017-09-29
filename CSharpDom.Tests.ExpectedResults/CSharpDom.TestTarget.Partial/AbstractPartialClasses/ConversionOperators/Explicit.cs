namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.ConversionOperators
{
    public abstract partial class AbstractPartialClassWithExplicitConversionOperator
    {
        public static explicit operator AbstractPartialClassWithExplicitConversionOperator(string text)
        {
            return default(AbstractPartialClassWithExplicitConversionOperator);
        }
    }
}
