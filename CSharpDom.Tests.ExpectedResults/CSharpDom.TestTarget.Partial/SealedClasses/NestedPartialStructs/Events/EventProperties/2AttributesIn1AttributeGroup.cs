namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.Events.EventProperties
{
    public sealed class SealedClassWithNestedStructWithEventPropertyWith2AttributesIn1AttributeGroup
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
