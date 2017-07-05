namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.Events
{
    public partial struct PartialStructWithWithNestedAbstractClassWithNewVirtualEvent
    {
        public abstract class Class : BaseClassWithEvent
        {
            public new virtual event EventHandler Event;
        }
    }
}
