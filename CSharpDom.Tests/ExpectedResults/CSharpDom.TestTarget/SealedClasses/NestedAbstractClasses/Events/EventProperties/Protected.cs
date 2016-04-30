namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Events.EventProperties
{
    public sealed class SealedClassWithNestedAbstractClassWithProtectedEventProperty
    {
        public abstract class Class
        {
            protected event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
