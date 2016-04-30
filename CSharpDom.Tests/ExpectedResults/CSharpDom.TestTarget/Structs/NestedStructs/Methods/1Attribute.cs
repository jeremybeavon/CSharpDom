namespace CSharpDom.TestTarget.Structs.NestedStructs.Methods
{
    public struct StructWithNestedStructWithMethodWith1Attribute
    {
        public struct Struct
        {
            [Attribute1]
            public void Method()
            {
            }
        }
    }
}
