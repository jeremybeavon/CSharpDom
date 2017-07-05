namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.ConversionOperators
{
    public sealed partial class SealedPartialClassWithImplicitConversionOperatorWith1Attribute
    {
        [Attribute1]
        public static implicit operator SealedClassWithImplicitConversionOperatorWith1Attribute(string text)
        {
            return default(SealedClassWithImplicitConversionOperatorWith1Attribute);
        }
    }
}
