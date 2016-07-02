namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.ConversionOperators
{
    public sealed class SealedClassWithNestedSealedClassWithImplicitConversionOperatorWith1Attribute
    {
        public sealed class Class
        {
            [Attribute1]
            public static implicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
