namespace CSharpDom.TestTarget.Classes.NestedStructs.Events.EventProperties
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
