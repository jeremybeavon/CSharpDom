namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.Events
{
    public struct StructWithNestedStructWithEventWith1Attribute
    {
        public struct Struct
        {
            [Attribute1]
            public event EventHandler Event;
        }
    }
}
