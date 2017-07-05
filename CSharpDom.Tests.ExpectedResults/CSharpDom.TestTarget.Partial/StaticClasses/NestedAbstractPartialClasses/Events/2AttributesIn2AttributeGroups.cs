namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractPartialClasses.Events
{
    public static class StaticClassWithNestedAbstractPartialClassWithEventWith2AttributesIn2AttributeGroups
    {
        public abstract partial class Class
        {
            [Attribute1]
            [Attribute2]
            public event EventHandler Event;
        }
    }
}
