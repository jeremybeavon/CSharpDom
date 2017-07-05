namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.Events.EventProperties
{
    public sealed partial class SealedPartialClassWithNestedStructWithEventPropertyWith1AccessorAttribute
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
