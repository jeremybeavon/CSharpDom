namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedStaticClasses.Events.EventProperties
{
    public static partial class StaticPartialClassWithNestedStaticClassWithEventPropertyWith2AttributesIn2AttributeGroups
    {
        public static class Class
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
