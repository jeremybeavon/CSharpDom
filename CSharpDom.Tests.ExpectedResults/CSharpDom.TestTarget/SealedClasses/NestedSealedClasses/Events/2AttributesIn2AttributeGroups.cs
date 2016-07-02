namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Constructors
{
    public sealed class SealedClassWithNestedSealedClassWithEventWith2AttributesIn2AttributeGroups
    {
        public sealed class Class
        {
            [Attribute1]
            [Attribute2]
            public event EventHandler Event;
        }
    }
}
