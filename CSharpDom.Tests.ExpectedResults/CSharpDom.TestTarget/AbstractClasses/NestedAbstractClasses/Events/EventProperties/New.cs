namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.Events.EventProperties
{
    public abstract class AbstractClassWithNestedAbstractClassWithNewEventProperty
    {
        public abstract class Class : BaseClassWithEvent
        {
            public new event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
