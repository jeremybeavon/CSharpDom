namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.Events
{
    public abstract class AbstractClassWithNestedAbstractClassWithEventWith2AttributesIn2AttributeGroups
    {
        public abstract class Class
        {
            [Attribute1]
            [Attribute2]
            public event EventHandler Event;
        }
    }
}
