namespace CSharpDom.TestTarget.SealedClasses.Events
{
    public sealed class SealedClassWithEventWith2AttributesIn1AttributeGroup
    {
        [Attribute1, Attribute2]
        public event EventHandler Event;
    }
}
