namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.Events
{
    public struct StructWithNestedAbstractClassWithEventWithGenericDelegate
    {
        public abstract class Class
        {
            public event EventHandler<EventArgs> Event;
        }
    }
}
