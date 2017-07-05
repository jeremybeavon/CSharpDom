namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStaticClasses.Events.EventProperties
{
    public partial class PartialClassWithNestedStaticClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups
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
