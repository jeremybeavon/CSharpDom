namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.ConversionOperators
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithExplicitConversionOperatorWith1ReturnAttribute
    {
        public sealed class Class
        {
            [return: Attribute1]
            public static explicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
