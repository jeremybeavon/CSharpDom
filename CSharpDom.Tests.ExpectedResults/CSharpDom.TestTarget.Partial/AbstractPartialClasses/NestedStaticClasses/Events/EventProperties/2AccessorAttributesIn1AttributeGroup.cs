namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStaticClasses.Events.EventProperties
{
    public abstract partial class AbstractPartialClassWithNestedStaticClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroup
    {
        public static class Class
        {
            public static event EventHandler Event
            {
                [Attribute1, Attribute2]
                add { }
                [Attribute1, Attribute2]
                remove { }
            }
        }
    }
}
