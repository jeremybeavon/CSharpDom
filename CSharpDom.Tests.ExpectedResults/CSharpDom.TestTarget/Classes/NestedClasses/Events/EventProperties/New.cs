namespace CSharpDom.TestTarget.Classes.NestedClasses.Events.EventProperties
{
    public class ClassWithNestedClassWithNewEventProperty
    {
        public class Class : BaseClassWithEvent
        {
            public new event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
