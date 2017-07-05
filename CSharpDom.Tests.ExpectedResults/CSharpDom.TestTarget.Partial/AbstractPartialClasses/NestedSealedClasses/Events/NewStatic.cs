namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.Events
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithNewStaticEvent
    {
        public sealed class Class : BaseClassWithEvent
        {
            public new static event EventHandler Event;
        }
    }
}
