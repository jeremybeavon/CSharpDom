namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.Events.EventProperties
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithNewStaticEventProperty
    {
        public sealed class Class : BaseClassWithEvent
        {
            public new static event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
