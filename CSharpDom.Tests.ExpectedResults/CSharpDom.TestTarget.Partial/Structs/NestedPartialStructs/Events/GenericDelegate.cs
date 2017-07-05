namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.Events
{
    public struct StructWithNestedStructWithEventWithGenericDelegate
    {
        public struct Struct
        {
            public event EventHandler<EventArgs> Event;
        }
    }
}
