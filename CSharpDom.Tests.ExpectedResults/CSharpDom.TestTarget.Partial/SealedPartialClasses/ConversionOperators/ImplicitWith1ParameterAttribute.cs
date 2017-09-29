namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.ConversionOperators
{
    public sealed partial class SealedPartialClassWithImplicitConversionOperatorWith1ParameterAttribute
    {
        public static implicit operator SealedPartialClassWithImplicitConversionOperatorWith1ParameterAttribute([Attribute1]string text)
        {
            return default(SealedPartialClassWithImplicitConversionOperatorWith1ParameterAttribute);
        }
    }
}
