namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.Events.EventProperties
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithNewStaticEventProperty
    {
        public sealed class Class : BaseClassWithEvent
        {
            public new static event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
