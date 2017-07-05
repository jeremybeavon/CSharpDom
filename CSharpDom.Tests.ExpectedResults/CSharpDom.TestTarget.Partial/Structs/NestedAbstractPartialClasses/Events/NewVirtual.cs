namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.Events
{
    public struct StructWithNestedAbstractPartialClassWithNewVirtualEvent
    {
        public abstract class Class : BaseClassWithEvent
        {
            public new virtual event EventHandler Event;
        }
    }
}
