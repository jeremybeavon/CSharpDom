namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedStaticPartialClasses.Events
{
    public static class StaticClassWithNestedStaticPartialClassWithEventWith2AttributesIn1AttributeGroup
    {
        public static partial class Class
        {
            [Attribute1, Attribute2]
            public static event EventHandler Event;
        }
    }
}
