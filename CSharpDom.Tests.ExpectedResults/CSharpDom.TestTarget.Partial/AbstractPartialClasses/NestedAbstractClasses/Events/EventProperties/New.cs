namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedAbstractClasses.Events.EventProperties
{
    public abstract partial class AbstractPartialClassWithNestedAbstractClassWithNewEventProperty
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
