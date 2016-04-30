namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Events
{
    public sealed class SealedClassWithNestedAbstractClassWithEventWithGenericDelegate
    {
        public abstract class Class
        {
            public event EventHandler<EventArgs> Event;
        }
    }
}
