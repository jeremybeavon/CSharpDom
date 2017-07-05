namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.Events
{
    public struct StructWithNestedPartialClassWithOverrideEvent
    {
        public class Class : BaseClassWithEvent
        {
            public override event EventHandler Event;
        }
    }
}
