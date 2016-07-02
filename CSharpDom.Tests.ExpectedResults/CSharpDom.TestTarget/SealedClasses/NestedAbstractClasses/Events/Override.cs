namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Events
{
    public sealed class SealedClassWithNestedAbstractClassWithOverrideEvent
    {
        public abstract class Class : BaseClassWithEvent
        {
            public override event EventHandler Event;
        }
    }
}
