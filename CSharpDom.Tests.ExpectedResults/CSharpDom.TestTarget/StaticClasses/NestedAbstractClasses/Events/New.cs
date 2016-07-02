namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Events
{
    public static class StaticClassWithNestedAbstractClassWithNewEvent
    {
        public abstract class Class : BaseClassWithEvent
        {
            public new event EventHandler Event;
        }
    }
}
