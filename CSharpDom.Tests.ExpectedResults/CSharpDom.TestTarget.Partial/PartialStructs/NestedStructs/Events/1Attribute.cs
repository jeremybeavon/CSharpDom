namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.Events
{
    public partial struct PartialStructWithWithNestedStructWithEventWith1Attribute
    {
        public struct Struct
        {
            [Attribute1]
            public event EventHandler Event;
        }
    }
}
