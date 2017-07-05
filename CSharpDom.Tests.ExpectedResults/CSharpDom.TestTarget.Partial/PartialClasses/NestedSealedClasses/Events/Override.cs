namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.Events
{
    public partial class PartialClassWithNestedSealedClassWithOverrideEvent
    {
        public sealed class Class : BaseClassWithEvent
        {
            public override event EventHandler Event;
        }
    }
}
