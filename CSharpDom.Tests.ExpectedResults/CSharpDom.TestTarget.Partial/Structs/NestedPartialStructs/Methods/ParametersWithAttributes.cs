namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.Methods
{
    public struct StructWithNestedStructWithMethodWithParametersWithAttributes
    {
        public struct Struct
        {
            public void Method([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
