namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Events
{
    public static class StaticClassWithNestedSealedClassWithOverrideEvent
    {
        public sealed class Class : BaseClassWithEvent
        {
            public override event EventHandler Event;
        }
    }
}
