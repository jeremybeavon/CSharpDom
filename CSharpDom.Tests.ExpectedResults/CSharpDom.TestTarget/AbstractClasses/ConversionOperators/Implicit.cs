namespace CSharpDom.TestTarget.AbstractClasses.ConversionOperators
{
    public abstract class AbstractClassWithImplicitConversionOperator
    {
        public static implicit operator AbstractClassWithImplicitConversionOperator(string text)
        {
            return default(AbstractClassWithImplicitConversionOperator);
        }
    }
}
