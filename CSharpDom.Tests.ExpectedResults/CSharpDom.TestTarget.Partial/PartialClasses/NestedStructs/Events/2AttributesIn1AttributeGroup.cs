namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.Events
{
    public partial class PartialClassWithNestedStructsWithEventWith2AttributesIn1AttributeGroup
    {
        public struct Struct
        {
            [Attribute1, Attribute2]
            public event EventHandler Event;
        }
    }
}
