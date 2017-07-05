namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.Events
{
    public struct StructWithNestedAbstractPartialClassWithNewEvent
    {
        public abstract class Class : BaseClassWithEvent
        {
            public new event EventHandler Event;
        }
    }
}
