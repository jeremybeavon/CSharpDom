namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.Events
{
    public abstract class AbstractClassWithNestedAbstractClassWithNewEvent
    {
        public abstract class Class : BaseClassWithEvent
        {
            public new event EventHandler Event;
        }
    }
}
