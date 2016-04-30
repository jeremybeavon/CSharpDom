namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Events.EventProperties
{
    public sealed class SealedClassWithNestedSealedClassWithProtectedEventProperty
    {
        public sealed class Class
        {
            protected event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
