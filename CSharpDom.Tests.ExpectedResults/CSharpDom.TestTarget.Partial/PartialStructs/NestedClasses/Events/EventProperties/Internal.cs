namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.Events.EventProperties
{
    public partial struct PartialStructWithNestedClassWithInternalEventProperty
    {
        public class Class
        {
            internal event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
