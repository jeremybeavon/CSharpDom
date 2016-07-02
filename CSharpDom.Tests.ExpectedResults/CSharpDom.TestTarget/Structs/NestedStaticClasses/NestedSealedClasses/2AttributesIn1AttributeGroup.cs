namespace CSharpDom.TestTarget.Structs.NestedStaticClasses.NestedSealedClasses
{
    public struct StructWithNestedStaticClassWithNestedSealedClassWith2AttributesIn1AttributeGroup
    {
        public static class Class
        {
            [Attribute1, Attribute2]
            public sealed class NestedClass
            {
            }
        }
    }
}
