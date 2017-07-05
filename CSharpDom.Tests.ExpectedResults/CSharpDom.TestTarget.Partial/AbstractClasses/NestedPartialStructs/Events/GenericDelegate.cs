namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.Events
{
    public abstract class AbstractClassWithNestedStructWithEventWithGenericDelegate
    {
        public struct Struct
        {
            public event EventHandler<EventArgs> Event;
        }
    }
}
