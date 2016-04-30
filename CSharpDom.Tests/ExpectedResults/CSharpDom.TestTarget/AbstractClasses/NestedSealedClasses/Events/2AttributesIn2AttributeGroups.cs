namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Constructors
{
    public abstract class AbstractClassWithNestedSealedClassWithEventWith2AttributesIn2AttributeGroups
    {
        public sealed class Class
        {
            [Attribute1]
            [Attribute2]
            public event EventHandler Event;
        }
    }
}
