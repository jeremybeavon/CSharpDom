namespace CSharpDom.TestTarget.Structs.NestedClasses.Events.EventProperties
{
    public struct StructWithNestedClassWithPublicEventProperty
    {
        public class Class
        {
            public event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
