namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.Events
{
    public struct StructWithNestedAbstractPartialClassWithSealedOverrideEvent
    {
        public abstract class Class : BaseClassWithEvent
        {
            public sealed override event EventHandler Event;
        }
    }
}
