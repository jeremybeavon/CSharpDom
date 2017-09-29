namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStaticClasses.Events
{
    public partial struct PartialStructWithNestedStaticClassWithEventWith2AttributesIn1AttributeGroup
    {
        public static class Class
        {
            [Attribute1, Attribute2]
            public static event EventHandler Event;
        }
    }
}
