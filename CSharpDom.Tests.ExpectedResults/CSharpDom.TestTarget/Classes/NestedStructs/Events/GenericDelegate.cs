namespace CSharpDom.TestTarget.Classes.NestedStructs.Events
{
    public class ClassWithNestedStructWithEventWithGenericDelegate
    {
        public struct Struct
        {
            public event EventHandler<EventArgs> Event;
        }
    }
}
