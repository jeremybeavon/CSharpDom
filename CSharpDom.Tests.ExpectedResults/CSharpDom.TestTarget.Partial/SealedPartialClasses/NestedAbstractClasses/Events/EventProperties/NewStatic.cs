namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.Events.EventProperties
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithNewStaticEventProperty
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
