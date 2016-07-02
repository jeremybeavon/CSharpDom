namespace CSharpDom.TestTarget.SealedClasses.ConversionOperators
{
    public sealed class SealedClassWithImplicitConversionOperatorWith1ParameterAttribute
    {
        public static implicit operator SealedClassWithImplicitConversionOperatorWith1ParameterAttribute([Attribute1]string text)
        {
            return default(SealedClassWithImplicitConversionOperatorWith1ParameterAttribute);
        }
    }
}
