namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStaticClasses.Events.EventProperties
{
    public sealed partial class SealedPartialClassWithNestedStaticClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroup
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
