namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.Events.EventProperties
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithInternalEventProperty
    {
        public abstract partial class Class
        {
            internal event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
