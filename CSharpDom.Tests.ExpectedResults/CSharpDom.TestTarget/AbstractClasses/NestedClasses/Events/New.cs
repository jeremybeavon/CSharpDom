namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.Events
{
    public abstract class AbstractClassWithNestedClassWithNewEvent
    {
        public class Class : BaseClassWithEvent
        {
            public new event EventHandler Event;
        }
    }
}
