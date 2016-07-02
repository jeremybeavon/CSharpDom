namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Events
{
    public sealed class SealedClassWithNestedAbstractClassWithSealedOverrideEvent
    {
        public abstract class Class : BaseClassWithEvent
        {
            public sealed override event EventHandler Event;
        }
    }
}
