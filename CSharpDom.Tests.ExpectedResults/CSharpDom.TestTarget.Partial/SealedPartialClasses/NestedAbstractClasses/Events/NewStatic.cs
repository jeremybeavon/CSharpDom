namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.Events
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithNewStaticEvent
    {
        public abstract class Class : BaseClassWithEvent
        {
            public new static event EventHandler Event;
        }
    }
}
