namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.Events
{
    public sealed partial class SealedPartialClassWithNestedStructWithEventWith2AttributesIn2AttributeGroups
    {
        public struct Struct
        {
            [Attribute1]
            [Attribute2]
            public event EventHandler Event;
        }
    }
}
