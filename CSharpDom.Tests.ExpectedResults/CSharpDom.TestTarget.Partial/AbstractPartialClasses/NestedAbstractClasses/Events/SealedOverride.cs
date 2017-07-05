namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedAbstractClasses.Events
{
    public abstract partial class AbstractPartialClassWithNestedAbstractClassWithSealedOverrideEvent
    {
        public abstract class Class : BaseClassWithEvent
        {
            public sealed override event EventHandler Event;
        }
    }
}
