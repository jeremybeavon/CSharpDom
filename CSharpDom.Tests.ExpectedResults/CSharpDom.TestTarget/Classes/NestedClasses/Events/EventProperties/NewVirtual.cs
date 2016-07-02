namespace CSharpDom.TestTarget.Classes.NestedClasses.Events.EventProperties
{
    public class ClassWithNestedClassWithNewVirtualEventProperty
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
