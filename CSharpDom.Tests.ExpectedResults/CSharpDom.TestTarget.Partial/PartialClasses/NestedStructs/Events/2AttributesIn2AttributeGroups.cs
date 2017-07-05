namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.Events
{
    public partial class PartialClassWithNestedStructWithEventWith2AttributesIn2AttributeGroups
    {
        public struct Struct
        {
            [Attribute1]
            [Attribute2]
            public event EventHandler Event;
        }
    }
}
