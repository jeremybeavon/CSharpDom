namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.Events.EventProperties
{
    public static class StaticClassWithNestedPartialClassWithNewEventProperty
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
