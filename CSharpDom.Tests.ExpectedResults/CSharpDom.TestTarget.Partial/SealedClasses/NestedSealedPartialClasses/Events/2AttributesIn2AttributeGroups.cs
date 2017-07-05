namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.Events
{
    public sealed class SealedClassWithNestedSealedPartialClassWithEventWith2AttributesIn2AttributeGroups
    {
        public sealed partial class Class
        {
            [Attribute1]
            [Attribute2]
            public event EventHandler Event;
        }
    }
}
