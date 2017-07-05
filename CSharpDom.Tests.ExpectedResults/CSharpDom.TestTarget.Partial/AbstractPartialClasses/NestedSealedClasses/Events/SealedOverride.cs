namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.Events
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithSealedOverrideEvent
    {
        public sealed class Class : BaseClassWithEvent
        {
            public sealed override event EventHandler Event;
        }
    }
}
