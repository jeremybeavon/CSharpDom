namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.Events.EventProperties
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithOverrideEventProperty
    {
        public sealed class Class : BaseClassWithEvent
        {
            public override event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
