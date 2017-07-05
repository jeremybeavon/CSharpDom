namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.Events
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithNewStaticEvent
    {
        public sealed class Class : BaseClassWithEvent
        {
            public new static event EventHandler Event;
        }
    }
}
