namespace CSharpDom.TestTarget.AbstractClasses.NestedStructs.Events
{
    public abstract class AbstractClassWithNestedStructWithInternalEvent
    {
        public struct Struct
        {
            internal event EventHandler Event;
        }
    }
}
