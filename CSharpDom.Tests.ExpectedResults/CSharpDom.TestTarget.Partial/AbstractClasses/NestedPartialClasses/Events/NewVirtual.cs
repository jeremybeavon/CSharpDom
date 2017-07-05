namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.Events
{
    public abstract class AbstractClassWithNestedPartialClassWithNewVirtualEvent
    {
        public class Class : BaseClassWithEvent
        {
            public new virtual event EventHandler Event;
        }
    }
}
