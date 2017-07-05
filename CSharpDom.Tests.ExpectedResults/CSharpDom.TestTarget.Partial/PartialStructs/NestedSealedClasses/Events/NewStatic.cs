namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.Events
{
    public partial struct PartialStructWithWithNestedSealedClassWithNewStaticEvent
    {
        public sealed class Class : BaseClassWithEvent
        {
            public new static event EventHandler Event;
        }
    }
}
