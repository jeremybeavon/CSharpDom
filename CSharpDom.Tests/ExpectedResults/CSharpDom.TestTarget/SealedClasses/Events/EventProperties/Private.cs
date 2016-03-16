namespace CSharpDom.TestTarget.SealedClasses.Events.EventProperties
{
    public sealed class SealedClassWithPrivateEventProperty
    {
        private event EventHandler Event
        {
            add { }
            remove { }
        }
    }
}
