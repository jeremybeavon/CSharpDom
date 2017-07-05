namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStaticClasses.Events
{
    public abstract partial class AbstractPartialClassWithNestedStaticClassWithEventWith2AttributesIn1AttributeGroup
    {
        public static class Class
        {
            [Attribute1, Attribute2]
            public static event EventHandler Event;
        }
    }
}
