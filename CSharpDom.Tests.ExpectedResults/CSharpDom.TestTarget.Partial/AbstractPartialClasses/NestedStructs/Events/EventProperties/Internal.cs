namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.Events.EventProperties
{
    public abstract partial class AbstractPartialClassWithNestedStructWithInternalEventProperty
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
