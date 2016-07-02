namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Events.EventProperties
{
    public sealed class SealedClassWithNestedSealedClassWithPublicEventProperty
    {
        public sealed class Class
        {
            public event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
