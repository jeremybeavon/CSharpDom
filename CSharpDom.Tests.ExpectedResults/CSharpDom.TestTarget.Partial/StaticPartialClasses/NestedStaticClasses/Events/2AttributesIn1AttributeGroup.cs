namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedStaticClasses.Events
{
    public static partial class StaticPartialClassWithNestedStaticClassWithEventWith2AttributesIn1AttributeGroup
    {
        public static class Class
        {
            [Attribute1, Attribute2]
            public static event EventHandler Event;
        }
    }
}
