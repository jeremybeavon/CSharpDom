namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.Events
{
    public sealed partial class SealedPartialClassWithNestedClassWithNewStaticEvent
    {
        public class Class : BaseClassWithEvent
        {
            public new static event EventHandler Event;
        }
    }
}
