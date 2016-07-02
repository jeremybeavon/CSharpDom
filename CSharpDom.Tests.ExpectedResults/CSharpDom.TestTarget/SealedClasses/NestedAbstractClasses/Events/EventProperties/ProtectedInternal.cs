namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Events.EventProperties
{
    public sealed class SealedClassWithNestedAbstractClassWithProtectedInternalEventProperty
    {
        public abstract class Class
        {
            protected internal event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
