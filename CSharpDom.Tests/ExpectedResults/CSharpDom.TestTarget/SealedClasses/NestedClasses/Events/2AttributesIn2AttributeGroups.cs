namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.Events
{
    public sealed class SealedClassWithNestedClassWithEventWith2AttributesIn2AttributeGroups
    {
        public class Class
        {
            [Attribute1]
            [Attribute2]
            public event EventHandler Event;
        }
    }
}
