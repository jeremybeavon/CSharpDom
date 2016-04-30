namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Events
{
    public abstract class AbstractClassWithNestedSealedClassWithSealedOverrideEvent
    {
        public sealed class Class : BaseClassWithEvent
        {
            public sealed override event EventHandler Event;
        }
    }
}
