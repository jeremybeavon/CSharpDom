namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.Events.EventProperties
{
    public partial class PartialClassWithNestedAbstractClassWithSealedOverrideEventProperty
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
