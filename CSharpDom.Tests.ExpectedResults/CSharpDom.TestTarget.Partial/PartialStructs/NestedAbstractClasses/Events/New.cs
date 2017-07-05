namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.Events
{
    public partial struct PartialStructWithWithNestedAbstractClassWithNewEvent
    {
        public abstract class Class : BaseClassWithEvent
        {
            public new event EventHandler Event;
        }
    }
}
