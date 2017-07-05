namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.Events
{
    public sealed partial class SealedPartialClassWithNestedStructWithEventWith1Attribute
    {
        public struct Struct
        {
            [Attribute1]
            public event EventHandler Event;
        }
    }
}
