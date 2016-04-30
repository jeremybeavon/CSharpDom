namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Events
{
    public static class StaticClassWithNestedSealedClassWithNewEvent
    {
        public sealed class Class : BaseClassWithEvent
        {
            public new event EventHandler Event;
        }
    }
}
