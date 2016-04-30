namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.Events.EventProperties
{
    public abstract class AbstractClassWithNestedClassWithPrivateEventProperty
    {
        public class Class
        {
            private event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
