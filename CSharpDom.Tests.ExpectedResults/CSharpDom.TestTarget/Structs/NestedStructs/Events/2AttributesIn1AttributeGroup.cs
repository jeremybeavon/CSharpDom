namespace CSharpDom.TestTarget.Structs.NestedStructs.Events
{
    public struct StructWithNestedStructWithEventWith2AttributesIn1AttributeGroup
    {
        public struct Struct
        {
            [Attribute1, Attribute2]
            public event EventHandler Event;
        }
    }
}
