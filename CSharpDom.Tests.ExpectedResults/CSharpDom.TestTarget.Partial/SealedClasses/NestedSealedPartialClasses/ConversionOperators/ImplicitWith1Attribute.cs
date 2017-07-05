namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.ConversionOperators
{
    public sealed class SealedClassWithNestedSealedPartialClassWithImplicitConversionOperatorWith1Attribute
    {
        public sealed partial class Class
        {
            [Attribute1]
            public static implicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
