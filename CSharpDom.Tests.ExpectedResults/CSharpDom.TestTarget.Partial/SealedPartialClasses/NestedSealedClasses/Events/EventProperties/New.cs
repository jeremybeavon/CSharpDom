namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.Events.EventProperties
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithNewEventProperty
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
