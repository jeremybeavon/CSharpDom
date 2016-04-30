namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.ConversionOperators
{
    public static class StaticClassWithNestedSealedClassWithImplicitConversionOperatorWith2AttributesIn1AttributeGroup
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
