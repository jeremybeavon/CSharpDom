namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Events.EventProperties
{
    public sealed class SealedClassWithNestedSealedClassWithSealedOverrideEventProperty
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
