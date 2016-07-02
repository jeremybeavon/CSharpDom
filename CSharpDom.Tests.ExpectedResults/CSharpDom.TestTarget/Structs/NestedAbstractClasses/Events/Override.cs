namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.Events
{
    public struct StructWithNestedAbstractClassWithOverrideEvent
    {
        public abstract class Class : BaseClassWithEvent
        {
            public override event EventHandler Event;
        }
    }
}
