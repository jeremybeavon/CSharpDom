namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.Events
{
    public sealed partial class SealedPartialClassWithNestedStructsWithEventWith2AttributesIn1AttributeGroup
    {
        public struct Struct
        {
            [Attribute1, Attribute2]
            public event EventHandler Event;
        }
    }
}
