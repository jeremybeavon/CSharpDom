namespace CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.Events.EventProperties
{
    public static class StaticClassWithNestedStaticClassWithPrivateEventProperty
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
