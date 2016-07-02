namespace CSharpDom.TestTarget.Structs.NestedStaticClasses.Events.EventProperties
{
    public struct StructWithNestedStaticClassWithPrivateEventProperty
    {
        public static class Class
        {
            private static event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
