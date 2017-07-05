namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.Events.EventProperties
{
    public struct StructWithNestedStructWithEventPropertyWith1AccessorAttribute
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
