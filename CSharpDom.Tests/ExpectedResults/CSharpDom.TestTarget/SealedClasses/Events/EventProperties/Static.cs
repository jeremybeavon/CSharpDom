namespace CSharpDom.TestTarget.SealedClasses.Events.EventProperties
{
    public sealed class SealedClassWithStaticEventProperty
    {
        public static event EventHandler Event
        {
            add { }
            remove { }
        }
    }
}
