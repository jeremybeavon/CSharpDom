namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.Events.EventProperties
{
    public partial class PartialClassWithNestedStructWithEventPropertyWith2AttributesIn1AttributeGroup
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
