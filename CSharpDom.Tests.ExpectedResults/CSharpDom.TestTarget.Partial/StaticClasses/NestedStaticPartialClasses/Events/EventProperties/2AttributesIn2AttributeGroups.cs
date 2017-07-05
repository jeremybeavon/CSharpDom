namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedStaticPartialClasses.Events.EventProperties
{
    public static class StaticClassWithNestedStaticPartialClassWithEventPropertyWith2AttributesIn2AttributeGroups
    {
        public static partial class Class
        {
            [Attribute1]
            [Attribute2]
            public static event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
