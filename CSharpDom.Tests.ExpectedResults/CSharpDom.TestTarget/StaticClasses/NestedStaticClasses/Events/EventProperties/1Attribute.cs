namespace CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.Events.EventProperties
{
    public static class StaticClassWithNestedStaticClassWithEventPropertyWith1Attribute
    {
        public static class Class
        {
            [Attribute1]
            public static event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
