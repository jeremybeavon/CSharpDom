namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.ConversionOperators
{
    public sealed partial class SealedPartialClassWithImplicitConversionOperatorWith1ParameterAttribute
    {
        public static implicit operator SealedClassWithImplicitConversionOperatorWith1ParameterAttribute([Attribute1]string text)
        {
            return default(SealedClassWithImplicitConversionOperatorWith1ParameterAttribute);
        }
    }
}
