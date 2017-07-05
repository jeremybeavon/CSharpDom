namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.Events
{
    public abstract class AbstractClassWithNestedPartialClassWithSealedOverrideEvent
    {
        public class Class : BaseClassWithEvent
        {
            public sealed override event EventHandler Event;
        }
    }
}
