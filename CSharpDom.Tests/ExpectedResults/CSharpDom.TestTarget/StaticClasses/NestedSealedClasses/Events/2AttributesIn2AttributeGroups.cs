namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Constructors
{
    public static class StaticClassWithNestedSealedClassWithEventWith2AttributesIn2AttributeGroups
    {
        public sealed class Class
        {
            [Attribute1]
            [Attribute2]
            public event EventHandler Event;
        }
    }
}
