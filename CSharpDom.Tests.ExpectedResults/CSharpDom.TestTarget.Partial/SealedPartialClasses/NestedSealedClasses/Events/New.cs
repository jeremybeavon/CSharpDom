namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.Events
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithNewEvent
    {
        public sealed class Class : BaseClassWithEvent
        {
            public new event EventHandler Event;
        }
    }
}
