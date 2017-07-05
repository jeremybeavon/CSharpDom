namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractPartialClasses.Events.EventProperties
{
    public static class StaticClassWithNestedAbstractPartialClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups
    {
        public abstract partial class Class
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
