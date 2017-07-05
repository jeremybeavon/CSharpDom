namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.Events.EventProperties
{
    public sealed class SealedClassWithNestedStructWithEventPropertyWith1Attribute
    {
        public struct Struct
        {
            [Attribute1]
            public event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
