namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.Events.EventProperties
{
    public sealed class SealedClassWithNestedStructWithEventPropertyWith1AccessorAttribute
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
