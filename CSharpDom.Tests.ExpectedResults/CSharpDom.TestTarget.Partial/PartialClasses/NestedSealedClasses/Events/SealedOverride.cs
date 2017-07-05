namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.Events
{
    public partial class PartialClassWithNestedSealedClassWithSealedOverrideEvent
    {
        public sealed class Class : BaseClassWithEvent
        {
            public sealed override event EventHandler Event;
        }
    }
}
