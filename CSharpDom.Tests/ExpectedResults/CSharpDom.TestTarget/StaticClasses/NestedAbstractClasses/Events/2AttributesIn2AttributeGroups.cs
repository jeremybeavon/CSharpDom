namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Events
{
    public static class StaticClassWithNestedAbstractClassWithEventWith2AttributesIn2AttributeGroups
    {
        public abstract class Class
        {
            [Attribute1]
            [Attribute2]
            public event EventHandler Event;
        }
    }
}
