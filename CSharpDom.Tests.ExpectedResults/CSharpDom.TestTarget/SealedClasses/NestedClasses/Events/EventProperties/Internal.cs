namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.Events.EventProperties
{
    public sealed class SealedClassWithNestedClassWithInternalEventProperty
    {
        public class Class
        {
            internal event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
