namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.Events.EventProperties
{
    public abstract class AbstractClassWithNestedStructWithInternalEventProperty
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
