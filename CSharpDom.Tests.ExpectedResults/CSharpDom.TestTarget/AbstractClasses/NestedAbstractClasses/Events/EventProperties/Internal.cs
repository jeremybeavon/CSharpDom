namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.Events.EventProperties
{
    public abstract class AbstractClassWithNestedAbstractClassWithInternalEventProperty
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
