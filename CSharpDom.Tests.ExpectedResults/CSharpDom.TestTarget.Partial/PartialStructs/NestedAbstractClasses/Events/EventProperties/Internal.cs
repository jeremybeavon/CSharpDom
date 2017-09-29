namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.Events.EventProperties
{
    public partial struct PartialStructWithNestedAbstractClassWithInternalEventProperty
    {
        public abstract class Class
        {
            internal event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
