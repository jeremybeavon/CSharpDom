namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStaticClasses.Events
{
    public sealed partial class SealedPartialClassWithNestedStaticClassWithEventWith2AttributesIn2AttributeGroups
    {
        public static class Class
        {
            [Attribute1]
            [Attribute2]
            public static event EventHandler Event;
        }
    }
}
