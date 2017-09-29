namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.Events
{
    public partial struct PartialStructWithNestedStructWithEventWith1Attribute
    {
        public struct Struct
        {
            [Attribute1]
            public event EventHandler Event;
        }
    }
}
