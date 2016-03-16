namespace CSharpDom.TestTarget.AbstractClasses.ConversionOperators
{
    public abstract class AbstractClassWithExplicitConversionOperatorWith1Attribute
    {
        [Attribute1]
        public static explicit operator AbstractClassWithExplicitConversionOperatorWith1Attribute(string text)
        {
            return default(AbstractClassWithExplicitConversionOperatorWith1Attribute);
        }
    }
}
