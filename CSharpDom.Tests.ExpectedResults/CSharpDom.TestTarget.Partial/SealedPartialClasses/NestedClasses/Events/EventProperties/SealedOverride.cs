namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.Events.EventProperties
{
    public sealed partial class SealedPartialClassWithNestedClassWithSealedOverrideEventProperty
    {
        public class Class : BaseClassWithEvent
        {
            public sealed override event EventHandler Event
            {
                add { }
                remove { }
            }
        }
    }
}
