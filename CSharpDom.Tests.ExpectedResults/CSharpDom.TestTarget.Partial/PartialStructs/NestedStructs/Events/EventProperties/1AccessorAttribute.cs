namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.Events.EventProperties
{
    public partial struct PartialStructWithWithNestedStructWithEventPropertyWith1AccessorAttribute
    {
        public struct Struct
        {
            public event EventHandler Event
            {
                [Attribute1]
                add { }
                [Attribute1]
                remove { }
            }
        }
    }
}
