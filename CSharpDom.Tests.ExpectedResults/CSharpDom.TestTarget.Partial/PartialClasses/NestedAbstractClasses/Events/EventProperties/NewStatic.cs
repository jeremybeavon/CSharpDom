namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.Events.EventProperties
{
    public partial class PartialClassWithNestedAbstractClassWithNewStaticEventProperty
    {
        public abstract class Class : BaseClassWithEvent
        {
            public new static event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
