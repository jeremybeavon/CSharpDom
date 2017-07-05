namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.Events
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithSealedOverrideEvent
    {
        public abstract class Class : BaseClassWithEvent
        {
            public sealed override event EventHandler Event;
        }
    }
}
