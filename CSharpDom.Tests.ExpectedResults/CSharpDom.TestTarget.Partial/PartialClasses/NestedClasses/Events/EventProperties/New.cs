namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.Events.EventProperties
{
    public partial class PartialClassWithNestedClassWithNewEventProperty
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
