namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.Events
{
    public abstract partial class AbstractPartialClassWithNestedStructsWithEventWith2AttributesIn1AttributeGroup
    {
        public struct Struct
        {
            [Attribute1, Attribute2]
            public event EventHandler Event;
        }
    }
}
