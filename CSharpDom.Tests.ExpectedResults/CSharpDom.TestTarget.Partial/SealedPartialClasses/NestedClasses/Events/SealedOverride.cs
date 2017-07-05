namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.Events
{
    public sealed partial class SealedPartialClassWithNestedClassWithSealedOverrideEvent
    {
        public class Class : BaseClassWithEvent
        {
            public sealed override event EventHandler Event;
        }
    }
}
