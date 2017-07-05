namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.Events.EventProperties
{
    public sealed class SealedClassWithNestedSealedPartialClassWithProtectedEventProperty
    {
        public sealed partial class Class
        {
            protected event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
