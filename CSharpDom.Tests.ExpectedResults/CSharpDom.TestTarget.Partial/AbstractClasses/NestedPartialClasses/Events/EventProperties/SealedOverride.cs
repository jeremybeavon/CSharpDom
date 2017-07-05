namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.Events.EventProperties
{
    public abstract class AbstractClassWithNestedPartialClassWithSealedOverrideEventProperty
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
