namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.Events
{
    public struct StructWithNestedSealedClassWithSealedOverrideEvent
    {
        public sealed class Class : BaseClassWithEvent
        {
            public sealed override event EventHandler Event;
        }
    }
}
