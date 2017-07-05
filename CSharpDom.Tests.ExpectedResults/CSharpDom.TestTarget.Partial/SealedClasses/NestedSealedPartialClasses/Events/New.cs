namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.Events
{
    public sealed class SealedClassWithNestedSealedPartialClassWithNewEvent
    {
        public sealed class Class : BaseClassWithEvent
        {
            public new event EventHandler Event;
        }
    }
}
