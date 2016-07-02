namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.Events
{
    public struct StructWithNestedAbstractClassWithSealedOverrideEvent
    {
        public abstract class Class : BaseClassWithEvent
        {
            public sealed override event EventHandler Event;
        }
    }
}
