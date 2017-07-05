namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.Events
{
    public static class StaticClassWithNestedSealedPartialClassWithNewStaticEvent
    {
        public sealed class Class : BaseClassWithEvent
        {
            public new static event EventHandler Event;
        }
    }
}
