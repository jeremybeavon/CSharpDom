namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.Events.EventProperties
{
    public sealed class SealedClassWithNestedPartialClassWithNewEventProperty
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
