namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.Events
{
    public abstract class AbstractClassWithNestedAbstractClassWithNewStaticEvent
    {
        public abstract class Class : BaseClassWithEvent
        {
            public new static event EventHandler Event;
        }
    }
}
