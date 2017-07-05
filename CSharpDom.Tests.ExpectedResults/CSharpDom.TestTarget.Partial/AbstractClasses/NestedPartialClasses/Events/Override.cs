namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.Events
{
    public abstract class AbstractClassWithNestedPartialClassWithOverrideEvent
    {
        public class Class : BaseClassWithEvent
        {
            public override event EventHandler Event;
        }
    }
}
