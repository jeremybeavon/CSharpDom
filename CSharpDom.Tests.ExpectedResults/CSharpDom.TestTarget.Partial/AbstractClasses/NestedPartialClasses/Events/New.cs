namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.Events
{
    public abstract class AbstractClassWithNestedPartialClassWithNewEvent
    {
        public class Class : BaseClassWithEvent
        {
            public new event EventHandler Event;
        }
    }
}
