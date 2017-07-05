namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.Events.EventProperties
{
    public struct StructWithNestedStructWithEventPropertyWith2AttributesIn1AttributeGroup
    {
        public struct Struct
        {
            [Attribute1, Attribute2]
            public event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
