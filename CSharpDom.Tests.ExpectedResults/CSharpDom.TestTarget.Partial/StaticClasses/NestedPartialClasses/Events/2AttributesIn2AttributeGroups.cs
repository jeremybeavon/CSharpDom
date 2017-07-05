namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.Events
{
    public static class StaticClassWithNestedPartialClassWithEventWith2AttributesIn2AttributeGroups
    {
        public partial class Class
        {
            [Attribute1]
            [Attribute2]
            public event EventHandler Event;
        }
    }
}
