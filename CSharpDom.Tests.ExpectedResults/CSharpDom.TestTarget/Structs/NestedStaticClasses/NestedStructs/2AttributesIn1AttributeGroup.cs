namespace CSharpDom.TestTarget.Structs.NestedStaticClasses.NestedStructs
{
    public struct StructWithNestedStaticClassWithNestedStructWith2AttributesIn1AttributeGroup
    {
        public static class Class
        {
            [Attribute1, Attribute2]
            public struct NestedStruct
            {
            }
        }
    }
}
