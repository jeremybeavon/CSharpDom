namespace CSharpDom.TestTarget.AbstractClasses.ConversionOperators
{
    public abstract class AbstractClassWithImplicitConversionOperatorWith1Attribute
    {
        [Attribute1]
        public static implicit operator AbstractClassWithImplicitConversionOperatorWith1Attribute(string text)
        {
            return default(AbstractClassWithImplicitConversionOperatorWith1Attribute);
        }
    }
}
