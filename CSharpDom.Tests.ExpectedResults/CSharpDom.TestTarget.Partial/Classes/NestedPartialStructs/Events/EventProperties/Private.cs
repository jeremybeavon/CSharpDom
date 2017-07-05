namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.Events.EventProperties
{
    public class ClassWithNestedStructWithPrivateEventProperty
    {
        public struct Struct
        {
            private event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
