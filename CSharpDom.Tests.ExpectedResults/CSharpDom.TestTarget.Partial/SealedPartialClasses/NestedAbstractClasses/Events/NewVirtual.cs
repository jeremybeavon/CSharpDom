namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.Events
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithNewVirtualEvent
    {
        public abstract class Class : BaseClassWithEvent
        {
            public new virtual event EventHandler Event;
        }
    }
}
