namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.Events.EventProperties
{
    public abstract class AbstractClassWithNestedAbstractClassWithProtectedInternalEventProperty
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
