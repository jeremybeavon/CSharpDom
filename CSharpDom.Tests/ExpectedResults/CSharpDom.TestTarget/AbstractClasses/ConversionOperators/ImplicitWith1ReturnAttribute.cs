namespace CSharpDom.TestTarget.AbstractClasses.ConversionOperators
{
    public abstract class AbstractClassWithImplicitConversionOperatorWith1ReturnAttribute
    {
        [return: Attribute1]
        public static implicit operator AbstractClassWithImplicitConversionOperatorWith1ReturnAttribute(string text)
        {
            return default(AbstractClassWithImplicitConversionOperatorWith1ReturnAttribute);
        }
    }
}
