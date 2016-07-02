namespace CSharpDom.TestTarget.Classes.NestedStructs.Events
{
    public struct StructWithNestedStructsWithEventWith1Attribute
    {
        public struct Struct
        {
            [Attribute1]
            public event EventHandler Event;
        }
    }
}
