namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedAbstractClasses.Events.EventProperties
{
    public abstract partial class AbstractPartialClassWithNestedAbstractClassWithNewVirtualEventProperty
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
