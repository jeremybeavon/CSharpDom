namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedStaticClasses.Events.EventProperties
{
    public static partial class StaticPartialClassWithNestedStaticClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups
    {
        public static class Class
        {
            public static event EventHandler Event
            {
                [Attribute1]
                [Attribute2]
                add { }
                [Attribute1]
                [Attribute2]
                remove { }
            }
        }
    }
}
