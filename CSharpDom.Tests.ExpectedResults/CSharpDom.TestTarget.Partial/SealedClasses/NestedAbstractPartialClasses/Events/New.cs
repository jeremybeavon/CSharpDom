namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.Events
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithNewEvent
    {
        public abstract class Class : BaseClassWithEvent
        {
            public new event EventHandler Event;
        }
    }
}
