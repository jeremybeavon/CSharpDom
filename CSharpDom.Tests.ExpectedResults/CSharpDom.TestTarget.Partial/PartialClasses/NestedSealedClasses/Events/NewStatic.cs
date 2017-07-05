namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.Events
{
    public partial class PartialClassWithNestedSealedClassWithNewStaticEvent
    {
        public sealed class Class : BaseClassWithEvent
        {
            public new static event EventHandler Event;
        }
    }
}
