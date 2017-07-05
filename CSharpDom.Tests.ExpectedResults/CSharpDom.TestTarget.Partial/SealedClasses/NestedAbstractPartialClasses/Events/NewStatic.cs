namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.Events
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithNewStaticEvent
    {
        public abstract class Class : BaseClassWithEvent
        {
            public new static event EventHandler Event;
        }
    }
}
