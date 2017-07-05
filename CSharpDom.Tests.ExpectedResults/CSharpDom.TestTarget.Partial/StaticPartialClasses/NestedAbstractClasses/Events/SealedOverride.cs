namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses.Events
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithSealedOverrideEvent
    {
        public abstract class Class : BaseClassWithEvent
        {
            public sealed override event EventHandler Event;
        }
    }
}
