namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Events
{
    public sealed class SealedClassWithNestedSealedClassWithNewEvent
    {
        public sealed class Class : BaseClassWithEvent
        {
            public new event EventHandler Event;
        }
    }
}
