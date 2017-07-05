namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.Events
{
    public partial struct PartialStructWithWithNestedAbstractClassWithSealedOverrideEvent
    {
        public abstract class Class : BaseClassWithEvent
        {
            public sealed override event EventHandler Event;
        }
    }
}
