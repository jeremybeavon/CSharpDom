namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.Events.EventProperties
{
    public partial struct PartialStructWithWithNestedStructWithEventPropertyWith2AttributesIn1AttributeGroup
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
