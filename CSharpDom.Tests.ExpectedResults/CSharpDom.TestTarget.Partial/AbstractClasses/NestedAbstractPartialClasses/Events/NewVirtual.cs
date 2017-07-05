namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.Events
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithNewVirtualEvent
    {
        public abstract class Class : BaseClassWithEvent
        {
            public new virtual event EventHandler Event;
        }
    }
}
