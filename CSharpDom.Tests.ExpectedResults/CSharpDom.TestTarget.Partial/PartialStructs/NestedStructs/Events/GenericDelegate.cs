namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.Events
{
    public partial struct PartialStructWithNestedStructWithEventWithGenericDelegate
    {
        public struct Struct
        {
            public event EventHandler<EventArgs> Event;
        }
    }
}
