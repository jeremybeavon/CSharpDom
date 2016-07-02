namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.ConversionOperators
{
    public sealed class SealedClassWithNestedSealedClassWithImplicitConversionOperatorWith2AttributesIn1AttributeGroup
    {
        public sealed class Class
        {
            [Attribute1, Attribute2]
            public static implicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
