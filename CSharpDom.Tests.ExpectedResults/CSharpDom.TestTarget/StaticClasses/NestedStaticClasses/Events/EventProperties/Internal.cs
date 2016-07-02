namespace CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.Events.EventProperties
{
    public static class StaticClassWithNestedStaticClassWithInternalEventProperty
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
