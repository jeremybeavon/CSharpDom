namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Events
{
    public abstract class AbstractClassWithNestedSealedClassWithNewEvent
    {
        public sealed class Class : BaseClassWithEvent
        {
            public new event EventHandler Event;
        }
    }
}
