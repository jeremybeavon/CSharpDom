namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.ConversionOperators
{
    public sealed partial class SealedPartialClassWithExplicitConversionOperatorWith1ParameterAttribute
    {
        public static explicit operator SealedClassWithExplicitConversionOperatorWith1ParameterAttribute([Attribute1]string text)
        {
            return default(SealedClassWithExplicitConversionOperatorWith1ParameterAttribute);
        }
    }
}
