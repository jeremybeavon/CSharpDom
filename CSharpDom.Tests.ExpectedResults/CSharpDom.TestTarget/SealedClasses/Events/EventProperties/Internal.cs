namespace CSharpDom.TestTarget.SealedClasses.Events.EventProperties
{
    public sealed class SealedClassWithInternalEventProperty
    {
        internal event EventHandler Event
        {
            add { }
            remove { }
        }
    }
}
