namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.Events
{
    public struct StructWithNestedSealedPartialClassWithEventWithGenericDelegate
    {
        public sealed partial class Class
        {
            public event EventHandler<EventArgs> Event;
        }
    }
}
