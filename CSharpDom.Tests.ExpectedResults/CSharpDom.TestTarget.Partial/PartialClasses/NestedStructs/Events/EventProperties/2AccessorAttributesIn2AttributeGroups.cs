namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.Events.EventProperties
{
    public partial class PartialClassWithNestedStructWithEventPropertyWith2AccessorAttributesIn2AttributeGroups
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
