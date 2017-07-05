namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.Events
{
    public struct StructWithNestedPartialClassWithNewEvent
    {
        public class Class : BaseClassWithEvent
        {
            public new event EventHandler Event;
        }
    }
}
