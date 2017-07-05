namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.Methods
{
    public partial struct PartialStructWithWithNestedStructWithMethodWith2ReturnAttributesIn1AttributeGroup
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
