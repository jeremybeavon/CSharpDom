namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.Events.EventProperties
{
    public sealed class SealedClassWithNestedClassWithProtectedEventProperty
    {
        public class Class
        {
            protected event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
