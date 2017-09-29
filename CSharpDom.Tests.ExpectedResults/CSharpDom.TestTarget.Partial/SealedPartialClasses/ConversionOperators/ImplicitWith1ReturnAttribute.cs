namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.ConversionOperators
{
    public sealed partial class SealedPartialClassWithImplicitConversionOperatorWith1ReturnAttribute
    {
        [return: Attribute1]
        public static implicit operator SealedPartialClassWithImplicitConversionOperatorWith1ReturnAttribute(string text)
        {
            return default(SealedPartialClassWithImplicitConversionOperatorWith1ReturnAttribute);
        }
    }
}
