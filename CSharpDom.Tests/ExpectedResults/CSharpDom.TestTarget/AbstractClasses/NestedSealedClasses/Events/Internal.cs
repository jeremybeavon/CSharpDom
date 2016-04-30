namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Events
{
    public abstract class AbstractClassWithNestedSealedClassWithInternalEvent
    {
        public sealed class Class
        {
            internal event EventHandler Event;
        }
    }
}
