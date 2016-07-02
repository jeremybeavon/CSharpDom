namespace CSharpDom.TestTarget.Structs.NestedStructs.Constructors
{
    public struct StructWithNestedStructWithInternalConstructor
    {
        public struct Struct
        {
            internal Struct(string text)
            {
            }
        }
    }
}
