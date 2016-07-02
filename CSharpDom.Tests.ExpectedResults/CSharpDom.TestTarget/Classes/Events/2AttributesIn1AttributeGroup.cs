namespace CSharpDom.TestTarget.Classes.Events
{
    public class ClassWithEventWith2AttributesIn1AttributeGroup
    {
        [Attribute1, Attribute2]
        public event EventHandler Event;
    }
}
