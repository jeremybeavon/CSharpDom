namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.Events
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithOverrideEvent
    {
        public abstract class Class : BaseClassWithEvent
        {
            public override event EventHandler Event;
        }
    }
}
