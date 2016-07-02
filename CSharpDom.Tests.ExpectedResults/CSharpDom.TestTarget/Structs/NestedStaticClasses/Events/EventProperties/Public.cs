namespace CSharpDom.TestTarget.Structs.NestedStaticClasses.Events.EventProperties
{
    public struct StructWithNestedStaticClassWithPublicEventProperty
    {
        public static class Class
        {
            public static event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
