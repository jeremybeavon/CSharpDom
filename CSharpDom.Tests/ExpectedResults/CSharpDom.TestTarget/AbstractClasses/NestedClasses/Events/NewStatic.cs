namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.Events
{
    public abstract class AbstractClassWithNestedClassWithNewStaticEvent
    {
        public class Class : BaseClassWithEvent
        {
            public new static event EventHandler Event;
        }
    }
}
