namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.Events.EventProperties
{
    public partial class PartialClassWithNestedAbstractClassWithNewVirtualEventProperty
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
