namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.Events.EventProperties
{
    public partial struct PartialStructWithWithNestedStructWithStaticEventProperty
    {
        public struct Struct
        {
            public static event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
