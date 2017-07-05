namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.ConversionOperators
{
    public abstract partial class AbstractPartialClassWithExplicitConversionOperator
    {
        public static explicit operator AbstractClassWithExplicitConversionOperator(string text)
        {
            return default(AbstractClassWithExplicitConversionOperator);
        }
    }
}
