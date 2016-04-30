namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.Events.EventProperties
{
    public abstract class AbstractClassWithNestedAbstractClassWithProtectedEventProperty
    {
        public abstract class Class
        {
            protected event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
