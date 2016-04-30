namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Events
{
    public static class StaticClassWithNestedSealedClassWithEventWithGenericDelegate
    {
        public sealed class Class
        {
            public event EventHandler<EventArgs> Event;
        }
    }
}
