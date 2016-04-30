namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Events
{
    public abstract class AbstractClassWithNestedSealedClassWithNewStaticEvent
    {
        public sealed class Class : BaseClassWithEvent
        {
            public new static event EventHandler Event;
        }
    }
}
