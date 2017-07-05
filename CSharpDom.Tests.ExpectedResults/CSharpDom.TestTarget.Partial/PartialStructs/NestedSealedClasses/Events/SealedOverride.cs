namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.Events
{
    public partial struct PartialStructWithWithNestedSealedClassWithSealedOverrideEvent
    {
        public sealed class Class : BaseClassWithEvent
        {
            public sealed override event EventHandler Event;
        }
    }
}
