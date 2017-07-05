namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.NestedStructs
{
    public struct StructWithNestedStructWithNestedStructWith1Attribute
    {
        public struct Struct
        {
            [Attribute1]
            public struct NestedStruct
            {
            }
        }
    }
}
