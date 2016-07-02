namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.Events.EventProperties
{
    public abstract class AbstractClassWithNestedClassWithNewEventProperty
    {
        public class Class : BaseClassWithEvent
        {
            public new event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
