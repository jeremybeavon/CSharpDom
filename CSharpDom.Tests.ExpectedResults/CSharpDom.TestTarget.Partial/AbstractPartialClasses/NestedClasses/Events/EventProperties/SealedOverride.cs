namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.Events.EventProperties
{
    public abstract partial class AbstractPartialClassWithNestedClassWithSealedOverrideEventProperty
    {
        public class Class : BaseClassWithEvent
        {
            public sealed override event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
