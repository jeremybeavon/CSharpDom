namespace CSharpDom.TestTarget.Structs.NestedStructs.Events
{
    public struct StructWithNestedStructWithEventWithGenericDelegate
    {
        public struct Struct
        {
            public event EventHandler<EventArgs> Event;
        }
    }
}
