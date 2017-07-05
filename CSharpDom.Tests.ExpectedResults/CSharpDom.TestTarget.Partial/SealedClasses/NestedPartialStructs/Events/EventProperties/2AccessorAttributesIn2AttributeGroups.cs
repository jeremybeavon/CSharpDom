namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.Events.EventProperties
{
    public sealed class SealedClassWithNestedStructWithEventPropertyWith2AccessorAttributesIn2AttributeGroups
    {
        public struct Struct
        {
            public event EventHandler Event
            {
                [Attribute1]
                [Attribute2]
                add { }
                [Attribute1]
                [Attribute2]
                remove { }
            }
        }
    }
}
