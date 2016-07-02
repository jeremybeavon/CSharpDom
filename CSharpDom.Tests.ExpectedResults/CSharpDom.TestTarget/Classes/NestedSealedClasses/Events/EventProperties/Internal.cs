namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.Events.EventProperties
{
    public class ClassWithNestedSealedClassWithInternalEventProperty
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
