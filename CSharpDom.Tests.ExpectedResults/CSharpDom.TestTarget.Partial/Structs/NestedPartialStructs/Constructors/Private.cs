namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.Constructors
{
    public struct StructWithNestedStructWithPrivateConstructor
    {
        public struct Struct
        {
            private Struct(string text)
            {
            }
        }
    }
}
