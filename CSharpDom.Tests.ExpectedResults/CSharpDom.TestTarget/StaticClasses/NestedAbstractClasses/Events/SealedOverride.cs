namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Events
{
    public static class StaticClassWithNestedAbstractClassWithSealedOverrideEvent
    {
        public abstract class Class : BaseClassWithEvent
        {
            public sealed override event EventHandler Event;
        }
    }
}
