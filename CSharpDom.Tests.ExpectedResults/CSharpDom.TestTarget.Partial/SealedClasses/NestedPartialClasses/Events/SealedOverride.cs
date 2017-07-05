namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.Events
{
    public sealed class SealedClassWithNestedPartialClassWithSealedOverrideEvent
    {
        public class Class : BaseClassWithEvent
        {
            public sealed override event EventHandler Event;
        }
    }
}
