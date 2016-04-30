namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Events.EventProperties
{
    public sealed class SealedClassWithNestedAbstractClassWithInternalEventProperty
    {
        public abstract class Class
        {
            internal event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
