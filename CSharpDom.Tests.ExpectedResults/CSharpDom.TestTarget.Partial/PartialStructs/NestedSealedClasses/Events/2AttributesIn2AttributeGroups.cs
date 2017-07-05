namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.Events
{
    public partial struct PartialStructWithWithNestedSealedClassWithEventWith2AttributesIn2AttributeGroups
    {
        public sealed class Class
        {
            [Attribute1]
            [Attribute2]
            public event EventHandler Event;
        }
    }
}
