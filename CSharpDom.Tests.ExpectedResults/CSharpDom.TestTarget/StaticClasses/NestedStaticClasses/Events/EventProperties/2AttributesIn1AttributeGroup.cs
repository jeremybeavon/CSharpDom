namespace CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.Events.EventProperties
{
    public static class StaticClassWithNestedStaticClassWithEventPropertyWith2AttributesIn1AttributeGroup
    {
        public static class Class
        {
            [Attribute1, Attribute2]
            public static event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
