namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.Events
{
    public abstract class AbstractClassWithNestedAbstractClassWithOverrideEvent
    {
        public abstract class Class : BaseClassWithEvent
        {
            public override event EventHandler Event;
        }
    }
}
