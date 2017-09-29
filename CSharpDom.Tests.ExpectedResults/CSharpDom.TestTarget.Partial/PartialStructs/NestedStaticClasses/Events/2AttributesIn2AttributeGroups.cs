namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStaticClasses.Events
{
    public partial struct PartialStructWithNestedStaticClassWithEventWith2AttributesIn2AttributeGroups
    {
        public static class Class
        {
            [Attribute1]
            [Attribute2]
            public static event EventHandler Event;
        }
    }
}
