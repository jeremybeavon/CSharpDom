namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStaticClasses.Events
{
    public partial class PartialClassWithNestedStaticClassWithEventWith2AttributesIn1AttributeGroup
    {
        public static class Class
        {
            [Attribute1, Attribute2]
            public static event EventHandler Event;
        }
    }
}
