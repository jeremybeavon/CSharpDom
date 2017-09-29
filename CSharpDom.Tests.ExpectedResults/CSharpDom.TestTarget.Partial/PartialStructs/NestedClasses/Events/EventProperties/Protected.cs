namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.Events.EventProperties
{
    public partial struct PartialStructWithNestedClassWithProtectedEventProperty
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
