namespace CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.Events.EventProperties
{
    public static class StaticClassWithNestedStaticClassWithEventPropertyWithGenericDelegate
    {
        public static class Class
        {
            public static event EventHandler<EventArgs> Event
            {
                add { }
                remove { }
            }
        }
    }
}
