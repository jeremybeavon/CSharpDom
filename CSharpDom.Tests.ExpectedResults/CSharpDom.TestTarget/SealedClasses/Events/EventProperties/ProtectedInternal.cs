namespace CSharpDom.TestTarget.SealedClasses.Events.EventProperties
{
    public sealed class SealedClassWithProtectedInternalEventProperty
    {
        protected internal event EventHandler Event
        {
            add { }
            remove { }
        }
    }
}
