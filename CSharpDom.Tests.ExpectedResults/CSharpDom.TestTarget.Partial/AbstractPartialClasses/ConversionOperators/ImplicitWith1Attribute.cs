namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.ConversionOperators
{
    public abstract partial class AbstractPartialClassWithImplicitConversionOperatorWith1Attribute
    {
        [Attribute1]
        public static implicit operator AbstractPartialClassWithImplicitConversionOperatorWith1Attribute(string text)
        {
            return default(AbstractPartialClassWithImplicitConversionOperatorWith1Attribute);
        }
    }
}
