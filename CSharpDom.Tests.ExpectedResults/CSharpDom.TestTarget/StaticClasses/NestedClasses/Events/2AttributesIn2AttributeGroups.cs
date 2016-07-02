namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.Events
{
    public static class StaticClassWithNestedClassWithEventWith2AttributesIn2AttributeGroups
    {
        public class Class
        {
            [Attribute1]
            [Attribute2]
            public event EventHandler Event;
        }
    }
}
