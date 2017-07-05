namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.Events
{
    public struct StructWithNestedAbstractPartialClassWithOverrideEvent
    {
        public abstract class Class : BaseClassWithEvent
        {
            public override event EventHandler Event;
        }
    }
}
