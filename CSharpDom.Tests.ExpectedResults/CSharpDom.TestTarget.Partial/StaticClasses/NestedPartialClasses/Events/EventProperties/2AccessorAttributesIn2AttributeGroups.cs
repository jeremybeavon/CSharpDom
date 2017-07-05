namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.Events.EventProperties
{
    public static class StaticClassWithNestedPartialClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups
    {
        public partial class Class
        {
            public event EventHandler Event
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
