namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.Events.EventProperties
{
    public class ClassWithNestedSealedClassWithProtectedEventProperty
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
