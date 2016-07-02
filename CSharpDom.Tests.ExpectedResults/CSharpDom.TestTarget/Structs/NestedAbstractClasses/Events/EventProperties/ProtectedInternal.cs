namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.Events.EventProperties
{
    public struct StructWithNestedAbstractClassWithProtectedInternalEventProperty
    {
        public abstract class Class
        {
            protected internal event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
