namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.Events.EventProperties
{
    public struct StructWithNestedSealedPartialClassWithInternalEventProperty
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
