namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStaticClasses.Events.EventProperties
{
    public partial class PartialClassWithNestedStaticClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroup
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
