namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.Events
{
    public partial struct PartialStructWithWithNestedAbstractClassWithNewStaticEvent
    {
        public abstract class Class : BaseClassWithEvent
        {
            public new static event EventHandler Event;
        }
    }
}
