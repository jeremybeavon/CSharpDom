namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.Events.EventProperties
{
    public partial class PartialClassWithNestedStructWithEventPropertyWith2AttributesIn2AttributeGroups
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
