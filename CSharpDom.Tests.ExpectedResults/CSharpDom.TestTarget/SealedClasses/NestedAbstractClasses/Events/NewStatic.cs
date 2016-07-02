namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Events
{
    public sealed class SealedClassWithNestedAbstractClassWithNewStaticEvent
    {
        public abstract class Class : BaseClassWithEvent
        {
            public new static event EventHandler Event;
        }
    }
}
