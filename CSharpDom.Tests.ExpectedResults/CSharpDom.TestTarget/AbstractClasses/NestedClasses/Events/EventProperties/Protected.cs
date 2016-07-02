namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.Events.EventProperties
{
    public abstract class AbstractClassWithNestedClassWithProtectedEventProperty
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
