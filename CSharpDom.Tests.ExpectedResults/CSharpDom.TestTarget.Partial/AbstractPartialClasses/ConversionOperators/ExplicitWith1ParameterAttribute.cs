namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.ConversionOperators
{
    public abstract partial class AbstractPartialClassWithExplicitConversionOperatorWith1ParameterAttribute
    {
        public static explicit operator AbstractPartialClassWithExplicitConversionOperatorWith1ParameterAttribute([Attribute1]string text)
        {
            return default(AbstractPartialClassWithExplicitConversionOperatorWith1ParameterAttribute);
        }
    }
}
