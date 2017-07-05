namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractPartialClasses.Events
{
    public static class StaticClassWithNestedAbstractPartialClassWithSealedOverrideEvent
    {
        public abstract class Class : BaseClassWithEvent
        {
            public sealed override event EventHandler Event;
        }
    }
}
