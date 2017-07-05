namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.Events.EventProperties
{
    public sealed class SealedClassWithNestedSealedPartialClassWithInternalEventProperty
    {
        public sealed partial class Class
        {
            internal event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
