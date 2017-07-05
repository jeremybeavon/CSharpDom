namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.Events
{
    public static class StaticClassWithNestedSealedPartialClassWithEventWith2AttributesIn2AttributeGroups
    {
        public sealed partial class Class
        {
            [Attribute1]
            [Attribute2]
            public event EventHandler Event;
        }
    }
}
