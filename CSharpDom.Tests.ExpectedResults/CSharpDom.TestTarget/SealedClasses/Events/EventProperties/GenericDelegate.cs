namespace CSharpDom.TestTarget.SealedClasses.Events.EventProperties
{
    public sealed class SealedClassWithEventPropertyWithGenericDelegate
    {
        public event EventHandler<EventArgs> Event
        {
            add { }
            remove { }
        }
    }
}
