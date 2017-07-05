namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.ConversionOperators
{
    public abstract partial class AbstractPartialClassWithExplicitConversionOperatorWith1ParameterAttribute
    {
        public static explicit operator AbstractClassWithExplicitConversionOperatorWith1ParameterAttribute([Attribute1]string text)
        {
            return default(AbstractClassWithExplicitConversionOperatorWith1ParameterAttribute);
        }
    }
}
