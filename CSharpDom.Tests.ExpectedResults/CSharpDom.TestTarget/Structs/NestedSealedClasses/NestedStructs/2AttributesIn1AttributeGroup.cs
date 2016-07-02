namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.NestedStructs
{
    public struct StructWithNestedSealedClassWithNestedStructWith2AttributesIn1AttributeGroup
    {
        public sealed class Class
        {
            [Attribute1, Attribute2]
            public struct NestedStruct
            {
            }
        }
    }
}
