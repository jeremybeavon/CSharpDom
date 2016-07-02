namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.Events.EventProperties
{
    public class ClassWithNestedSealedClassWithProtectedInternalEventProperty
    {
        public sealed class Class
        {
            protected internal event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
