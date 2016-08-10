namespace CSharpDom.TestTarget.SealedClasses.NestedStructs.Events
{
    public sealed class SealedClassWithNestedStructsWithEventWith2AttributesIn1AttributeGroup
    {
        public struct Struct
        {
            [Attribute1, Attribute2]
            public event EventHandler Event;
        }
    }
}
