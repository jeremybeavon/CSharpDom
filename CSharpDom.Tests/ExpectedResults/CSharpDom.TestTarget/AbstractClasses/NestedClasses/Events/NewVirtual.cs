namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.Events
{
    public abstract class AbstractClassWithNestedClassWithNewVirtualEvent
    {
        public class Class : BaseClassWithEvent
        {
            public new virtual event EventHandler Event;
        }
    }
}
