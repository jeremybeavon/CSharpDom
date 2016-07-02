namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.Events.EventProperties
{
    public abstract class AbstractClassWithNestedClassWithNewVirtualEventProperty
    {
        public class Class : BaseClassWithEvent
        {
            public new virtual event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
