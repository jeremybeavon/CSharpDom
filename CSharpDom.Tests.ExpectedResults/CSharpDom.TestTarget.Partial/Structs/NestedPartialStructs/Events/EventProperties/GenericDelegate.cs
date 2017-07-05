namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.Events.EventProperties
{
    public struct StructWithNestedStructWithEventPropertyWithGenericDelegate
    {
        public struct Struct
        {
            public event EventHandler<EventArgs> Event
            {
                add { }
                remove { }
            }
        }
    }
}
