namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.Events.EventProperties
{
    public partial struct PartialStructWithWithNestedStructWithEventPropertyWithGenericDelegate
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
