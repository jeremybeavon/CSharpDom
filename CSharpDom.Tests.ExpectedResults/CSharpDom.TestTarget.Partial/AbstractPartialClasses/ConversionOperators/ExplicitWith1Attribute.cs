namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.ConversionOperators
{
    public abstract partial class AbstractPartialClassWithExplicitConversionOperatorWith1Attribute
    {
        [Attribute1]
        public static explicit operator AbstractPartialClassWithExplicitConversionOperatorWith1Attribute(string text)
        {
            return default(AbstractPartialClassWithExplicitConversionOperatorWith1Attribute);
        }
    }
}
