namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Events.EventProperties
{
    public abstract class AbstractClassWithNestedSealedClassWithProtectedEventProperty
    {
        public sealed class Class
        {
            protected event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
