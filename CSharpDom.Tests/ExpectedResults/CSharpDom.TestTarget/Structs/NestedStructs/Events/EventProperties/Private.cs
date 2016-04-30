namespace CSharpDom.TestTarget.Structs.NestedStructs.Events.EventProperties
{
    public struct StructWithNestedStructWithPrivateEventProperty
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
