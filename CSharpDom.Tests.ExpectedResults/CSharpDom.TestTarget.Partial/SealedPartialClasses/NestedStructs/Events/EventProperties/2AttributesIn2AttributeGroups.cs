namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.Events.EventProperties
{
    public sealed partial class SealedPartialClassWithNestedStructWithEventPropertyWith2AttributesIn2AttributeGroups
    {
        public struct Struct
        {
            [Attribute1]
            [Attribute2]
            public event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
