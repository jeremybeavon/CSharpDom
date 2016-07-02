namespace CSharpDom.TestTarget.AbstractClasses.ConversionOperators
{
    public abstract class AbstractClassWithExplicitConversionOperator
    {
        public static explicit operator AbstractClassWithExplicitConversionOperator(string text)
        {
            return default(AbstractClassWithExplicitConversionOperator);
        }
    }
}
