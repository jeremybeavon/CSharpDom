namespace CSharpDom.TestTarget.Structs.NestedClasses.Events.EventProperties
{
    public struct StructWithNestedClassWithStaticEventProperty
    {
        public class Class
        {
            public static event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
