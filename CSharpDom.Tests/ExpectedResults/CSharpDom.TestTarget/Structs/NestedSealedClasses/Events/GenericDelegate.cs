namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.Events
{
    public struct StructWithNestedSealedClassWithEventWithGenericDelegate
    {
        public sealed class Class
        {
            public event EventHandler<EventArgs> Event;
        }
    }
}
