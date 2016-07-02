namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.ConversionOperators
{
    public struct StructWithNestedSealedClassWithExplicitConversionOperatorWith2AttributesIn1AttributeGroup
    {
        public sealed class Class
        {
            [Attribute1, Attribute2]
            public static explicit operator Class(string text)
            {
                return default(Class);
            }
        }
    }
}
