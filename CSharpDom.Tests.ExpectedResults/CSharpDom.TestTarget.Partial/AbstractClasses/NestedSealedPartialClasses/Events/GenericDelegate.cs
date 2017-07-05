namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.Events
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithEventWithGenericDelegate
    {
        public sealed partial class Class
        {
            public event EventHandler<EventArgs> Event;
        }
    }
}
