namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.Events.EventProperties
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithProtectedInternalEventProperty
    {
        public abstract partial class Class
        {
            protected internal event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
