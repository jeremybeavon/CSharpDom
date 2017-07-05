namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.Events
{
    public abstract partial class AbstractPartialClassWithNestedClassWithNewVirtualEvent
    {
        public class Class : BaseClassWithEvent
        {
            public new virtual event EventHandler Event;
        }
    }
}
