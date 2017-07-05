namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedAbstractClasses.Events.EventProperties
{
    public abstract partial class AbstractPartialClassWithNestedAbstractClassWithSealedOverrideEventProperty
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
