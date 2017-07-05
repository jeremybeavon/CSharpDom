namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedAbstractClasses.Events.EventProperties
{
    public abstract partial class AbstractPartialClassWithNestedAbstractClassWithOverrideEventProperty
    {
        public abstract class Class : BaseClassWithEvent
        {
            public override event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
