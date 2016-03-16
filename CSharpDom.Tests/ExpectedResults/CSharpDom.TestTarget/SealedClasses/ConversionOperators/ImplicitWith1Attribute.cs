namespace CSharpDom.TestTarget.SealedClasses.ConversionOperators
{
    public sealed class SealedClassWithImplicitConversionOperatorWith1Attribute
    {
        [Attribute1]
        public static implicit operator SealedClassWithImplicitConversionOperatorWith1Attribute(string text)
        {
            return default(SealedClassWithImplicitConversionOperatorWith1Attribute);
        }
    }
}
