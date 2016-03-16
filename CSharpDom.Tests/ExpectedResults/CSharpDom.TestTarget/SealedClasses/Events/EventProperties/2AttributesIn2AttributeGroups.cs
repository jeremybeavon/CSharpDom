namespace CSharpDom.TestTarget.SealedClasses.Constructors
{
    public sealed class SealedClassWithEventPropertyWith2AttributesIn2AttributeGroups
    {
        [Attribute1]
        [Attribute2]
        public event EventHandler Event
        {
            add { }
            remove { }
        }
    }
}
