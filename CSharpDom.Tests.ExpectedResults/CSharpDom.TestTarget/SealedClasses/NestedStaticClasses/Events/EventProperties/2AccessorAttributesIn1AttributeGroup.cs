namespace CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.Events.EventProperties
{
    public sealed class SealedClassWithNestedStaticClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroup
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
