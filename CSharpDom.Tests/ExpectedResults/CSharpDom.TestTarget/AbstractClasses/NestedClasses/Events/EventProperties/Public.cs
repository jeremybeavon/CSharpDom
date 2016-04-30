namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.Events.EventProperties
{
    public abstract class AbstractClassWithNestedClassWithPublicEventProperty
    {
        public class Class
        {
            public event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
