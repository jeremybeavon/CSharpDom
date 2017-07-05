namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.Events.EventProperties
{
    public partial struct PartialStructWithWithNestedSealedClassWithProtectedInternalEventProperty
    {
        public sealed class Class
        {
            protected internal event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
