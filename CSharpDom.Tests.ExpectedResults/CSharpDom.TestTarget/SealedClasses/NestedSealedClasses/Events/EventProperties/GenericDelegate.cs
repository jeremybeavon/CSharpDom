namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Events.EventProperties
{
    public sealed class SealedClassWithNestedSealedClassWithEventPropertyWithGenericDelegate
    {
        public sealed class Class
        {
            public event EventHandler<EventArgs> Event
            {
                add { }
                remove { }
            }
        }
    }
}
