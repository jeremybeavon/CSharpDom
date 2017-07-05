namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.Events
{
    public sealed class SealedClassWithNestedStructWithEventWith2AttributesIn2AttributeGroups
    {
        public struct Struct
        {
            [Attribute1]
            [Attribute2]
            public event EventHandler Event;
        }
    }
}
