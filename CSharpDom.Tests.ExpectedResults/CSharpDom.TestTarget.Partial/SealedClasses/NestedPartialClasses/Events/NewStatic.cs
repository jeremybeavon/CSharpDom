namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.Events
{
    public sealed class SealedClassWithNestedPartialClassWithNewStaticEvent
    {
        public class Class : BaseClassWithEvent
        {
            public new static event EventHandler Event;
        }
    }
}
