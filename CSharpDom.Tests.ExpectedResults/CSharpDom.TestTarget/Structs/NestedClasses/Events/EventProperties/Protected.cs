namespace CSharpDom.TestTarget.Structs.NestedClasses.Events.EventProperties
{
    public struct StructWithNestedClassWithProtectedEventProperty
    {
        public class Class
        {
            protected event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
