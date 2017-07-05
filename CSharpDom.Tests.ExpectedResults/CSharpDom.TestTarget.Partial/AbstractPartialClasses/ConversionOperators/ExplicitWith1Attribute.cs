namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.ConversionOperators
{
    public abstract partial class AbstractPartialClassWithExplicitConversionOperatorWith1Attribute
    {
        [Attribute1]
        public static explicit operator AbstractClassWithExplicitConversionOperatorWith1Attribute(string text)
        {
            return default(AbstractClassWithExplicitConversionOperatorWith1Attribute);
        }
    }
}
