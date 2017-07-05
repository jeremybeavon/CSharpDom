namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.Events
{
    public struct StructWithNestedSealedPartialClassWithNewEvent
    {
        public sealed class Class : BaseClassWithEvent
        {
            public new event EventHandler Event;
        }
    }
}
