namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.Events.EventProperties
{
    public sealed class SealedClassWithNestedSealedPartialClassWithSealedOverrideEventProperty
    {
        public sealed class Class : BaseClassWithEvent
        {
            public sealed override event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
