namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.Events.EventProperties
{
    public partial struct PartialStructWithWithNestedStructWithPublicEventProperty
    {
        public struct Struct
        {
            public event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
