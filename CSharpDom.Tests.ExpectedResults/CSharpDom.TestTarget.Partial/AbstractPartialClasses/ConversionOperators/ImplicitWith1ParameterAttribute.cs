namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.ConversionOperators
{
    public abstract partial class AbstractPartialClassWithImplicitConversionOperatorWith1ParameterAttribute
    {
        public static implicit operator AbstractClassWithImplicitConversionOperatorWith1ParameterAttribute([Attribute1]string text)
        {
            return default(AbstractClassWithImplicitConversionOperatorWith1ParameterAttribute);
        }
    }
}
