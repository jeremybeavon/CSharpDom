namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.Events
{
    public abstract class AbstractClassWithNestedAbstractClassWithSealedOverrideEvent
    {
        public abstract class Class : BaseClassWithEvent
        {
            public sealed override event EventHandler Event;
        }
    }
}
