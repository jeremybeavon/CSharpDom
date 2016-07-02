namespace CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.Events.EventProperties
{
    public abstract class AbstractClassWithNestedStaticClassWithEventPropertyWith2AttributesIn1AttributeGroup
    {
        public static class Class
        {
            [Attribute1, Attribute2]
            public static event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
