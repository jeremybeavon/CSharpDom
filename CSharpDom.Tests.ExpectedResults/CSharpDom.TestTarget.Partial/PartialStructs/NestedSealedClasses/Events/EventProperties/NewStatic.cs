namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.Events.EventProperties
{
    public partial struct PartialStructWithWithNestedSealedClassWithNewStaticEventProperty
    {
        public sealed class Class : BaseClassWithEvent
        {
            public new static event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
