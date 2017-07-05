namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.Events
{
    public partial struct PartialStructWithWithNestedStructWithEventWith2AttributesIn2AttributeGroups
    {
        public struct Struct
        {
            [Attribute1]
            [Attribute2]
            public event EventHandler Event;
        }
    }
}
