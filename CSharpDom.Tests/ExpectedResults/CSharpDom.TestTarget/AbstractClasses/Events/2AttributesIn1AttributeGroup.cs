namespace CSharpDom.TestTarget.AbstractClasses.Events
{
    public abstract class AbstractClassWithEventWith2AttributesIn1AttributeGroup
    {
        [Attribute1, Attribute2]
        public event EventHandler Event;
    }
}
