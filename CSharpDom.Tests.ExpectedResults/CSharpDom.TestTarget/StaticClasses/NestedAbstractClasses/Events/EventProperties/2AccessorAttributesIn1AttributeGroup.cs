namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Events.EventProperties
{
    public static class StaticClassWithNestedAbstractClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroup
    {
        public abstract class Class
        {
            public event EventHandler Event
            {
                [Attribute1, Attribute2]
                add { }
                [Attribute1, Attribute2]
                remove { }
            }
        }
    }
}
