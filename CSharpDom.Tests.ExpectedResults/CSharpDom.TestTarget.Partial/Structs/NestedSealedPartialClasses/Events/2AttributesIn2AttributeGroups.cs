namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.Events
{
    public struct StructWithNestedSealedPartialClassWithEventWith2AttributesIn2AttributeGroups
    {
        public sealed partial class Class
        {
            [Attribute1]
            [Attribute2]
            public event EventHandler Event;
        }
    }
}
