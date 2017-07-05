namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.Events
{
    public struct StructWithNestedStructWithEventWith2AttributesIn2AttributeGroups
    {
        public struct Struct
        {
            [Attribute1]
            [Attribute2]
            public event EventHandler Event;
        }
    }
}
