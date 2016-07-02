namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.Events.EventProperties
{
    public class ClassWithNestedAbstractClassWithNewVirtualEventProperty
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
