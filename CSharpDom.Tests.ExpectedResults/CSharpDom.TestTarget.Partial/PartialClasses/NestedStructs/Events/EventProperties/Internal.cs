namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.Events.EventProperties
{
    public partial class PartialClassWithNestedStructWithInternalEventProperty
    {
        public struct Struct
        {
            internal event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
