namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Events.EventProperties
{
    public sealed class SealedClassWithNestedSealedClassWithInternalEventProperty
    {
        public sealed class Class
        {
            internal event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
