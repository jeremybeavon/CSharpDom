namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.Events
{
    public abstract partial class AbstractPartialClassWithNestedStructWithEventWith2AttributesIn2AttributeGroups
    {
        public struct Struct
        {
            [Attribute1]
            [Attribute2]
            public event EventHandler Event;
        }
    }
}
