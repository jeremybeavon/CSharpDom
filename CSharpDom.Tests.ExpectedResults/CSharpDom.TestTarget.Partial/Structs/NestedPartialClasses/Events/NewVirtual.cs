namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.Events
{
    public struct StructWithNestedPartialClassWithNewVirtualEvent
    {
        public class Class : BaseClassWithEvent
        {
            public new virtual event EventHandler Event;
        }
    }
}
