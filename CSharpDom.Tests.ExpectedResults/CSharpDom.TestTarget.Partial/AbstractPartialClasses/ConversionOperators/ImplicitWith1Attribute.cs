namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.ConversionOperators
{
    public abstract partial class AbstractPartialClassWithImplicitConversionOperatorWith1Attribute
    {
        [Attribute1]
        public static implicit operator AbstractClassWithImplicitConversionOperatorWith1Attribute(string text)
        {
            return default(AbstractClassWithImplicitConversionOperatorWith1Attribute);
        }
    }
}
