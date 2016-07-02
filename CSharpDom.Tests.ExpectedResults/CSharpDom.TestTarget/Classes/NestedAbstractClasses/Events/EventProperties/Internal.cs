namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.Events.EventProperties
{
    public class ClassWithNestedAbstractClassWithInternalEventProperty
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
