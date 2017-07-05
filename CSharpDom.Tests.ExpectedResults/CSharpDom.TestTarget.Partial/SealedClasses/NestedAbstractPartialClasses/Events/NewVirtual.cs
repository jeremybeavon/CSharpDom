namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.Events
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithNewVirtualEvent
    {
        public abstract class Class : BaseClassWithEvent
        {
            public new virtual event EventHandler Event;
        }
    }
}
