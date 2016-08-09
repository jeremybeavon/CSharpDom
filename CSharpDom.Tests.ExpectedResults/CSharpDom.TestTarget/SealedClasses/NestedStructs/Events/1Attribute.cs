namespace CSharpDom.TestTarget.SealedClasses.NestedStructs.Events
{
    public sealed class SealedClassWithNestedStructWithEventWith1Attribute
    {
        public struct Struct
        {
            [Attribute1]
            public event EventHandler Event;
        }
    }
}
