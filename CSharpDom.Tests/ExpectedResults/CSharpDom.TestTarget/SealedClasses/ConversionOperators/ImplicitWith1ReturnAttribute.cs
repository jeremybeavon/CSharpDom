namespace CSharpDom.TestTarget.SealedClasses.ConversionOperators
{
    public sealed class SealedClassWithImplicitConversionOperatorWith1ReturnAttribute
    {
        [return: Attribute1]
        public static implicit operator SealedClassWithImplicitConversionOperatorWith1ReturnAttribute(string text)
        {
            return default(SealedClassWithImplicitConversionOperatorWith1ReturnAttribute);
        }
    }
}
