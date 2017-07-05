namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.Events
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithNewEvent
    {
        public abstract class Class : BaseClassWithEvent
        {
            public new event EventHandler Event;
        }
    }
}
