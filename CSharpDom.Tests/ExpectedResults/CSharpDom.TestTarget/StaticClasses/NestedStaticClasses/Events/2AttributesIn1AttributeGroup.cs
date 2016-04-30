namespace CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.Events
{
    public static class StaticClassWithNestedStaticClassWithEventWith2AttributesIn1AttributeGroup
    {
        public static class Class
        {
            [Attribute1, Attribute2]
            public static event EventHandler Event;
        }
    }
}
