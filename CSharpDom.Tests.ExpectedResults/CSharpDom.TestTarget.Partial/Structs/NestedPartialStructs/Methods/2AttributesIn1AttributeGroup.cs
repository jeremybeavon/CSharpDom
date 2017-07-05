namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.Methods
{
    public struct StructWithNestedStructWithMethodWith2AttributesIn1AttributeGroup
    {
        public struct Struct
        {
            [Attribute1, Attribute2]
            public void Method()
            {
            }
        }
    }
}
