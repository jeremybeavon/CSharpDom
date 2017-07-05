namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.Events.EventProperties
{
    public struct StructWithNestedSealedPartialClassWithSealedOverrideEventProperty
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
