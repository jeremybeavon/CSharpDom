namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.Events
{
    public struct StructWithNestedAbstractPartialClassWithNewStaticEvent
    {
        public abstract class Class : BaseClassWithEvent
        {
            public new static event EventHandler Event;
        }
    }
}
