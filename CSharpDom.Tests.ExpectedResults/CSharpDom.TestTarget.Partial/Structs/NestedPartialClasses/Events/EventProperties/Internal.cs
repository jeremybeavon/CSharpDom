namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.Events.EventProperties
{
    public struct StructWithNestedPartialClassWithInternalEventProperty
    {
        public partial class Class
        {
            internal event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
