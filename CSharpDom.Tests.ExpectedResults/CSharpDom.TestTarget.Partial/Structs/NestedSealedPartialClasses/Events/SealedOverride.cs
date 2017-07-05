namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.Events
{
    public struct StructWithNestedSealedPartialClassWithSealedOverrideEvent
    {
        public sealed class Class : BaseClassWithEvent
        {
            public sealed override event EventHandler Event;
        }
    }
}
