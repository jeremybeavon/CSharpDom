namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedStaticClasses.Events.EventProperties
{
    public static partial class StaticPartialClassWithNestedStaticClassWithEventPropertyWith2AttributesIn1AttributeGroup
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
