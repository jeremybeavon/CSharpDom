namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.Events
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithOverrideEvent
    {
        public sealed class Class : BaseClassWithEvent
        {
            public override event EventHandler Event;
        }
    }
}
