namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Events
{
    public static class StaticClassWithNestedSealedClassWithNewStaticEvent
    {
        public sealed class Class : BaseClassWithEvent
        {
            public new static event EventHandler Event;
        }
    }
}
