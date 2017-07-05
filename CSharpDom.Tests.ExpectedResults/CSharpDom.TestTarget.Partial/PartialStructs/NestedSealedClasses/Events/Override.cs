namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.Events
{
    public partial struct PartialStructWithWithNestedSealedClassWithOverrideEvent
    {
        public sealed class Class : BaseClassWithEvent
        {
            public override event EventHandler Event;
        }
    }
}
