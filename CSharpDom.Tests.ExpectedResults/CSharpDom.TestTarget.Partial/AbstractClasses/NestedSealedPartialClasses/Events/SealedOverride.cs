namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.Events
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithSealedOverrideEvent
    {
        public sealed class Class : BaseClassWithEvent
        {
            public sealed override event EventHandler Event;
        }
    }
}
