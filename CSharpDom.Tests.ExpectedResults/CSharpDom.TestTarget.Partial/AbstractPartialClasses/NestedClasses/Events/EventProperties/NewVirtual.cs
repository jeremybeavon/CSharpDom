namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.Events.EventProperties
{
    public abstract partial class AbstractPartialClassWithNestedClassWithNewVirtualEventProperty
    {
        public class Class : BaseClassWithEvent
        {
            public new virtual event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
