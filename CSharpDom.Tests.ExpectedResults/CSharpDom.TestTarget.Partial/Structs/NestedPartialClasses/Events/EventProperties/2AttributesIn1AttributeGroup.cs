namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.Events.EventProperties
{
    public struct StructWithNestedPartialClassWithEventPropertyWith2AttributesIn1AttributeGroup
    {
        public partial class Class
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
