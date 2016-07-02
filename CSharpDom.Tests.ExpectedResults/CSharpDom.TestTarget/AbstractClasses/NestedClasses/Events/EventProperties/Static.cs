namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.Events.EventProperties
{
    public abstract class AbstractClassWithNestedClassWithStaticEventProperty
    {
        public class Class
        {
            public static event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
