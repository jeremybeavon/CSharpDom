namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.Events.EventProperties
{
    public struct StructWithNestedSealedClassWithSealedOverrideEventProperty
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
