namespace CSharpDom.TestTarget.Structs.NestedStructs.Events.EventProperties
{
    public struct StructWithNestedStructWithPublicEventProperty
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
