namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.Events
{
    public class ClassWithNestedStructWithEventWithGenericDelegate
    {
        public struct Struct
        {
            public event EventHandler<EventArgs> Event;
        }
    }
}
