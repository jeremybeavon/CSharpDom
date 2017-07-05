namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.ConversionOperators
{
    public sealed class SealedClassWithNestedSealedPartialClassWithExplicitConversionOperatorWith1Attribute
    {
        public sealed partial class Class
        {
            [Attribute1]
            public static explicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
