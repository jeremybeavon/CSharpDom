namespace CSharpDom.TestTarget.Structs.NestedStructs.Methods
{
    public struct StructWithNestedStructWithMethodWith2ReturnAttributesIn1AttributeGroup
    {
        public struct Struct
        {
            [return: Attribute1, Attribute2]
            public void Method()
            {
            }
        }
    }
}
