namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.Events.EventProperties
{
    public class ClassWithNestedStructWithInternalEventProperty
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
