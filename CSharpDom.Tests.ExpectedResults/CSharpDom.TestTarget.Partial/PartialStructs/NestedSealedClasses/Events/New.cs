namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.Events
{
    public partial struct PartialStructWithWithNestedSealedClassWithNewEvent
    {
        public sealed class Class : BaseClassWithEvent
        {
            public new event EventHandler Event;
        }
    }
}
