namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.Events
{
    public sealed partial class SealedPartialClassWithNestedClassWithNewEvent
    {
        public class Class : BaseClassWithEvent
        {
            public new event EventHandler Event;
        }
    }
}
