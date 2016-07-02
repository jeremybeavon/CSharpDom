namespace CSharpDom.TestTarget.Structs.NestedStructs.Methods
{
    public struct StructWithNestedStructWithMethodWith2ReturnAttributesIn2AttributeGroups
    {
        public struct Struct
        {
            [return: Attribute1]
            [return: Attribute2]
            public void Method()
            {
            }
        }
    }
}
