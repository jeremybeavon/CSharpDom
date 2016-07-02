namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.Events.EventProperties
{
    public abstract class AbstractClassWithNestedAbstractClassWithNewVirtualEventProperty
    {
        public abstract class Class : BaseClassWithEvent
        {
            public new virtual event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
