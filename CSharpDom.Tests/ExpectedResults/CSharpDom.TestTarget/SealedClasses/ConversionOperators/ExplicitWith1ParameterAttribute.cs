namespace CSharpDom.TestTarget.SealedClasses.ConversionOperators
{
    public sealed class SealedClassWithExplicitConversionOperatorWith1ParameterAttribute
    {
        public static explicit operator SealedClassWithExplicitConversionOperatorWith1ParameterAttribute([Attribute1]string text)
        {
            return default(SealedClassWithExplicitConversionOperatorWith1ParameterAttribute);
        }
    }
}
