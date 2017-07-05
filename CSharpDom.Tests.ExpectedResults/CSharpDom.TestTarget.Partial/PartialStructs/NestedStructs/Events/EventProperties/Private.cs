namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.Events.EventProperties
{
    public partial struct PartialStructWithWithNestedStructWithPrivateEventProperty
    {
        public struct Struct
        {
            private event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
