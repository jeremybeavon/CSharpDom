namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Events.EventProperties
{
    public abstract class AbstractClassWithNestedSealedClassWithInternalEventProperty
    {
        public sealed class Class
        {
            internal event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
