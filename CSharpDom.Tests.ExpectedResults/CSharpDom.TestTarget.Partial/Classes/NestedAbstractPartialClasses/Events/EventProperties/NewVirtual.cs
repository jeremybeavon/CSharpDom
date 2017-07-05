namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.Events.EventProperties
{
    public class ClassWithNestedAbstractPartialClassWithNewVirtualEventProperty
    {
        public abstract class Class : BaseClassWithEvent
        {
            public new virtual event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
