namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.Events
{
    public partial class PartialClassWithNestedAbstractClassWithSealedOverrideEvent
    {
        public abstract class Class : BaseClassWithEvent
        {
            public sealed override event EventHandler Event;
        }
    }
}
