namespace CSharpDom.TestTarget.Structs.NestedStructs.NestedEnums
{
    public struct StructWithNestedStructWithNestedEnumWith2AttributesIn1AttributeGroup
    {
        public struct Struct
        {
            [Attribute1, Attribute2]
            public enum Enum
            {
            }
        }
    }
}
