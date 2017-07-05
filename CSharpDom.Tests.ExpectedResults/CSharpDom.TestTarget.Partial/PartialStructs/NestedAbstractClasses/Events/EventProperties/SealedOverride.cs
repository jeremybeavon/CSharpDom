namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.Events.EventProperties
{
    public partial struct PartialStructWithWithNestedAbstractClassWithSealedOverrideEventProperty
    {
        public abstract class Class : BaseClassWithEvent
        {
            public sealed override event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
