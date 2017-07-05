namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.Events.EventProperties
{
    public sealed class SealedClassWithNestedSealedPartialClassWithProtectedInternalEventProperty
    {
        public sealed partial class Class
        {
            protected internal event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
