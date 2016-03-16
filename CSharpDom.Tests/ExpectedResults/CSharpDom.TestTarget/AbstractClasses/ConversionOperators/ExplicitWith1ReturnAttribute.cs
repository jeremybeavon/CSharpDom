namespace CSharpDom.TestTarget.AbstractClasses.ConversionOperators
{
    public abstract class AbstractClassWithExplicitConversionOperatorWith1ReturnAttribute
    {
        [return: Attribute1]
        public static explicit operator AbstractClassWithExplicitConversionOperatorWith1ReturnAttribute(string text)
        {
            return default(AbstractClassWithExplicitConversionOperatorWith1ReturnAttribute);
        }
    }
}
