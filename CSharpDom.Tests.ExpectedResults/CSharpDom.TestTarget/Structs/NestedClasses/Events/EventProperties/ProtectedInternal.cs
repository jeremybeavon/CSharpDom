namespace CSharpDom.TestTarget.Structs.NestedClasses.Events.EventProperties
{
    public struct StructWithNestedClassWithProtectedInternalEventProperty
    {
        public class Class
        {
            protected internal event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
