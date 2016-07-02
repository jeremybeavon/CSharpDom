namespace CSharpDom.TestTarget.SealedClasses.NestedStructs.Events
{
    public sealed class SealedClassWithNestedStructWithEventWithGenericDelegate
    {
        public struct Struct
        {
            public event EventHandler<EventArgs> Event;
        }
    }
}
