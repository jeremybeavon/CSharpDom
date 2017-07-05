namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.Events
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithSealedOverrideEvent
    {
        public abstract class Class : BaseClassWithEvent
        {
            public sealed override event EventHandler Event;
        }
    }
}
