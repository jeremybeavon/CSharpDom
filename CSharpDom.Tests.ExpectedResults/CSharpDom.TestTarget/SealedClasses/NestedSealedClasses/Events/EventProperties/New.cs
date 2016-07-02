namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Events.EventProperties
{
    public sealed class SealedClassWithNestedSealedClassWithNewEventProperty
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
