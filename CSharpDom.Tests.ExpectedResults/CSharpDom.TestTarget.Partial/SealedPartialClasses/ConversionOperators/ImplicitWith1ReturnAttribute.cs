namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.ConversionOperators
{
    public sealed partial class SealedPartialClassWithImplicitConversionOperatorWith1ReturnAttribute
    {
        [return: Attribute1]
        public static implicit operator SealedClassWithImplicitConversionOperatorWith1ReturnAttribute(string text)
        {
            return default(SealedClassWithImplicitConversionOperatorWith1ReturnAttribute);
        }
    }
}
