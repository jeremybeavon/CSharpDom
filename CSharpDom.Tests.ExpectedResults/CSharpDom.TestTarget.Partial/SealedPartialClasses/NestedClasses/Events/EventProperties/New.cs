namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.Events.EventProperties
{
    public sealed partial class SealedPartialClassWithNestedClassWithNewEventProperty
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
