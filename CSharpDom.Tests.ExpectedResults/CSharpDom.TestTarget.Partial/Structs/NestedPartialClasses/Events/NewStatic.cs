namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.Events
{
    public struct StructWithNestedPartialClassWithNewStaticEvent
    {
        public class Class : BaseClassWithEvent
        {
            public new static event EventHandler Event;
        }
    }
}
