namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.Events.EventProperties
{
    public abstract class AbstractClassWithNestedAbstractClassWithVirtualEventProperty
    {
        public abstract class Class
        {
            public virtual event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
