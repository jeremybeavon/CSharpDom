namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.Events.EventProperties
{
    public partial class PartialClassWithNestedSealedClassWithNewEventProperty
    {
        public sealed class Class : BaseClassWithEvent
        {
            public new event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
