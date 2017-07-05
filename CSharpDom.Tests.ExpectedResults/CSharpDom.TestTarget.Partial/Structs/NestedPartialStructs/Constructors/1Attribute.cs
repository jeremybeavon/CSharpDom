namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.Constructors
{
    public struct StructWithNestedStructWithConstructorWith1Attribute
    {
        public struct Struct
        {
            [Attribute1]
            public Struct(string text)
            {
            }
        }
    }
}
