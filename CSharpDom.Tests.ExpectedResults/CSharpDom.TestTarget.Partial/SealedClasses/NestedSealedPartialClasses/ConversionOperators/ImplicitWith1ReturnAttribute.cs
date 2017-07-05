namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.ConversionOperators
{
    public sealed class SealedClassWithNestedSealedPartialClassWithImplicitConversionOperatorWith1ReturnAttribute
    {
        public sealed partial class Class
        {
            [return: Attribute1]
            public static implicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
