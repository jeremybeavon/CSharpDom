namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.Events
{
    public sealed class SealedClassWithNestedPartialClassWithOverrideEvent
    {
        public class Class : BaseClassWithEvent
        {
            public override event EventHandler Event;
        }
    }
}
