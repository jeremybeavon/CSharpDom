namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.Events
{
    public partial class PartialClassWithNestedSealedClassWithNewEvent
    {
        public sealed class Class : BaseClassWithEvent
        {
            public new event EventHandler Event;
        }
    }
}
