namespace CSharpDom.TestTarget.Classes.NestedStructs.Events.EventProperties
{
    public class ClassWithNestedStructWithPublicEventProperty
    {
        public struct Struct
        {
            public event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
