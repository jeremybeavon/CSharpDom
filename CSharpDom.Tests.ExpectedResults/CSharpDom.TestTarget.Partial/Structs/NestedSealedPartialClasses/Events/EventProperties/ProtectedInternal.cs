namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.Events.EventProperties
{
    public struct StructWithNestedSealedPartialClassWithProtectedInternalEventProperty
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
