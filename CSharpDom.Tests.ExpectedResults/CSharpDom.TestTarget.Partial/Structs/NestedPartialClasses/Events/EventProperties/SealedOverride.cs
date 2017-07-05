namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.Events.EventProperties
{
    public struct StructWithNestedPartialClassWithSealedOverrideEventProperty
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
