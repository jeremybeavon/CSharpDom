namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedSealedClasses.Events
{
    public abstract partial class AbstractPartialClassWithNestedSealedClassWithOverrideEvent
    {
        public sealed class Class : BaseClassWithEvent
        {
            public override event EventHandler Event;
        }
    }
}
