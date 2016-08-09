namespace CSharpDom.TestTarget.SealedClasses.Events
{
    public sealed class SealedClassWithEventWith2AttributesIn2AttributeGroups
    {
        [Attribute1]
        [Attribute2]
        public event EventHandler Event;
    }
}
