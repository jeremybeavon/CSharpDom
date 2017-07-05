namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.Events
{
    public struct StructWithNestedPartialClassWithSealedOverrideEvent
    {
        public class Class : BaseClassWithEvent
        {
            public sealed override event EventHandler Event;
        }
    }
}
