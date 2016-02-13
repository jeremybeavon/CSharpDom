namespace CSharpDom.TestTarget.Classes.Events
{
    public sealed class ClassWithEventWith2AttributesIn1AttributeGroup
    {
        [Attribute1, Attribute2]
        public event EventHandler Event;
    }
}
