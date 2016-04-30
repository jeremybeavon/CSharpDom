namespace CSharpDom.TestTarget.Structs.NestedStructs.Constructors
{
    public struct StructWithNestedStructWithConstructorWith2AttributesIn1AttributeGroup
    {
        public struct Struct
        {
            [Attribute1, Attribute2]
            public Struct(string text)
            {
            }
        }
    }
}
