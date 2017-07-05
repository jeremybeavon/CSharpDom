namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.Events
{
    public sealed class SealedClassWithNestedPartialClassWithNewEvent
    {
        public class Class : BaseClassWithEvent
        {
            public new event EventHandler Event;
        }
    }
}
