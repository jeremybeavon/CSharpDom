namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.Events
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithNewEvent
    {
        public sealed class Class : BaseClassWithEvent
        {
            public new event EventHandler Event;
        }
    }
}
