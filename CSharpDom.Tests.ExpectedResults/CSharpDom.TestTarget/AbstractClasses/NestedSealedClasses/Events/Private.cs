namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Events
{
    public abstract class AbstractClassWithNestedSealedClassWithPrivateEvent
    {
        public sealed class Class
        {
            private event EventHandler Event;
        }
    }
}
