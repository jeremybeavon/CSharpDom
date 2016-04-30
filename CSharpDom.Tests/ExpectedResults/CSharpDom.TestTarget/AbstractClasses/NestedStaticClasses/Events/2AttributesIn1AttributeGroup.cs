namespace CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.Events
{
    public abstract class AbstractClassWithNestedStaticClassWithEventWith2AttributesIn1AttributeGroup
    {
        public static class Class
        {
            [Attribute1, Attribute2]
            public static event EventHandler Event;
        }
    }
}
