namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.Events
{
    public struct StructWithNestedAbstractClassWithNewVirtualEvent
    {
        public abstract class Class : BaseClassWithEvent
        {
            public new virtual event EventHandler Event;
        }
    }
}
