namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Events
{
    public abstract class AbstractClassWithNestedSealedClassWithEventWithGenericDelegate
    {
        public sealed class Class
        {
            public event EventHandler<EventArgs> Event;
        }
    }
}
