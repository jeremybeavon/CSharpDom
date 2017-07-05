namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.Events
{
    public abstract class AbstractClassWithNestedPartialClassWithNewStaticEvent
    {
        public class Class : BaseClassWithEvent
        {
            public new static event EventHandler Event;
        }
    }
}
