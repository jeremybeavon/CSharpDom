namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.Events.EventProperties
{
    public abstract class AbstractClassWithNestedClassWithInternalEventProperty
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
