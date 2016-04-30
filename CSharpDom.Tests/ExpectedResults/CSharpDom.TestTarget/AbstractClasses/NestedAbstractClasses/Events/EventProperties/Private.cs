namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.Events.EventProperties
{
    public abstract class AbstractClassWithNestedAbstractClassWithPrivateEventProperty
    {
        public abstract class Class
        {
            private event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
