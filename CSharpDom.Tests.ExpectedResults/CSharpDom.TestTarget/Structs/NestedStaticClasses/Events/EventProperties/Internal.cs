namespace CSharpDom.TestTarget.Structs.NestedStaticClasses.Events.EventProperties
{
    public struct StructWithNestedStaticClassWithInternalEventProperty
    {
        public static class Class
        {
            internal static event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
