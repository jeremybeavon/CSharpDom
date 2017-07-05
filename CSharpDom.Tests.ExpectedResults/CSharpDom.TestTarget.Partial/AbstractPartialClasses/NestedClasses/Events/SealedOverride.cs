namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.Events
{
    public abstract partial class AbstractPartialClassWithNestedClassWithSealedOverrideEvent
    {
        public class Class : BaseClassWithEvent
        {
            public sealed override event EventHandler Event;
        }
    }
}
