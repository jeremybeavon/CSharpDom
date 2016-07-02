namespace CSharpDom.TestTarget.Structs.NestedStructs.Events.EventProperties
{
    public struct StructWithNestedStructWithStaticEventProperty
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
