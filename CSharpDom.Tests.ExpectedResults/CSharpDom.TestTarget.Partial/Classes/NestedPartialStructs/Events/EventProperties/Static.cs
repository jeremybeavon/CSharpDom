namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.Events.EventProperties
{
    public class ClassWithNestedStructWithStaticEventProperty
    {
        public struct Struct
        {
            public static event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
