namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.Events.EventProperties
{
    public partial struct PartialStructWithWithNestedStructWithInternalEventProperty
    {
        public struct Struct
        {
            internal event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
