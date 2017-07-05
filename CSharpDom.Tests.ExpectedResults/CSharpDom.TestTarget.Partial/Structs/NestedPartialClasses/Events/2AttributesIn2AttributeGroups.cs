namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.Events
{
    public struct StructWithNestedPartialClassWithEventWith2AttributesIn2AttributeGroups
    {
        public partial class Class
        {
            [Attribute1]
            [Attribute2]
            public event EventHandler Event;
        }
    }
}
