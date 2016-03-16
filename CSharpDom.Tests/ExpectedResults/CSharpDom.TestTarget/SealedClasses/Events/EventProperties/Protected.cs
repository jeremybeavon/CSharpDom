namespace CSharpDom.TestTarget.SealedClasses.Events.EventProperties
{
    public sealed class SealedClassWithProtectedEventProperty
    {
        protected event EventHandler Event
        {
            add { }
            remove { }
        }
    }
}
