namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.Events.EventProperties
{
    public class ClassWithNestedPartialClassWithNewEventProperty
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
