namespace CSharpDom.TestTarget.AbstractClasses.Events
{
    public abstract class AbstractClassWithEventWith2AttributesIn2AttributeGroups
    {
        [Attribute1]
        [Attribute2]
        public event EventHandler Event;
    }
}
