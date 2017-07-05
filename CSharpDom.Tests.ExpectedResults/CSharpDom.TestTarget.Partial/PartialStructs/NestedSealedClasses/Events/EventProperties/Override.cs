namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.Events.EventProperties
{
    public partial struct PartialStructWithWithNestedSealedClassWithOverrideEventProperty
    {
        public sealed class Class : BaseClassWithEvent
        {
            public override event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
