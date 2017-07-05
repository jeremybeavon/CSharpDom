namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.Events
{
    public partial struct PartialStructWithWithNestedAbstractClassWithOverrideEvent
    {
        public abstract class Class : BaseClassWithEvent
        {
            public override event EventHandler Event;
        }
    }
}
