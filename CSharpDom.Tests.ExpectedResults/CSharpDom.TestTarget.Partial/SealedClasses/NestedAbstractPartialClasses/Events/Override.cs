namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.Events
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithOverrideEvent
    {
        public abstract class Class : BaseClassWithEvent
        {
            public override event EventHandler Event;
        }
    }
}
