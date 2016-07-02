namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.Events
{
    public static class StaticClassWithNestedClassWithNewEvent
    {
        public class Class : BaseClassWithEvent
        {
            public new event EventHandler Event;
        }
    }
}
