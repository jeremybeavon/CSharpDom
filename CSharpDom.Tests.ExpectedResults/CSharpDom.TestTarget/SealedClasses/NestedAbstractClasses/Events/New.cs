namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Events
{
    public sealed class SealedClassWithNestedAbstractClassWithNewEvent
    {
        public abstract class Class : BaseClassWithEvent
        {
            public new event EventHandler Event;
        }
    }
}
